namespace sonLab
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new sonLab.DataSet1();
            this.taskTableAdapter = new sonLab.DataSet1TableAdapters.TaskTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableAdapter = new sonLab.DataSet1TableAdapters.CharacterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIDDataGridViewTextBoxColumn,
            this.taskNameDataGridViewTextBoxColumn,
            this.taskLocationDataGridViewTextBoxColumn,
            this.charIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // taskIDDataGridViewTextBoxColumn
            // 
            this.taskIDDataGridViewTextBoxColumn.DataPropertyName = "Task_ID";
            this.taskIDDataGridViewTextBoxColumn.HeaderText = "Task_ID";
            this.taskIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskIDDataGridViewTextBoxColumn.Name = "taskIDDataGridViewTextBoxColumn";
            this.taskIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskNameDataGridViewTextBoxColumn
            // 
            this.taskNameDataGridViewTextBoxColumn.DataPropertyName = "Task_Name";
            this.taskNameDataGridViewTextBoxColumn.HeaderText = "Task_Name";
            this.taskNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskNameDataGridViewTextBoxColumn.Name = "taskNameDataGridViewTextBoxColumn";
            this.taskNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskLocationDataGridViewTextBoxColumn
            // 
            this.taskLocationDataGridViewTextBoxColumn.DataPropertyName = "Task_Location";
            this.taskLocationDataGridViewTextBoxColumn.HeaderText = "Task_Location";
            this.taskLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskLocationDataGridViewTextBoxColumn.Name = "taskLocationDataGridViewTextBoxColumn";
            this.taskLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            this.charIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Task Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Char ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 216);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 242);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.characterBindingSource;
            this.comboBox1.DisplayMember = "Char_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 268);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Char_ID";
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.dataSet1;
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 91);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private DataSet1TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private DataSet1TableAdapters.CharacterTableAdapter characterTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}