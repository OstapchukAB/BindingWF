using System.Collections;
using System.ComponentModel;

namespace BindingWF;

public class PersonsList : CollectionBase, IBindingList
{
    public bool AllowEdit => throw new NotImplementedException();

    public bool AllowNew => throw new NotImplementedException();

    public bool AllowRemove => throw new NotImplementedException();

    public bool IsSorted => throw new NotImplementedException();

    public ListSortDirection SortDirection => throw new NotImplementedException();

    public PropertyDescriptor? SortProperty => throw new NotImplementedException();

    public bool SupportsChangeNotification => throw new NotImplementedException();

    public bool SupportsSearching => throw new NotImplementedException();

    public bool SupportsSorting => throw new NotImplementedException();

    public event ListChangedEventHandler ListChanged;

    public void AddIndex(PropertyDescriptor property)
    {
        throw new NotImplementedException();
    }

    public object? AddNew()
    {
        throw new NotImplementedException();
    }

    public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
    {
        throw new NotImplementedException();
    }

    public int Find(PropertyDescriptor property, object key)
    {
        throw new NotImplementedException();
    }

    public void RemoveIndex(PropertyDescriptor property)
    {
        throw new NotImplementedException();
    }

    public void RemoveSort()
    {
        throw new NotImplementedException();
    }
}
