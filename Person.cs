using System.Collections;
using System.ComponentModel;

namespace BindingWF;
//https://stackoverflow.com/questions/33623991/databinding-to-list-see-changes-of-data-source-in-listbox-combobox
public class Person//: IBindingList
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public Person(int id,string name, string firstName)
    {
        Id = id; 
        Name = name;
        LastName = firstName;
    }
    public static IEnumerator<Person> GetEnumerator()
    {
        yield return new Person(1, "Andrey", "Ivanov");
        yield return new Person(2, "Micle", "Varlamov");
        yield return new Person(3, "Sergey", "Синицын");
        yield return new Person(4, "Samson", "Rubinshtein");

    }
    //public object? this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

   

    //public bool AllowEdit => throw new NotImplementedException();

    //public bool AllowNew => throw new NotImplementedException();

    //public bool AllowRemove => throw new NotImplementedException();

    //public bool IsSorted => throw new NotImplementedException();

    //public ListSortDirection SortDirection => throw new NotImplementedException();

    //public PropertyDescriptor? SortProperty => throw new NotImplementedException();

    //public bool SupportsChangeNotification => throw new NotImplementedException();

    //public bool SupportsSearching => throw new NotImplementedException();

    //public bool SupportsSorting => throw new NotImplementedException();

    //public bool IsFixedSize => throw new NotImplementedException();

    //public bool IsReadOnly => throw new NotImplementedException();

    //public int Count => throw new NotImplementedException();

    //public bool IsSynchronized => throw new NotImplementedException();

    //public object SyncRoot => throw new NotImplementedException();

    //public event ListChangedEventHandler ListChanged;

    

    //public int Add(object? value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void AddIndex(PropertyDescriptor property)
    //{
    //    throw new NotImplementedException();
    //}

    //public object? AddNew()
    //{
    //    throw new NotImplementedException();
    //}

    //public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Clear()
    //{
    //    throw new NotImplementedException();
    //}

    //public bool Contains(object? value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void CopyTo(Array array, int index)
    //{
    //    throw new NotImplementedException();
    //}

    //public int Find(PropertyDescriptor property, object key)
    //{
    //    throw new NotImplementedException();
    //}

    //public int IndexOf(object? value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Insert(int index, object? value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Remove(object? value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void RemoveAt(int index)
    //{
    //    throw new NotImplementedException();
    //}

    //public void RemoveIndex(PropertyDescriptor property)
    //{
    //    throw new NotImplementedException();
    //}

    //public void RemoveSort()
    //{
    //    throw new NotImplementedException();
    //}

    //public override string? ToString()
    //{
    //    return $"{Name} {LastName}";
    //}

    //IEnumerator IEnumerable.GetEnumerator()
    //{
    //    return Person.GetEnumerator();
    //}
}
