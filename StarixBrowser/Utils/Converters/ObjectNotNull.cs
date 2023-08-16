﻿using System;
using System.Globalization;

namespace StarixBrowser.Utils.Converters
{
    public class ObjectNotNull : ValueConverterBase<object, bool>
    {
        public override bool Convert(object value, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public override object ConvertBack(bool value, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
