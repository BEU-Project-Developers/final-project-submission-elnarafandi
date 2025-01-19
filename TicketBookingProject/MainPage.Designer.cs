namespace TicketBookingProject
{
    partial class MainPage
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
            panel2 = new Panel();
            btnBookTicket = new Button();
            btnTicket = new Button();
            btnUser = new Button();
            btnVenue = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 30);
            label1.Name = "label1";
            label1.Size = new Size(427, 43);
            label1.TabIndex = 0;
            label1.Text = "Operations on tickets";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(btnVenue);
            panel2.Controls.Add(btnUser);
            panel2.Controls.Add(btnTicket);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 375);
            panel2.TabIndex = 1;
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackColor = Color.HotPink;
            btnBookTicket.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBookTicket.ForeColor = Color.White;
            btnBookTicket.Location = new Point(431, 259);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(181, 48);
            btnBookTicket.TabIndex = 2;
            btnBookTicket.Text = "Booking Ticket";
            btnBookTicket.UseVisualStyleBackColor = false;
            // 
            // btnTicket
            // 
            btnTicket.BackColor = Color.HotPink;
            btnTicket.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTicket.ForeColor = Color.White;
            btnTicket.Location = new Point(84, 158);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(181, 48);
            btnTicket.TabIndex = 0;
            btnTicket.Text = "Action on Ticket";
            btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.HotPink;
            btnUser.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(84, 47);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(181, 48);
            btnUser.TabIndex = 1;
            btnUser.Text = "Action on User";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnVenue
            // 
            btnVenue.BackColor = Color.HotPink;
            btnVenue.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenue.ForeColor = Color.White;
            btnVenue.Location = new Point(84, 277);
            btnVenue.Name = "btnVenue";
            btnVenue.Size = new Size(181, 48);
            btnVenue.TabIndex = 2;
            btnVenue.Text = "Action on Venue";
            btnVenue.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(695, 476);
            Controls.Add(btnBookTicket);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainPage";
            Text = "MainPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnBookTicket;
        private Button btnTicket;
        private Button btnUser;
        private Button btnVenue;
    }
}