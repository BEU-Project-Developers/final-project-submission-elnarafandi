namespace TicketBookingFinalProject
{
    partial class ActionOnBookingTicket
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textUserEmail = new TextBox();
            textTicketId = new TextBox();
            buttonBooking = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(361, 7);
            label1.Name = "label1";
            label1.Size = new Size(336, 39);
            label1.TabIndex = 0;
            label1.Text = "BOOKING TICKET";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(521, 224);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 215);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 126);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Ticket Id";
            // 
            // textUserEmail
            // 
            textUserEmail.Location = new Point(80, 239);
            textUserEmail.Name = "textUserEmail";
            textUserEmail.Size = new Size(219, 27);
            textUserEmail.TabIndex = 4;
            // 
            // textTicketId
            // 
            textTicketId.Location = new Point(80, 150);
            textTicketId.Name = "textTicketId";
            textTicketId.Size = new Size(219, 27);
            textTicketId.TabIndex = 5;
            // 
            // buttonBooking
            // 
            buttonBooking.BackColor = Color.HotPink;
            buttonBooking.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBooking.ForeColor = Color.White;
            buttonBooking.Location = new Point(80, 332);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Size = new Size(219, 37);
            buttonBooking.TabIndex = 6;
            buttonBooking.Text = "Book Ticket";
            buttonBooking.UseVisualStyleBackColor = false;
            buttonBooking.Click += buttonBooking_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(611, 344);
            button1.Name = "button1";
            button1.Size = new Size(143, 37);
            button1.TabIndex = 7;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActionOnBookingTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(957, 450);
            Controls.Add(button1);
            Controls.Add(buttonBooking);
            Controls.Add(textTicketId);
            Controls.Add(textUserEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ActionOnBookingTicket";
            Text = "ActionOnBookingTicket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textUserEmail;
        private TextBox textTicketId;
        private Button buttonBooking;
        private Button button1;
    }
}