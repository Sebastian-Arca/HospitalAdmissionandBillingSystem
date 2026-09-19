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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.FromArgb(15, 37, 82);
            textBox1.Location = new Point(92, 379);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(457, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.FromArgb(15, 37, 82);
            textBox2.Location = new Point(92, 443);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(457, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 37, 82);
            label2.Location = new Point(125, 211);
            label2.Name = "label2";
            label2.Size = new Size(385, 89);
            label2.TabIndex = 3;
            label2.Text = "WELCOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(112, 128, 153);
            label1.Location = new Point(201, 300);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 4;
            label1.Text = "Please log in to your account";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 37, 82);
            button1.ForeColor = Color.White;
            button1.Location = new Point(92, 505);
            button1.Name = "button1";
            button1.Size = new Size(457, 70);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(112, 128, 153);
            label3.Location = new Point(167, 593);
            label3.Name = "label3";
            label3.Size = new Size(197, 25);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account?";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(16, 96, 217);
            button2.Location = new Point(343, 588);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 7;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(659, 750);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            ForeColor = Color.LightSkyBlue;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Button button2;
    }
}