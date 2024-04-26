namespace CheckList
{
    public partial class Form1 : Form
    {
        List<string> MyToDo = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyToDo.Add(ToDoTbx.Text); // when adding text to the textbox

            ToDoListBox.DataSource = null; // making it null first
            ToDoListBox.DataSource = MyToDo;
        }

        private void ToDoListBox_Click(object sender, EventArgs e)
        {
            if (ToDoListBox.SelectedIndex == -1) // prevents executing clicking on empty listbox
                return;
            //if (MyToDo.Count <= 0) return; // prevents errors clicking on empty listbox
            MyToDo.RemoveAt(ToDoListBox.SelectedIndex);

            ToDoListBox.DataSource = null;
            ToDoListBox.DataSource = MyToDo;
        }
    }
}
