namespace WForm2
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove_note_btn.Enabled = true;
        }

        private void Add_task_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count + 1}. {input_note_textBox.Text} ({input_date_textBox.Text})");
            input_note_textBox.Clear();
            input_date_textBox.Clear();
        }

        private void Remove_note_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

            if (listBox1.SelectedItem == null)
            {
                remove_note_btn.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (input_note_textBox.Text.Length > 0 && input_date_textBox.Text.Length > 0)
            {
                add_task_btn.Enabled = true;
                return;
            }
            add_task_btn.Enabled = false;
        }
    }
}
