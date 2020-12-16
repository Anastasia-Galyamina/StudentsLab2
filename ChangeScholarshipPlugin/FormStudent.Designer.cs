namespace ChangeScholarshipPlugin
{ 
    partial class FormStudent
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
            this.Сохранить = new System.Windows.Forms.Button();
            this.Отмена = new System.Windows.Forms.Button();
            this.labelScholarship = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(98, 142);
            this.Сохранить.Margin = new System.Windows.Forms.Padding(4);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(156, 44);
            this.Сохранить.TabIndex = 0;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = true;
            this.Сохранить.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(308, 142);
            this.Отмена.Margin = new System.Windows.Forms.Padding(4);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(159, 44);
            this.Отмена.TabIndex = 1;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelScholarship
            // 
            this.labelScholarship.AutoSize = true;
            this.labelScholarship.Location = new System.Drawing.Point(34, 92);
            this.labelScholarship.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScholarship.Name = "labelScholarship";
            this.labelScholarship.Size = new System.Drawing.Size(80, 17);
            this.labelScholarship.TabIndex = 3;
            this.labelScholarship.Text = "Стипендия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФИО";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(134, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 17);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "label2";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(131, 87);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(364, 22);
            this.textBox.TabIndex = 7;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 218);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScholarship);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Сохранить);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.Button Отмена;
		private System.Windows.Forms.Label labelScholarship;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox;
    }
}