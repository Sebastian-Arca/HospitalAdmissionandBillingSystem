namespace UI
{
    partial class LoginForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            btnShow = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.FromArgb(15, 37, 82);
            txtUsername.Location = new Point(64, 227);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(15, 37, 82);
            txtPassword.Location = new Point(64, 266);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 37, 82);
            label2.Location = new Point(88, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 60);
            label2.TabIndex = 3;
            label2.Text = "WELCOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(112, 128, 153);
            label1.Location = new Point(141, 180);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 4;
            label1.Text = "Please log in to your account";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 37, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 303);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(320, 42);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(112, 128, 153);
            label3.Location = new Point(117, 356);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 246, 254);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(16, 96, 217);
            button2.Location = new Point(240, 353);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(87, 20);
            button2.TabIndex = 7;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(343, 266);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(41, 23);
            btnShow.TabIndex = 8;
            btnShow.Text = "👁️";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 246, 254);
            ClientSize = new Size(461, 450);
            Controls.Add(btnShow);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button2);
            ForeColor = Color.LightSkyBlue;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button btnShow;
    }
}