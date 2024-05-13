namespace ACT1A_CRUD
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            cbrole = new ComboBox();
            dataGridView1 = new DataGridView();
            btnsearch = new Button();
            btnlogout = new Button();
            btnremove = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtsearch = new TextBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            txtname = new TextBox();
            txtid = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HotTrack;
            panel7.Location = new Point(367, 153);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 2);
            panel7.TabIndex = 47;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(484, 153);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 2);
            panel6.TabIndex = 46;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(110, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 44;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(110, 327);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(110, 253);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(110, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 45;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(110, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 41;
            // 
            // cbrole
            // 
            cbrole.Font = new Font("Segoe UI", 10F);
            cbrole.FormattingEnabled = true;
            cbrole.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            cbrole.Location = new Point(110, 372);
            cbrole.Name = "cbrole";
            cbrole.Size = new Size(225, 25);
            cbrole.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 402);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Green;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.ForeColor = SystemColors.ControlLightLight;
            btnsearch.Location = new Point(715, 132);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(121, 23);
            btnsearch.TabIndex = 38;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.DarkRed;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnlogout.ForeColor = SystemColors.ControlLightLight;
            btnlogout.Location = new Point(661, 38);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(190, 50);
            btnlogout.TabIndex = 37;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnremove
            // 
            btnremove.BackColor = Color.DarkRed;
            btnremove.FlatStyle = FlatStyle.Flat;
            btnremove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnremove.ForeColor = SystemColors.ControlLightLight;
            btnremove.Location = new Point(110, 524);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(225, 50);
            btnremove.TabIndex = 36;
            btnremove.Text = "Remove Account";
            btnremove.UseVisualStyleBackColor = false;
            btnremove.Click += btnremove_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.HotTrack;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnupdate.ForeColor = SystemColors.ControlLightLight;
            btnupdate.Location = new Point(110, 468);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(225, 50);
            btnupdate.TabIndex = 35;
            btnupdate.Text = "Update Account";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Green;
            btnadd.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(110, 412);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(225, 50);
            btnadd.TabIndex = 34;
            btnadd.Text = "Add Account";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(110, 354);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 32;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(110, 286);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 31;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(110, 212);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 30;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(110, 132);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(110, 61);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 28;
            label1.Text = "#";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(367, 132);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(342, 23);
            txtsearch.TabIndex = 27;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10F);
            txtpassword.Location = new Point(110, 304);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(225, 25);
            txtpassword.TabIndex = 26;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 10F);
            txtusername.Location = new Point(110, 230);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(225, 25);
            txtusername.TabIndex = 25;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10F);
            txtname.Location = new Point(110, 153);
            txtname.Name = "txtname";
            txtname.Size = new Size(225, 25);
            txtname.TabIndex = 24;
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 10F);
            txtid.Location = new Point(110, 79);
            txtid.Name = "txtid";
            txtid.Size = new Size(225, 25);
            txtid.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(417, 51);
            label7.Name = "label7";
            label7.Size = new Size(139, 37);
            label7.TabIndex = 48;
            label7.Text = "Welcome";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 613);
            Controls.Add(label7);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbrole);
            Controls.Add(dataGridView1);
            Controls.Add(btnsearch);
            Controls.Add(btnlogout);
            Controls.Add(btnremove);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsearch);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbrole;
        private DataGridView dataGridView1;
        private Button btnsearch;
        private Button btnlogout;
        private Button btnremove;
        private Button btnupdate;
        private Button btnadd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtsearch;
        private TextBox txtpassword;
        private TextBox txtusername;
        private TextBox txtname;
        private TextBox txtid;
        private Label label7;
    }
}