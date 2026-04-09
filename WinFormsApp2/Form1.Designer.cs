namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTask = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            LISTVIEW = new ListView();
            lblPending = new Label();
            lblCompleted = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 47);
            label1.TabIndex = 0;
            label1.Text = "My To-Do List";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(292, 67);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(344, 23);
            txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(656, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(526, 401);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Delete All";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(435, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // LISTVIEW
            // 
            LISTVIEW.Location = new Point(292, 110);
            LISTVIEW.Name = "LISTVIEW";
            LISTVIEW.Size = new Size(439, 273);
            LISTVIEW.TabIndex = 7;
            LISTVIEW.UseCompatibleStateImageBehavior = false;
            LISTVIEW.ItemChecked += LISTVIEW_ItemChecked;
            LISTVIEW.SelectedIndexChanged += LISTVIEW_SelectedIndexChanged;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.BackColor = Color.Khaki;
            lblPending.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(804, 110);
            lblPending.Name = "lblPending";
            lblPending.Padding = new Padding(25, 12, 25, 12);
            lblPending.Size = new Size(121, 41);
            lblPending.TabIndex = 8;
            lblPending.Text = "Pending: 0";
            lblPending.Click += lblPending_Click;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.BackColor = Color.MediumAquamarine;
            lblCompleted.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(804, 166);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Padding = new Padding(20, 12, 16, 12);
            lblCompleted.Size = new Size(121, 41);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "Completed: 0";
            lblCompleted.Click += lblCompleted_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(996, 501);
            Controls.Add(lblCompleted);
            Controls.Add(lblPending);
            Controls.Add(LISTVIEW);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Name = "Form1";
            Text = "To-Do List ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTask;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private ListView LISTVIEW;
        private Label lblPending;
        private Label lblCompleted;
    }
}
