using System.ComponentModel;

namespace BindingWF;

public partial class Form1 : Form
{
    BindingList<Person> Persons { get; set; } = new BindingList<Person>();
    IEnumerator<Person> persons { get; set; }
    Person? SelectedPerson { get; set; } = null;
    ContextMenuStrip contextMenuStrip = new();
    public Form1()
    {
        InitializeComponent();
        persons = Person.GetEnumerator();
        contextMenuStrip.Items.AddRange(new[] { new ToolStripMenuItem("Удалить") });

        listBox1.DataSource = Persons;
        listBox1.ContextMenuStrip = contextMenuStrip;
        contextMenuStrip.Items[0].Click += ContextMenuDelete_Click;

        listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
       
      
        Persons.ListChanged += Persons_ListChanged;

        button1.Click += Button1_Click;


    }
 

    private void ContextMenuDelete_Click(object? sender, EventArgs e)
    {
        if (SelectedPerson != null)
        {
            var result = MessageBox.Show($"удалить {SelectedPerson} ?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Persons.Remove(SelectedPerson);
            }

        }
    }

    private void Persons_ListChanged(object? sender, ListChangedEventArgs e)
    {

        var listPerson = sender as BindingList<Person>;
        switch (e.ListChangedType)
        {
            case ListChangedType.Reset:
                SelectedPerson = null;
                break;
            case ListChangedType.ItemAdded:
                SelectedPerson=listPerson?.LastOrDefault();

                break;
            case ListChangedType.ItemDeleted:
                SelectedPerson = null;

                break;
            case ListChangedType.ItemMoved:
                break;
            case ListChangedType.ItemChanged:
                break;
            case ListChangedType.PropertyDescriptorAdded:
                break;
            case ListChangedType.PropertyDescriptorDeleted:
                break;
            case ListChangedType.PropertyDescriptorChanged:
                break;
            default:
                break;
        }
        

        listBox1.SelectedIndex = Persons.Count-1;
        SelectedPerson=Persons.LastOrDefault();
        label1.Text = SelectedPerson?.ToString();
    }

    private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (sender is ListBox list)
        {
            var ob = list.SelectedItem;
            if (ob is Person person)
            {
                SelectedPerson = person;
                label1.Text = person.ToString();
            }

        }

    }

    private void Button1_Click(object? sender, EventArgs e)
    {

        if (persons.MoveNext())
        {
            var curent = persons.Current;
            if (curent.Id > 0)
            {
                Persons.Add(persons.Current);
            }
        }
        else
        {
            MessageBox.Show("Empty!");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Persons.Clear();
        persons = Person.GetEnumerator();

    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (SelectedPerson != null && Persons.Contains(SelectedPerson))
        {
            var result = MessageBox.Show($"удалить {SelectedPerson} ?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Persons.Remove(SelectedPerson);
            }

        }
    }
}
