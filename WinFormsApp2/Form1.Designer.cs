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
            listPinned = new ListView();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Sitka Banner", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 50);
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
            btnAdd.Location = new Point(665, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseEnter += btnAdd_MouseEnter;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Teal;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(524, 417);
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
            btnDelete.Location = new Point(426, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // LISTVIEW
            // 
            LISTVIEW.BackColor = Color.Linen;
            LISTVIEW.Location = new Point(292, 110);
            LISTVIEW.Name = "LISTVIEW";
            LISTVIEW.Size = new Size(439, 273);
            LISTVIEW.TabIndex = 7;
            LISTVIEW.UseCompatibleStateImageBehavior = false;
            LISTVIEW.ItemChecked += LISTVIEW_ItemChecked;
            LISTVIEW.SelectedIndexChanged += LISTVIEW_SelectedIndexChanged;
            LISTVIEW.DoubleClick += LISTVIEW_DoubleClick;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.BackColor = Color.Khaki;
            lblPending.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(787, 124);
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
            lblCompleted.Location = new Point(787, 180);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Padding = new Padding(20, 12, 16, 12);
            lblCompleted.Size = new Size(121, 41);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "Completed: 0";
            lblCompleted.Click += lblCompleted_Click;
            // 
            // listPinned
            // 
            listPinned.BackColor = Color.Linen;
            listPinned.Location = new Point(46, 118);
            listPinned.Name = "listPinned";
            listPinned.Size = new Size(197, 273);
            listPinned.TabIndex = 10;
            listPinned.UseCompatibleStateImageBehavior = false;
            listPinned.ItemChecked += listPinned_ItemChecked;
            listPinned.SelectedIndexChanged += listPinned_SelectedIndexChanged;
            listPinned.DoubleClick += listPinned_DoubleClick;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LemonChiffon;
            listView1.Location = new Point(61, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(190, 267);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.BackColor = Color.White;
            listView2.ForeColor = SystemColors.InactiveCaption;
            listView2.Location = new Point(778, 110);
            listView2.Name = "listView2";
            listView2.Size = new Size(139, 123);
            listView2.TabIndex = 12;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.BackColor = Color.LemonChiffon;
            listView3.Location = new Point(301, 124);
            listView3.Name = "listView3";
            listView3.Size = new Size(439, 267);
            listView3.TabIndex = 13;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(977, 501);
            Controls.Add(listPinned);
            Controls.Add(lblCompleted);
            Controls.Add(lblPending);
            Controls.Add(LISTVIEW);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtTask);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Controls.Add(listView3);
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
        private ListView listPinned;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
    }
}
