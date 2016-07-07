namespace GenericControlBox
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    public class NumberControl : Control 
    {
        public static readonly DependencyProperty StringValueProperty = DependencyProperty.Register(
            nameof(StringValue),
            typeof(string),
            typeof(NumberControl),
            new PropertyMetadata(default(string)));

        internal static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value",
            typeof(IFormattable),
            typeof(NumberControl),
            new PropertyMetadata(0));

        static NumberControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberControl), new FrameworkPropertyMetadata(typeof(NumberControl)));
        }

        public string StringValue
        {
            get{ return (string)this.GetValue(StringValueProperty);}
            set { this.SetValue(StringValueProperty, value); }
        }

        internal IFormattable Value
        {
            get { return (IFormattable)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
    }
}
