namespace sonLab
{
    partial class Form4
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
            this.ıtemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtemSkillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtemLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new sonLab.DataSet1();
            this.itemTableAdapter = new sonLab.DataSet1TableAdapters.ItemTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.characterTableAdapter = new sonLab.DataSet1TableAdapters.CharacterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıtemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıtemIDDataGridViewTextBoxColumn,
            this.ıtemNameDataGridViewTextBoxColumn,
            this.ıtemSkillDataGridViewTextBoxColumn,
            this.ıtemLevelDataGridViewTextBoxColumn,
            this.charIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ıtemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıtemIDDataGridViewTextBoxColumn
            // 
            this.ıtemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.ıtemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.ıtemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıtemIDDataGridViewTextBoxColumn.Name = "ıtemIDDataGridViewTextBoxColumn";
            this.ıtemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıtemNameDataGridViewTextBoxColumn
            // 
            this.ıtemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.ıtemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.ıtemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıtemNameDataGridViewTextBoxColumn.Name = "ıtemNameDataGridViewTextBoxColumn";
            this.ıtemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıtemSkillDataGridViewTextBoxColumn
            // 
            this.ıtemSkillDataGridViewTextBoxColumn.DataPropertyName = "Item_Skill";
            this.ıtemSkillDataGridViewTextBoxColumn.HeaderText = "Item_Skill";
            this.ıtemSkillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıtemSkillDataGridViewTextBoxColumn.Name = "ıtemSkillDataGridViewTextBoxColumn";
            this.ıtemSkillDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıtemLevelDataGridViewTextBoxColumn
            // 
            this.ıtemLevelDataGridViewTextBoxColumn.DataPropertyName = "Item_Level";
            this.ıtemLevelDataGridViewTextBoxColumn.HeaderText = "Item_Level";
            this.ıtemLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıtemLevelDataGridViewTextBoxColumn.Name = "ıtemLevelDataGridViewTextBoxColumn";
            this.ıtemLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // charIDDataGridViewTextBoxColumn
            // 
            this.charIDDataGridViewTextBoxColumn.DataPropertyName = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.HeaderText = "Char_ID";
            this.charIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charIDDataGridViewTextBoxColumn.Name = "charIDDataGridViewTextBoxColumn";
            this.charIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıtemBindingSource
            // 
            this.ıtemBindingSource.DataMember = "Item";
            this.ıtemBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Skill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Char ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 166);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 189);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 214);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 238);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 20);
            this.textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.characterBindingSource;
            this.comboBox1.DisplayMember = "Char_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 262);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Char_ID";
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.dataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 85);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıtemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ıtemBindingSource;
        private DataSet1TableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemSkillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private DataSet1TableAdapters.CharacterTableAdapter characterTableAdapter;
    }
}