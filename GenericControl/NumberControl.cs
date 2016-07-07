namespace GenericControl
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
            new PropertyMetadata(null, OnValueChanged));

        static NumberControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumberControl), new FrameworkPropertyMetadata(typeof(NumberControl)));
        }

        public string StringValue
        {
            get { return (string)this.GetValue(StringValueProperty); }
            set { this.SetValue(StringValueProperty, value); }
        }

        internal IFormattable Value
        {
            get { throw new InvalidOperationException("This is just a placeholder and should never be touched."); }
            set { throw new InvalidOperationException("This is just a placeholder and should never be touched.");}
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new InvalidOperationException("Should never change, only shadowing property should be used.");
        }
    }
}
