using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingWF;

public class Person:INotifyPropertyChanged
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set
        {
            if (value != _id)
            {
                _id = value;
                OnPropertyChanged();
            }
        }
    }
    public Person() { }

    //private string _name;

    public string Name { get; set; }
    //{
    //    get { return _name; }
    //    set 
    //    {
    //    if (value != _name)
    //        {
    //            _name = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //}

    public string LastName { get; set; }
    public Person(int id,string name, string firstName)
    {
        Id = id; 
        Name = name;
        LastName = firstName;
    }


    public event PropertyChangedEventHandler? PropertyChanged;
   protected void OnPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public static IEnumerator<Person> GetEnumerator()
    {
        yield return new Person(1, "Andrey", "Ivanov");
        yield return new Person(2, "Micle", "Varlamov");
        yield return new Person(3, "Sergey", "Синицын");
        yield return new Person(4, "Samson", "Rubinshtein");

    }

    public override string? ToString()
    {
        return $"{Id} {Name} {LastName}";
    }
}
