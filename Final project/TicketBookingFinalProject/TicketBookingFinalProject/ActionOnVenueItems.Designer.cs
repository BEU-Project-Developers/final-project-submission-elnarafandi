namespace TicketBookingFinalProject
{
    partial class ActionOnVenueItems
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            textVenueId = new TextBox();
            textVenueName = new TextBox();
            textLocation = new TextBox();
            textCapacity = new TextBox();
            buttonCreate = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 18);
            label1.Name = "label1";
            label1.Size = new Size(126, 39);
            label1.TabIndex = 0;
            label1.Text = "Venue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Venue Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 181);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Venue Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 252);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 327);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Capacity";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 253);
            dataGridView1.TabIndex = 5;
            // 
            // textVenueId
            // 
            textVenueId.Location = new Point(58, 136);
            textVenueId.Name = "textVenueId";
            textVenueId.Size = new Size(229, 27);
            textVenueId.TabIndex = 6;
            // 
            // textVenueName
            // 
            textVenueName.Location = new Point(58, 204);
            textVenueName.Name = "textVenueName";
            textVenueName.Size = new Size(229, 27);
            textVenueName.TabIndex = 7;
            // 
            // textLocation
            // 
            textLocation.Location = new Point(58, 275);
            textLocation.Name = "textLocation";
            textLocation.Size = new Size(229, 27);
            textLocation.TabIndex = 8;
            // 
            // textCapacity
            // 
            textCapacity.Location = new Point(58, 351);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new Size(229, 27);
            textCapacity.TabIndex = 9;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.HotPink;
            buttonCreate.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(26, 419);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(116, 42);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.HotPink;
            buttonDelete.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(279, 419);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 42);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.HotPink;
            buttonUpdate.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(157, 419);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(102, 42);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(638, 409);
            button1.Name = "button1";
            button1.Size = new Size(158, 38);
            button1.TabIndex = 13;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActionOnVenueItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1021, 485);
            Controls.Add(button1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(textCapacity);
            Controls.Add(textLocation);
            Controls.Add(textVenueName);
            Controls.Add(textVenueId);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ActionOnVenueItems";
            Text = "ActionOnVenueItems";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox textVenueId;
        private TextBox textVenueName;
        private TextBox textLocation;
        private TextBox textCapacity;
        private Button buttonCreate;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button button1;
    }
}