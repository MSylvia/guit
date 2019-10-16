﻿using System;

namespace Guit
{
    public class ListViewItemSelector<T>
    {
        readonly Func<T, string> valueProvider;

        public ListViewItemSelector(Func<T, string> valueProvider, int width)
            : this(valueProvider, width, null)
        { }

        public ListViewItemSelector(Func<T, string> valueProvider, string width)
             : this(valueProvider, 0, width)
        { }

        ListViewItemSelector(Func<T, string> valueProvider, int width, string? widthExpression)
        {
            this.valueProvider = valueProvider;
            
            Width = width;
            WidthExpression = widthExpression;
        }

        public string GetValue(T instance) => valueProvider(instance);

        public string? WidthExpression { get; }

        public int Width { get; }
    }
}