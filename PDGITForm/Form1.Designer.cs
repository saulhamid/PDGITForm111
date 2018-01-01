namespace PDGITForm
{
    partial class Form1
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
            this.stuName = new System.Windows.Forms.TextBox();
            this.stuAge = new System.Windows.Forms.TextBox();
            this.stuRoll = new System.Windows.Forms.TextBox();
            this.stuGender = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuRollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(111, 26);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(100, 20);
            this.stuName.TabIndex = 0;
            // 
            // stuAge
            // 
            this.stuAge.Location = new System.Drawing.Point(111, 78);
            this.stuAge.Name = "stuAge";
            this.stuAge.Size = new System.Drawing.Size(100, 20);
            this.stuAge.TabIndex = 2;
            // 
            // stuRoll
            // 
            this.stuRoll.Location = new System.Drawing.Point(111, 52);
            this.stuRoll.Name = "stuRoll";
            this.stuRoll.Size = new System.Drawing.Size(100, 20);
            this.stuRoll.TabIndex = 3;
            // 
            // stuGender
            // 
            this.stuGender.FormattingEnabled = true;
            this.stuGender.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.stuGender.Location = new System.Drawing.Point(111, 115);
            this.stuGender.Name = "stuGender";
            this.stuGender.Size = new System.Drawing.Size(100, 21);
            this.stuGender.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(60, 165);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(223, 165);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(141, 165);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Roll";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            // 
            // stuRollDataGridViewTextBoxColumn
            // 
            this.stuRollDataGridViewTextBoxColumn.Name = "stuRollDataGridViewTextBoxColumn";
            // 
            // stuAgeDataGridViewTextBoxColumn
            // 
            this.stuAgeDataGridViewTextBoxColumn.Name = "stuAgeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.stuGender);
            this.Controls.Add(this.stuRoll);
            this.Controls.Add(this.stuAge);
            this.Controls.Add(this.stuName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.TextBox stuAge;
        private System.Windows.Forms.TextBox stuRoll;
        private System.Windows.Forms.ComboBox stuGender;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuRollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}

