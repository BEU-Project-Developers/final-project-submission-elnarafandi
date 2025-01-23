namespace TicketBookingFinalProject
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
            buttonEvent = new Button();
            buttonVenue = new Button();
            buttonTicket = new Button();
            buttonUser = new Button();
            buttonBookTicket = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(172, 20);
            label1.Name = "label1";
            label1.Size = new Size(488, 39);
            label1.TabIndex = 0;
            label1.Text = "OPERATIONS ON TICKETS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(buttonEvent);
            panel2.Controls.Add(buttonVenue);
            panel2.Controls.Add(buttonTicket);
            panel2.Controls.Add(buttonUser);
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 422);
            panel2.TabIndex = 1;
            // 
            // buttonEvent
            // 
            buttonEvent.BackColor = Color.HotPink;
            buttonEvent.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEvent.ForeColor = Color.White;
            buttonEvent.Location = new Point(110, 318);
            buttonEvent.Name = "buttonEvent";
            buttonEvent.Size = new Size(181, 44);
            buttonEvent.TabIndex = 3;
            buttonEvent.Text = "Action On Event";
            buttonEvent.UseVisualStyleBackColor = false;
            buttonEvent.Click += buttonEvent_Click;
            // 
            // buttonVenue
            // 
            buttonVenue.BackColor = Color.HotPink;
            buttonVenue.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVenue.ForeColor = Color.White;
            buttonVenue.Location = new Point(110, 235);
            buttonVenue.Name = "buttonVenue";
            buttonVenue.Size = new Size(181, 44);
            buttonVenue.TabIndex = 2;
            buttonVenue.Text = "Action On Venue";
            buttonVenue.UseVisualStyleBackColor = false;
            buttonVenue.Click += buttonVenue_Click;
            // 
            // buttonTicket
            // 
            buttonTicket.BackColor = Color.HotPink;
            buttonTicket.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTicket.ForeColor = Color.White;
            buttonTicket.Location = new Point(110, 149);
            buttonTicket.Name = "buttonTicket";
            buttonTicket.Size = new Size(181, 44);
            buttonTicket.TabIndex = 1;
            buttonTicket.Text = "Action On Ticket";
            buttonTicket.UseVisualStyleBackColor = false;
            buttonTicket.Click += buttonTicket_Click;
            // 
            // buttonUser
            // 
            buttonUser.BackColor = Color.HotPink;
            buttonUser.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUser.ForeColor = Color.White;
            buttonUser.Location = new Point(110, 66);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(181, 44);
            buttonUser.TabIndex = 0;
            buttonUser.Text = "Action On User";
            buttonUser.UseVisualStyleBackColor = false;
            buttonUser.Click += buttonUser_Click;
            // 
            // buttonBookTicket
            // 
            buttonBookTicket.BackColor = Color.HotPink;
            buttonBookTicket.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBookTicket.ForeColor = Color.White;
            buttonBookTicket.Location = new Point(521, 258);
            buttonBookTicket.Name = "buttonBookTicket";
            buttonBookTicket.Size = new Size(179, 44);
            buttonBookTicket.TabIndex = 2;
            buttonBookTicket.Text = "Booking Ticket";
            buttonBookTicket.UseVisualStyleBackColor = false;
            buttonBookTicket.Click += buttonBookTicket_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 502);
            Controls.Add(buttonBookTicket);
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
        private Button buttonVenue;
        private Button buttonTicket;
        private Button buttonUser;
        private Button buttonBookTicket;
        private Button buttonEvent;
    }
}