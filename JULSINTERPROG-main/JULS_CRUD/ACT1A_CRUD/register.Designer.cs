namespace ACT1A_CRUD
{
    partial class register
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
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            btnRegisterAccount = new Button();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(125, 61);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 14;
            label1.Text = "Sign Up";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(79, 215);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(226, 25);
            txtUsername.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(76, 195);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 18;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(76, 266);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(76, 148);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PasswordChar = '*';
            txtName.PlaceholderText = "Enter your Name";
            txtName.Size = new Size(226, 25);
            txtName.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(79, 286);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(226, 25);
            txtPassword.TabIndex = 22;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.HotTrack;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(76, 393);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(226, 44);
            btnSignIn.TabIndex = 23;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.Green;
            btnRegisterAccount.FlatAppearance.BorderSize = 0;
            btnRegisterAccount.FlatStyle = FlatStyle.Flat;
            btnRegisterAccount.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAccount.ForeColor = Color.White;
            btnRegisterAccount.Location = new Point(76, 343);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(226, 44);
            btnRegisterAccount.TabIndex = 24;
            btnRegisterAccount.Text = "Register";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(76, 128);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 25;
            label4.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(77, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 2);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Location = new Point(80, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 2);
            panel2.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Location = new Point(80, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 2);
            panel3.TabIndex = 19;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 508);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btnRegisterAccount);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Button btnRegisterAccount;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}