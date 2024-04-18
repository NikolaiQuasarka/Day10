namespace Task1
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
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_Speculity = new TextBox();
            textBox_Age = new TextBox();
            textBox_FIO = new TextBox();
            buttonDelete = new Button();
            FIO = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Speculity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIO, Age, Speculity });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 238);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(161, 171);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 264);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Список программистов";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox_Speculity);
            groupBox2.Controls.Add(textBox_Age);
            groupBox2.Controls.Add(textBox_FIO);
            groupBox2.Controls.Add(buttonAdd);
            groupBox2.Location = new Point(601, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 216);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавление новго программиста";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 134);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "Специальность:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Возраст:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 44);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 5;
            label1.Text = "ФИО:";
            // 
            // textBox_Speculity
            // 
            textBox_Speculity.Location = new Point(139, 131);
            textBox_Speculity.Name = "textBox_Speculity";
            textBox_Speculity.Size = new Size(210, 27);
            textBox_Speculity.TabIndex = 4;
            // 
            // textBox_Age
            // 
            textBox_Age.Location = new Point(139, 87);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(210, 27);
            textBox_Age.TabIndex = 3;
            // 
            // textBox_FIO
            // 
            textBox_FIO.Location = new Point(139, 41);
            textBox_FIO.Name = "textBox_FIO";
            textBox_FIO.Size = new Size(210, 27);
            textBox_FIO.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(689, 244);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(233, 29);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Удалить выбранный элемент";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FIO
            // 
            FIO.DataPropertyName = "FIO";
            FIO.HeaderText = "ФИО";
            FIO.MinimumWidth = 6;
            FIO.Name = "FIO";
            FIO.ReadOnly = true;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Возраст";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 93;
            // 
            // Speculity
            // 
            Speculity.DataPropertyName = "Speculity";
            Speculity.HeaderText = "Специальность";
            Speculity.MinimumWidth = 6;
            Speculity.Name = "Speculity";
            Speculity.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 295);
            Controls.Add(buttonDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_Speculity;
        private TextBox textBox_Age;
        private TextBox textBox_FIO;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Speculity;
    }
}
