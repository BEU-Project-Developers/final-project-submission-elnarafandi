namespace TicketBookingFinalProject
{
    partial class ActionOnSignIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonSignIn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 448);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 196);
            label1.Name = "label1";
            label1.Size = new Size(276, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(497, 37);
            label2.Name = "label2";
            label2.Size = new Size(122, 35);
            label2.TabIndex = 1;
            label2.Text = "Sign In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(388, 125);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(388, 232);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(388, 158);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(343, 27);
            textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(388, 266);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(343, 27);
            textPassword.TabIndex = 5;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.HotPink;
            buttonSignIn.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(388, 363);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(343, 48);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // ActionOnSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignIn);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ActionOnSignIn";
            Text = "ActionOnSignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonSignIn;
    }
}