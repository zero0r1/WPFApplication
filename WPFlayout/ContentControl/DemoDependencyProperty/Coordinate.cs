using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFlayout.ContentControl.DemoDependencyProperty
{
    /// <summary>
    /// 定义依赖属性的类型，为了支持绑定更新功能，该类实现了INotifyPropertyChanged接口
    /// </summary>
    public class Coordinate : INotifyPropertyChanged
    {
        //定义事件, 供调用方订阅次事件
        public event PropertyChangedEventHandler PropertyChanged;

        //定义纬度
        double lat;
        public double Lat
        {
            get => lat;
            set
            {
                lat = value;
                FirePropertyChanged("Latitude");
            }
        }

        //定义经度
        double lon;
        public double Lon
        {
            get => lon;
            set
            {
                lon = value;
                FirePropertyChanged("Longitude");
            }
        }

        //构造函数
        public Coordinate(double lat, double lon)
        {
            this.Lat = lat;
            this.Lon = lon;
        }

        //用于触发事件的辅助方法
        internal void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
