namespace School_Project
{
    partial class FormMarks
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelMarks = new System.Windows.Forms.Label();
            this.listViewMarks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(693, 460);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(95, 35);
            this.buttonDel.TabIndex = 42;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(592, 460);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 35);
            this.buttonEdit.TabIndex = 41;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(491, 460);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 35);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(12, 265);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(31, 22);
            this.textBoxMark.TabIndex = 43;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(12, 138);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(242, 24);
            this.comboBoxStudent.TabIndex = 44;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(12, 196);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(242, 24);
            this.comboBoxSubject.TabIndex = 45;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(11, 118);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(56, 17);
            this.labelStudent.TabIndex = 46;
            this.labelStudent.Text = "Ученик";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(11, 176);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(66, 17);
            this.labelSubject.TabIndex = 47;
            this.labelSubject.Text = "Предмет";
            // 
            // labelMark
            // 
            this.labelMark.Location = new System.Drawing.Point(0, 0);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(100, 23);
            this.labelMark.TabIndex = 0;
            // 
            // labelMarks
            // 
            this.labelMarks.AutoSize = true;
            this.labelMarks.Location = new System.Drawing.Point(9, 245);
            this.labelMarks.Name = "labelMarks";
            this.labelMarks.Size = new System.Drawing.Size(58, 17);
            this.labelMarks.TabIndex = 48;
            this.labelMarks.Text = "Оценка";
            // 
            // listViewMarks
            // 
            this.listViewMarks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMarks.FullRowSelect = true;
            this.listViewMarks.GridLines = true;
            this.listViewMarks.HideSelection = false;
            this.listViewMarks.Location = new System.Drawing.Point(260, 138);
            this.listViewMarks.MultiSelect = false;
            this.listViewMarks.Name = "listViewMarks";
            this.listViewMarks.Size = new System.Drawing.Size(528, 308);
            this.listViewMarks.TabIndex = 49;
            this.listViewMarks.UseCompatibleStateImageBehavior = false;
            this.listViewMarks.View = System.Windows.Forms.View.Details;
            this.listViewMarks.SelectedIndexChanged += new System.EventHandler(this.listViewMarks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ученик";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Предмет";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Оценка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Project.Properties.Resources._267c8a8eb99b44e7a2ecc7eac1c76e7c;
            this.pictureBox1.Location = new System.Drawing.Point(603, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FormMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewMarks);
            this.Controls.Add(this.labelMarks);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormMarks";
            this.Text = "Оценки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelMarks;
        private System.Windows.Forms.ListView listViewMarks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}