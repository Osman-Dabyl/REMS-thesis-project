using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

public class SortableBindingList<T> : BindingList<T>
{
    private bool isSorted;
    private ListSortDirection sortDirection;
    private PropertyDescriptor sortProperty;

    public SortableBindingList() : base() { }

    public SortableBindingList(IList<T> list) : base(list) { }

    protected override bool SupportsSortingCore => true;

    protected override bool IsSortedCore => isSorted;

    protected override PropertyDescriptor SortPropertyCore => sortProperty;

    protected override ListSortDirection SortDirectionCore => sortDirection;

    protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
    {
        var items = (List<T>)Items;

        var property = typeof(T).GetProperty(prop.Name);
        if (property != null)
        {
            items.Sort((x, y) =>
            {
                int result = Compare(property.GetValue(x), property.GetValue(y));
                if (direction == ListSortDirection.Descending)
                {
                    result = -result;
                }
                return result;
            });
        }
        isSorted = true;
        sortDirection = direction;
        sortProperty = prop;
        ResetBindings();
    }

    protected override void RemoveSortCore()
    {
        isSorted = false;
        sortProperty = null;
        sortDirection = ListSortDirection.Ascending;
    }

    private int Compare(object xValue, object yValue)
    {
        if (xValue == null)
        {
            return yValue == null ? 0 : -1;
        }
        if (yValue == null)
        {
            return 1;
        }
        if (xValue is IComparable comparable)
        {
            return comparable.CompareTo(yValue);
        }
        return xValue.Equals(yValue) ? 0 : xValue.ToString().CompareTo(yValue.ToString());
    }
}
