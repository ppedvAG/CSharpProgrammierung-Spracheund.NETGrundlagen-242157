namespace M014_WinFormsGUI
{
    public partial class MainWindow : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem("Kochen"),
            new TaskItem("Essen"),
            new TaskItem("Trinken")
        };

        public MainWindow()
        {
            InitializeComponent();

            button1.BackColor = Color.Beige;
            button1.Click += NochEinEventHandler;

            var automarken = Enum.GetNames(typeof(Automarken));

            // Befuellen der ComboBox mit Enum-Elementen
            comboBox1.Items.AddRange(automarken);

            foreach (var item in tasks)
            {
                listBox1.Items.Add(item);
            }
        }

        // Weiterer Event-Handler der im Konstruktor definiert
        private void NochEinEventHandler(object? sender, EventArgs e)
        {
            var button = sender as Button;
            button.ForeColor = Color.Blue;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (checkBox1.Checked)
                {
                    button.BackColor = Color.Aqua;
                }
                else
                {
                    button.BackColor = Color.Beige;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb != null)
            {
                textBox1.Text = $"Hallo {cb.SelectedItem}";
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Wirklich beeden?", "Titel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            var task = textBox2.Text;
            if (!string.IsNullOrEmpty(task))
            {
                string priority = GetPriority();
                var taskItem = new TaskItem(task, priority);

                tasks.Add(taskItem);
                listBox1.Items.Add(taskItem);


                textBox1.Text = string.Empty;
            }
        }

        private string GetPriority()
        {
            if (rb0.Checked)
            {
                return rb0.Text;
            }
            if (rb2.Checked)
            {
                return rb2.Text;
            }
            return rb1.Text;
        }

        private void RemoveTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                tasks.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lblCurrentTask.Text = tasks[listBox1.SelectedIndex].Title;
            }
        }
    }
}
