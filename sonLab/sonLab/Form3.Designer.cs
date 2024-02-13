namespace sonLab
{
    partial class Form3
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
            this.dataSet1 = new sonLab.DataSet1();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableAdapter = new sonLab.DataSet1TableAdapters.CharacterTableAdapter();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.characterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new sonLab.DataSet1TableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.charIDDataGridViewTextBoxColumn,
            this.charNameDataGridViewTextBoxColumn,
            this.charLevelDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.characterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            this.charIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // charNameDataGridViewTextBoxColumn
            // 
            this.charNameDataGridViewTextBoxColumn.DataPropertyName = "Char_Name";
            this.charNameDataGridViewTextBoxColumn.HeaderText = "Char_Name";
            this.charNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charNameDataGridViewTextBoxColumn.Name = "charNameDataGridViewTextBoxColumn";
            this.charNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // charLevelDataGridViewTextBoxColumn
            // 
            this.charLevelDataGridViewTextBoxColumn.DataPropertyName = "Char_Level";
            this.charLevelDataGridViewTextBoxColumn.HeaderText = "Char_Level";
            this.charLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charLevelDataGridViewTextBoxColumn.Name = "charLevelDataGridViewTextBoxColumn";
            this.charLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Char ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Char Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Char Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "User ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.userBindingSource;
            this.comboBox1.DisplayMember = "User_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "User_ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterBindingSource1
            // 
            this.characterBindingSource1.DataMember = "Character";
            this.characterBindingSource1.DataSource = this.dataSet1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.dataSet1;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private DataSet1TableAdapters.CharacterTableAdapter characterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource characterBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DataSet1TableAdapters.UserTableAdapter userTableAdapter;
    }
}