namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTask.Text != "")
            {
                clbTasks.Items.Add(txtTask.Text);
                txtTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clbTasks.SelectedItem != null)
            {
                clbTasks.Items.Remove(clbTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (clbTasks.Items.Count > 0)
            {
                clbTasks.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nothing to clear.");
            }
        }
    }
}
