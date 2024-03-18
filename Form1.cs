using System.Collections.ObjectModel;

namespace BindingWF;

public partial class Form1 : Form
{
    ObservableCollection<Person> Persons { get; set; }= new ObservableCollection<Person>();
    IEnumerator<Person> persons { get; }= Person.GetEnumerator();
    public Form1()
    {
        InitializeComponent();
        this.DataContext = this;
        button1.Click += Button1_Click;
        listBox1.DataSource = Persons;
        listBox1.DisplayMember = "Name";

       // listBox1.DataBindings.Add(new Binding("DataSource", Persons, "Name"));
    }

    private void Button1_Click(object? sender, EventArgs e)
    {
       
        if (persons.MoveNext()) 
        { 
                Persons.Add(persons.Current);
        }
        else
        {
            MessageBox.Show("Empty!");
        }
    }
}
