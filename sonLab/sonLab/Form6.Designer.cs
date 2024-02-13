namespace sonLab
{
    partial class Form6
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
            this.flagColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new sonLab.DataSet1();
            this.flagTableAdapter = new sonLab.DataSet1TableAdapters.FlagTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableAdapter = new sonLab.DataSet1TableAdapters.CharacterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flagColorDataGridViewTextBoxColumn,
            this.flagIDDataGridViewTextBoxColumn,
            this.charIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flagBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // flagColorDataGridViewTextBoxColumn
            // 
            this.flagColorDataGridViewTextBoxColumn.DataPropertyName = "Flag_Color";
            this.flagColorDataGridViewTextBoxColumn.HeaderText = "Flag_Color";
            this.flagColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagColorDataGridViewTextBoxColumn.Name = "flagColorDataGridViewTextBoxColumn";
            this.flagColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // flagIDDataGridViewTextBoxColumn
            // 
            this.flagIDDataGridViewTextBoxColumn.DataPropertyName = "Flag_ID";
            this.flagIDDataGridViewTextBoxColumn.HeaderText = "Flag_ID";
            this.flagIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagIDDataGridViewTextBoxColumn.Name = "flagIDDataGridViewTextBoxColumn";
            this.flagIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            this.charIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // flagBindingSource
            // 
            this.flagBindingSource.DataMember = "Flag";
            this.flagBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flagTableAdapter
            // 
            this.flagTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flag Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flag ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Char ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 189);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 222);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.characterBindingSource;
            this.comboBox1.DisplayMember = "Char_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 256);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
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
            this.button1.Location = new System.Drawing.Point(232, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Flag Table";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource flagBindingSource;
        private DataSet1TableAdapters.FlagTableAdapter flagTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private DataSet1TableAdapters.CharacterTableAdapter characterTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}