﻿using System;
using System.Windows;
using System.Windows.Data;

namespace BetterGenshinImpact.View.Converters;

[ValueConversion(typeof(bool), typeof(bool))]
public sealed class InverseBooleanConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
    {
        if (targetType != typeof(bool) && targetType != typeof(bool?))
            throw new InvalidOperationException("The target must be a boolean");
        if (value == null)
            return DependencyProperty.UnsetValue;
        return !(bool)value;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, System.Globalization.CultureInfo culture)
    {
        if (targetType != typeof(bool) && targetType != typeof(bool?))
            throw new InvalidOperationException("The target must be a boolean");
        if (value == null)
            return DependencyProperty.UnsetValue;
        return !(bool)value;
    }
}
