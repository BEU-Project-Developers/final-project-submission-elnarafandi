namespace TicketBookingFinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            buttonSignUp = new Button();
            buttonSignIn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonSignUp);
            panel1.Controls.Add(buttonSignIn);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(283, 39);
            label1.TabIndex = 2;
            label1.Text = "Ticket Booking";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.HotPink;
            buttonSignUp.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(645, 31);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(130, 47);
            buttonSignUp.TabIndex = 1;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.HotPink;
            buttonSignIn.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(485, 31);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(133, 47);
            buttonSignIn.TabIndex = 0;
            buttonSignIn.Text = "Sign in";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.HotPink;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSignUp;
        private Button buttonSignIn;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
