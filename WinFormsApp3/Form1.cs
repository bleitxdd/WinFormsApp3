using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_MouseClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Reminder date: {dateTimePicker1.Text}\n\nReminder:\n{textBox1.Text}", caption: $"Reminder created", MessageBoxButtons.OK);
        }
    }
}