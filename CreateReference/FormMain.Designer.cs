namespace CreateReference
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.buttonChangeCourse = new System.Windows.Forms.Button();
            this.controlTree = new StudentsLab.ControlTree();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeCourse
            // 
            this.buttonChangeCourse.Location = new System.Drawing.Point(13, 12);
            this.buttonChangeCourse.Name = "buttonChangeCourse";
            this.buttonChangeCourse.Size = new System.Drawing.Size(183, 46);
            this.buttonChangeCourse.TabIndex = 3;
            this.buttonChangeCourse.Text = "Сформировать справку";
            this.buttonChangeCourse.UseVisualStyleBackColor = true;
            this.buttonChangeCourse.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // controlTree
            // 
            this.controlTree.Location = new System.Drawing.Point(13, 65);
            this.controlTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlTree.Name = "controlTree";
            this.controlTree.Size = new System.Drawing.Size(486, 340);
            this.controlTree.TabIndex = 2;
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CreateReference.Report.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(531, 65);
            this.reportViewer.Name = "reportViewer";         
            this.reportViewer.Size = new System.Drawing.Size(541, 340);
            this.reportViewer.TabIndex = 4;
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataSource = typeof(StudentsLab.Student);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 434);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.buttonChangeCourse);
            this.Controls.Add(this.controlTree);
            this.Name = "FormMain";
            this.Text = "Справки по студентам";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private StudentsLab.ControlTree controlTree;
        private System.Windows.Forms.Button buttonChangeCourse;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource StudentBindingSource;
    }
}

