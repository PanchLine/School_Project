namespace School_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonMarks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(56, 228);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(201, 48);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Ученики";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Location = new System.Drawing.Point(56, 282);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(201, 48);
            this.buttonTeachers.TabIndex = 1;
            this.buttonTeachers.Text = "Учителя";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.Location = new System.Drawing.Point(56, 336);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(201, 48);
            this.buttonSubjects.TabIndex = 2;
            this.buttonSubjects.Text = "Предметы";
            this.buttonSubjects.UseVisualStyleBackColor = true;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonMarks
            // 
            this.buttonMarks.Location = new System.Drawing.Point(56, 390);
            this.buttonMarks.Name = "buttonMarks";
            this.buttonMarks.Size = new System.Drawing.Size(201, 48);
            this.buttonMarks.TabIndex = 3;
            this.buttonMarks.Text = "Оценки";
            this.buttonMarks.UseVisualStyleBackColor = true;
            this.buttonMarks.Click += new System.EventHandler(this.buttonMarks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Project.Properties.Resources._267c8a8eb99b44e7a2ecc7eac1c76e7c;
            this.pictureBox1.Location = new System.Drawing.Point(109, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMarks);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonStudents);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.Button buttonMarks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

