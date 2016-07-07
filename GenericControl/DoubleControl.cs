namespace GenericControl
{
    using System.Windows;

    public class DoubleControl : NumberControl
    {
        public new static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value),
            typeof(double),
            typeof(DoubleControl),
            new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public new double Value
        {
            get { return (double)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
    }
}