using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFlayout.ContentControl.DemoDependencyProperty
{
    /// <summary>
    /// CoordinateBox.xaml 的交互逻辑
    /// </summary>
    public partial class CoordinateBox : UserControl
    {
        public CoordinateBox()
        {
            InitializeComponent();
        }

        private void Lat_TextChanged(object sender, TextChangedEventArgs e)
        {
            OnTextChanged();
        }

        private void Lon_TextChanged(object sender, TextChangedEventArgs e)
        {
            OnTextChanged();
        }

        //当文本框内容改变时，为用户控件的Value属性赋值
        void OnTextChanged()
        {
            double lat = 0;
            double lon = 0;
            if (double.TryParse(Lat.Text == String.Empty ? "0" : Lat.Text, out lat) &
                double.TryParse(Lon.Text == String.Empty ? "0" : Lon.Text, out lon))
            {
                Value = new Coordinate(lat, lon);
            }
            else
            {
                UpdateValue();
            }
        }


        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value"
            , typeof(Coordinate)
            , typeof(CoordinateBox)
            , new FrameworkPropertyMetadata(null
                , FrameworkPropertyMetadataOptions.AffectsMeasure
                | FrameworkPropertyMetadataOptions.AffectsRender
                | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
                | FrameworkPropertyMetadataOptions.Inherits
                , new PropertyChangedCallback(OnValueChanged)
                , new CoerceValueCallback(CoerceValue)));


        //使用标准.NET属性包装依赖属性
        public Coordinate Value
        {
            get { return (Coordinate)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        //定义强制值回调，限制输入的数据不可以小于0，大于90，小于-180，大于180.
        static object CoerceValue(DependencyObject sender, object value)
        {
            Coordinate val = value as Coordinate;

            //如果值不为空，判断经纬度的大小，调整用户的输入，使其为特定值
            if (val != null)
            {
                if (val.Lat < 0)
                    val.Lat = 0;
                else if (val.Lat > 90)
                    val.Lat = 90;

                if (val.Lon < -180)
                    val.Lon = -180;
                else if (val.Lon > 180)
                    val.Lon = 180;
            }

            return val;
        }

        //属性值变更时，触发用户界面的更新，并更新用户界面
        static void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            CoordinateBox box = sender as CoordinateBox;

            //更新文本框的值
            box.UpdateValue();

            //定义路由事件参数
            RoutedPropertyChangedEventArgs<Coordinate> e = new RoutedPropertyChangedEventArgs<Coordinate>((Coordinate)args.OldValue
                , (Coordinate)args.NewValue
                , ValueChangedEvent);

            //触发路由事件
            box.OnValueChanged(e);
        }

        //定义并注册路由事件
        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent("ValueChanged"
            , RoutingStrategy.Bubble
            , typeof(RoutedPropertyChangedEventHandler<Coordinate>)
            , typeof(CoordinateBox));


        //定义标准的事件属性
        public event RoutedPropertyChangedEventHandler<Coordinate> ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        //更新文本框
        void UpdateValue()
        {
            this.Lat.Text = Value.Lat.ToString();
            this.Lon.Text = Value.Lon.ToString();
        }

        //触发事件
        void OnValueChanged(RoutedPropertyChangedEventArgs<Coordinate> e)
        {
            RaiseEvent(e);
        }
    }
}
