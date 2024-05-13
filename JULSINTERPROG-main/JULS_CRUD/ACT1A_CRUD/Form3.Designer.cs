namespace ACT1A_CRUD
{
    partial class Form3
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
            txtid = new TextBox();
            txtname = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtsearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnadd = new Button();
            btnupdate = new Button();
            btnremove = new Button();
            btnlogout = new Button();
            btnsearch = new Button();
            dataGridView1 = new DataGridView();
            cbrole = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(44, 75);
            txtid.Name = "txtid";
            txtid.Size = new Size(225, 23);
            txtid.TabIndex = 0;
            // 
            // txtname
            // 
            txtname.Location = new Point(44, 149);
            txtname.Name = "txtname";
            txtname.Size = new Size(225, 23);
            txtname.TabIndex = 1;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(44, 226);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(225, 23);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(44, 300);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(225, 23);
            txtpassword.TabIndex = 3;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(301, 128);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(342, 23);
            txtsearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(44, 57);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 6;
            label1.Text = "#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(44, 128);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(44, 208);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(44, 282);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(44, 350);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Role";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Green;
            btnadd.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(44, 408);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(225, 50);
            btnadd.TabIndex = 12;
            btnadd.Text = "Add Account";
            btnadd.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = SystemColors.HotTrack;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnupdate.ForeColor = SystemColors.ControlLightLight;
            btnupdate.Location = new Point(44, 464);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(225, 50);
            btnupdate.TabIndex = 13;
            btnupdate.Text = "Update Account";
            btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnremove
            // 
            btnremove.BackColor = Color.DarkRed;
            btnremove.FlatStyle = FlatStyle.Flat;
            btnremove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnremove.ForeColor = SystemColors.ControlLightLight;
            btnremove.Location = new Point(44, 520);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(225, 50);
            btnremove.TabIndex = 14;
            btnremove.Text = "Remove Account";
            btnremove.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.DarkRed;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnlogout.ForeColor = SystemColors.ControlLightLight;
            btnlogout.Location = new Point(595, 34);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(190, 50);
            btnlogout.TabIndex = 15;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.Green;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.ForeColor = SystemColors.ControlLightLight;
            btnsearch.Location = new Point(649, 128);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(121, 23);
            btnsearch.TabIndex = 16;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 402);
            dataGridView1.TabIndex = 17;
            // 
            // cbrole
            // 
            cbrole.FormattingEnabled = true;
            cbrole.Location = new Point(44, 368);
            cbrole.Name = "cbrole";
            cbrole.Size = new Size(225, 23);
            cbrole.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(44, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(44, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(44, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Location = new Point(44, 321);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 2);
            panel4.TabIndex = 19;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.HotTrack;
            panel5.Location = new Point(44, 389);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 2);
            panel5.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HotTrack;
            panel6.Location = new Point(418, 149);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 2);
            panel6.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HotTrack;
            panel7.Location = new Point(301, 149);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 2);
            panel7.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(344, 34);
            label7.Name = "label7";
            label7.Size = new Size(139, 37);
            label7.TabIndex = 23;
            label7.Text = "Welcome";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 627);
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
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtsearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnadd;
        private Button btnupdate;
        private Button btnremove;
        private Button btnlogout;
        private Button btnsearch;
        private DataGridView dataGridView1;
        private ComboBox cbrole;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label7;
    }
}