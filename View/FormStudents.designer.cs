namespace View
{
    partial class FormStudents
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
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonWordReport = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.controlTree = new StudentsLab.ControlTree();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.дополнительныеФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(543, 194);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(163, 59);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(543, 127);
            this.buttonDeleteStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(163, 59);
            this.buttonDeleteStudent.TabIndex = 1;
            this.buttonDeleteStudent.Text = "Удалить студента";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Location = new System.Drawing.Point(543, 61);
            this.buttonEditStudent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(163, 59);
            this.buttonEditStudent.TabIndex = 2;
            this.buttonEditStudent.Text = "Редактировать студента";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(714, 61);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(163, 59);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Создать Бэкап";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonWordReport
            // 
            this.buttonWordReport.Location = new System.Drawing.Point(714, 127);
            this.buttonWordReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWordReport.Name = "buttonWordReport";
            this.buttonWordReport.Size = new System.Drawing.Size(163, 59);
            this.buttonWordReport.TabIndex = 4;
            this.buttonWordReport.Text = "Отчет в Word";
            this.buttonWordReport.UseVisualStyleBackColor = true;
            this.buttonWordReport.Click += new System.EventHandler(this.buttonWordReport_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Location = new System.Drawing.Point(714, 194);
            this.buttonDiagram.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(163, 59);
            this.buttonDiagram.TabIndex = 5;
            this.buttonDiagram.Text = "Диаграмма в Word";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(14, 52);
            this.controlTree.Margin = new System.Windows.Forms.Padding(5);
            this.controlTree.Name = "controlTree";
            this.controlTree.Size = new System.Drawing.Size(489, 379);
            this.controlTree.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дополнительныеФункцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // дополнительныеФункцииToolStripMenuItem
            // 
            this.дополнительныеФункцииToolStripMenuItem.Name = "дополнительныеФункцииToolStripMenuItem";
            this.дополнительныеФункцииToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.дополнительныеФункцииToolStripMenuItem.Text = "Дополнительные функции";
            this.дополнительныеФункцииToolStripMenuItem.Click += new System.EventHandler(this.дополнительныеФункцииToolStripMenuItem_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.controlTree);
            this.Controls.Add(this.buttonDiagram);
            this.Controls.Add(this.buttonWordReport);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonEditStudent);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStudents";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonWordReport;
        private System.Windows.Forms.Button buttonDiagram;
        private StudentsLab.ControlTree controlTree;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеФункцииToolStripMenuItem;
    }
}

