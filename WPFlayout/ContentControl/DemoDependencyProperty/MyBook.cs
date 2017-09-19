using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFlayout.ContentControl.DemoDependencyProperty
{
    public class MyBook : DependencyObject
    {
        //定义一个依赖属性
        //依赖属性有可能在几个对象之间传递, 因此需要定义为静态属性.
        //在 WPF 中通常以 Property 结尾的属性名称即为依赖属性.
        public static readonly DependencyProperty BookNameProperty;


        //为依赖属性定义标准的 .NET 属性的包装
        public string BookName
        {
            get { return (string)GetValue(BookNameProperty); }
            set { SetValue(BookNameProperty, value); }
        }

        static MyBook()
        {

            /*
             * Register方法的参数如下:
             * 属性名称: BookName
             * 属性的类型: String
             * 具有依赖属性的类型: Mybook
             * 可选的属性元数据: 用于为属性添加额外的功能
             * 可选的依赖属性的回调函数: 用于实现属性的验证
             **/

            //由于 DependencyObject 类没有 Public 级别的构造函数, 目的是确保 DependencyProperty 不会被直接实例化, 
            //所以需要使用 DependencyProperty.Register 方法
            //WPF 也确保 DependencyProperty 在创建后不会修改, 因此所有的 DependencyProperty 为只读的.
            BookNameProperty = DependencyProperty.Register("BookName", typeof(string), typeof(MyBook),
                new PropertyMetadata("No Name",                             //PropertyMetadata 的第一个参数作为默认值.
                    new PropertyChangedCallback(BookNameChangedCallback),   //属性变更回调
                    new CoerceValueCallback(BookNameCoerceCallback)),       //强制值回调
                    new ValidateValueCallback(BookNameValidateCallback));   //属性验证回调
        }

        //最后一步, 如果 优先 BookNameCoerceCallback(CoerceValueCallback), 再次 BookNameValidateCallback(ValidateValueCallback)
        //都回调成功, 触发自身 BookNameChangedCallback(PropertyChangedCallback). 如果想为其他的类提供更改通知, 
        //可在此回调中触发.
        static void BookNameChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.OldValue + " " + e.NewValue);
        }


        //可修改提供的值, 或者返回一个 DependencyProperty.UnsetValue, 表示属性系统没有明确赋值, 而拒绝当前的值
        static object BookNameCoerceCallback(DependencyObject obj, object o)
        {
            string s = o as string;
            if (s.Length > 8)
                s = s.Substring(0, 8);

            return s;
        }

        //在 BookNameCoerceCallback(CoerceValueCallback) 之后触发, 如果验证成功, 返回 TRUE
        static bool BookNameValidateCallback(object value)
        {
            return value != null;
        }
    }
}
