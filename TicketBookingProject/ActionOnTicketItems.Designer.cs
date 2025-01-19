namespace TicketBookingProject
{
    partial class ActionOnTicketItems
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtDate = new TextBox();
            txtEvent = new TextBox();
            txtSeat = new TextBox();
            txtPrice = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            txtVenue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 103);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Ticket Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 172);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Event name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 245);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 466);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 318);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Seat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 392);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Venue Id";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.Location = new Point(60, 126);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 27);
            txtId.TabIndex = 6;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.White;
            txtDate.Location = new Point(60, 268);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(214, 27);
            txtDate.TabIndex = 7;
            // 
            // txtEvent
            // 
            txtEvent.BackColor = Color.White;
            txtEvent.Location = new Point(60, 195);
            txtEvent.Name = "txtEvent";
            txtEvent.Size = new Size(214, 27);
            txtEvent.TabIndex = 8;
            // 
            // txtSeat
            // 
            txtSeat.BackColor = Color.White;
            txtSeat.Location = new Point(60, 341);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(214, 27);
            txtSeat.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Location = new Point(60, 489);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(214, 27);
            txtPrice.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.HotPink;
            btnCreate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(31, 583);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 42);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.HotPink;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(158, 583);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.HotPink;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(296, 583);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(566, 390);
            dataGridView1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(381, 18);
            label7.Name = "label7";
            label7.Size = new Size(150, 46);
            label7.TabIndex = 16;
            label7.Text = "Ticket";
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 78);
            panel1.TabIndex = 18;
            // 
            // txtVenue
            // 
            txtVenue.Location = new Point(60, 415);
            txtVenue.Name = "txtVenue";
            txtVenue.Size = new Size(214, 27);
            txtVenue.TabIndex = 19;
            // 
            // ActionOnTicketItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(945, 670);
            Controls.Add(txtVenue);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtPrice);
            Controls.Add(txtSeat);
            Controls.Add(txtEvent);
            Controls.Add(txtDate);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ActionOnTicketItems";
            Text = "ActionOnTicketItems";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtDate;
        private TextBox txtEvent;
        private TextBox txtSeat;
        private TextBox txtPrice;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label7;
        private Panel panel1;
        private TextBox txtVenue;
    }
}