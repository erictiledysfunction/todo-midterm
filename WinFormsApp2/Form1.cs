using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                LISTVIEW.Items.Add(txtTask.Text);
                txtTask.Clear();
                UpdateTaskCounts();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LISTVIEW.SelectedItems.Count > 0)
            {
                LISTVIEW.Items.Remove(LISTVIEW.SelectedItems[0]);
                UpdateTaskCounts();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (LISTVIEW.Items.Count > 0)
            {
                LISTVIEW.Items.Clear();
                UpdateTaskCounts();
            }
            else
            {
                MessageBox.Show("Nothing to clear.");
            }
        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LISTVIEW.View = View.Details;
            LISTVIEW.Columns.Add("Tasks", LISTVIEW.Width - 10);
            LISTVIEW.FullRowSelect = true;
            LISTVIEW.CheckBoxes = true;

            UpdateTaskCounts();

        }

        private void LISTVIEW_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LISTVIEW_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateTaskCounts();
        }
        private void UpdateTaskCounts()
        {
            int pending = 0;
            int completed = 0;

            foreach (ListViewItem item in LISTVIEW.Items)
            {
                if (item.Checked)
                    completed++;
                else
                    pending++;
            }

            lblPending.Text = $"Pending: {pending}";
            lblCompleted.Text = $"Completed: {completed}";
        }

        private void lblCompleted_Click(object sender, EventArgs e)
        {

        }

        private void lblPending_Click(object sender, EventArgs e)
        {

        }
    }
}
