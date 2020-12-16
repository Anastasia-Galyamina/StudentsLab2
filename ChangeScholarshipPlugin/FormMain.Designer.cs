namespace ChangeScholarshipPlugin
{
    partial class FormMain
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
            this.controlTree = new StudentsLab.ControlTree();
            this.buttonChangeCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(13, 29);
            this.controlTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlTree.Name = "controlTree";
            this.controlTree.Size = new System.Drawing.Size(486, 340);
            this.controlTree.TabIndex = 2;
            // 
            // buttonChangeCourse
            // 
            this.buttonChangeCourse.Location = new System.Drawing.Point(525, 37);
            this.buttonChangeCourse.Name = "buttonChangeCourse";
            this.buttonChangeCourse.Size = new System.Drawing.Size(183, 46);
            this.buttonChangeCourse.TabIndex = 3;
            this.buttonChangeCourse.Text = "Назначить стипендию";
            this.buttonChangeCourse.UseVisualStyleBackColor = true;
            this.buttonChangeCourse.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.buttonChangeCourse);
            this.Controls.Add(this.controlTree);
            this.Name = "FormMain";
            this.Text = "Назначение стипендии";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private StudentsLab.ControlTree controlTree;
        private System.Windows.Forms.Button buttonChangeCourse;
    }
}

