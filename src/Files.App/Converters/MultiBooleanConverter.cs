using System;
using Microsoft.UI.Xaml;

namespace Files.App.Converters
{
    internal class MultiBooleanConverter
    {
        public static Boolean OrConvert(bool a, bool b)
            => (a || b);

        public static Boolean AndConvert(bool a, bool b)
            => (a && b);

        public static Boolean AndNotConvert(bool a, bool b)
            => (a && !b);

        public static Boolean OrAndConvert(bool a, bool b, bool c)
            => (a || b) && c;

        public static Visibility OrConvertToVisibility(bool a, bool b)
            => (a || b) ? Visibility.Visible : Visibility.Collapsed;

        public static Visibility OrNotConvertToVisibility(bool a, bool b)
            => OrConvertToVisibility(a, !b);
    }
}