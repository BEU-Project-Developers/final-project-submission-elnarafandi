namespace TicketBookingFinalProject
{
    partial class ActionOnSignUp
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textFullname = new TextBox();
            textEmail = new TextBox();
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonSignUp = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 449);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 246);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 2;
            label3.Text = "Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 192);
            label2.Name = "label2";
            label2.Size = new Size(191, 26);
            label2.TabIndex = 1;
            label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 139);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.HotPink;
            label4.Location = new Point(481, 30);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 1;
            label4.Text = "Sign Up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(323, 119);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 2;
            label5.Text = "Fullname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(323, 180);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(323, 237);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 4;
            label7.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(323, 301);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 5;
            label8.Text = "Password";
            // 
            // textFullname
            // 
            textFullname.Location = new Point(458, 116);
            textFullname.Name = "textFullname";
            textFullname.Size = new Size(297, 27);
            textFullname.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(458, 173);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(297, 27);
            textEmail.TabIndex = 7;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(458, 230);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(297, 27);
            textUsername.TabIndex = 8;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(458, 298);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(297, 27);
            textPassword.TabIndex = 9;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.HotPink;
            buttonSignUp.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(323, 374);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(432, 43);
            buttonSignUp.TabIndex = 10;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // ActionOnSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUp);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(textEmail);
            Controls.Add(textFullname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "ActionOnSignUp";
            Text = "ActionOnSignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textFullname;
        private TextBox textEmail;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonSignUp;
    }
}