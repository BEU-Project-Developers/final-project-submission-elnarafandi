namespace TicketBookingFinalProject
{
    partial class ActionOnUserItems
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
            buttonDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textId = new TextBox();
            textFullname = new TextBox();
            textEmail = new TextBox();
            textPassword = new TextBox();
            textUsername = new TextBox();
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(573, 8);
            label1.Name = "label1";
            label1.Size = new Size(97, 39);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(806, 324);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 104);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "User Id";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.HotPink;
            buttonDelete.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(200, 464);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(129, 43);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 170);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Fullname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 237);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 308);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 7;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 378);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // textId
            // 
            textId.Location = new Point(50, 127);
            textId.Name = "textId";
            textId.Size = new Size(243, 27);
            textId.TabIndex = 9;
            // 
            // textFullname
            // 
            textFullname.Location = new Point(50, 193);
            textFullname.Name = "textFullname";
            textFullname.Size = new Size(242, 27);
            textFullname.TabIndex = 10;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(50, 260);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(243, 27);
            textEmail.TabIndex = 11;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(49, 401);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(243, 27);
            textPassword.TabIndex = 12;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(50, 331);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(243, 27);
            textUsername.TabIndex = 13;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.HotPink;
            buttonUpdate.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(34, 464);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(130, 43);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(721, 464);
            button1.Name = "button1";
            button1.Size = new Size(162, 43);
            button1.TabIndex = 15;
            button1.Text = "Load Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ActionOnUserItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1202, 528);
            Controls.Add(button1);
            Controls.Add(buttonUpdate);
            Controls.Add(textUsername);
            Controls.Add(textPassword);
            Controls.Add(textEmail);
            Controls.Add(textFullname);
            Controls.Add(textId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonDelete);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ActionOnUserItems";
            Text = "ActionOnUserItems";
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
        private Button buttonDelete;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textId;
        private TextBox textFullname;
        private TextBox textEmail;
        private TextBox textPassword;
        private TextBox textUsername;
        private Button buttonUpdate;
        private Button button1;
    }
}