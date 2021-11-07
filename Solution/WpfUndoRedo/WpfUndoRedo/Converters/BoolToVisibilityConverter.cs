using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfUndoRedo.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public bool Invert { get; set; }
        public bool CollapseNotHide { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is bool show))
                return DependencyProperty.UnsetValue;

            var hideOption = CollapseNotHide ? Visibility.Collapsed : Visibility.Hidden;
            return show ^ Invert ? Visibility.Visible : hideOption;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return Binding.DoNothing;
        }
    }
}
