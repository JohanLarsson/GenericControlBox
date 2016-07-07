namespace GenericControlBox
{
    using System.Windows;

    public class IntControl : NumberControl
    {
        public new static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value),
            typeof(int),
            typeof(IntControl),
            new PropertyMetadata(0));

        public new int Value
        {
            get { return (int)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
    }
}