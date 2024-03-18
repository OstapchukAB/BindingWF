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

    public override string? ToString()
    {
        return $"{Id} {Name} {LastName}";
    }
}
