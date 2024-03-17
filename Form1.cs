namespace BindingWF;

public partial class Form1 : Form
{
    List<Person> Persons { get; set; } = new List<Person>();
    IEnumerator<Person> persons { get; set; } = Person.GetEnumerator();
    public Form1()
    {
        InitializeComponent();
        button1.Click += Button1_Click;
        listBox1.DataSource = Persons;
        listBox1.DisplayMember = "Name";
       // listBox1.DataBindings.Add(new Binding("DataSource", Persons, "Name"));
    }

    private void Button1_Click(object? sender, EventArgs e)
    {
       
        if (persons.MoveNext()) 
        { 
            var curent=persons.Current;
            if (curent.Id >0)
            {
                Persons.Add(persons.Current);
            }
        }
        else
        {
            MessageBox.Show("Empty!");
        }
    }
}
