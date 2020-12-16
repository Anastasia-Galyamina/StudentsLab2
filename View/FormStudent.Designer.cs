namespace View
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
            this.controlComboBoxSelected = new StudentsLab.ControlComboBoxSelected();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxScholarship = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(71, 161);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(117, 36);
            this.Сохранить.TabIndex = 0;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = true;
            this.Сохранить.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Отмена
            // 
            this.Отмена.Location = new System.Drawing.Point(235, 161);
            this.Отмена.Name = "Отмена";
            this.Отмена.Size = new System.Drawing.Size(119, 36);
            this.Отмена.TabIndex = 1;
            this.Отмена.Text = "Отмена";
            this.Отмена.UseVisualStyleBackColor = true;
            this.Отмена.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // controlComboBoxSelected
            // 
            this.controlComboBoxSelected.Location = new System.Drawing.Point(57, 12);
            this.controlComboBoxSelected.Name = "controlComboBoxSelected";
            this.controlComboBoxSelected.SelectedIndex = 0;
            this.controlComboBoxSelected.SelectedItem = null;
            this.controlComboBoxSelected.Size = new System.Drawing.Size(315, 53);
            this.controlComboBoxSelected.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стипендия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(84, 71);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(257, 20);
            this.textBoxFIO.TabIndex = 6;
            // 
            // textBoxScholarship
            // 
            this.textBoxScholarship.Location = new System.Drawing.Point(84, 109);
            this.textBoxScholarship.Name = "textBoxScholarship";
            this.textBoxScholarship.Size = new System.Drawing.Size(257, 20);
            this.textBoxScholarship.TabIndex = 7;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 209);
            this.Controls.Add(this.textBoxScholarship);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlComboBoxSelected);
            this.Controls.Add(this.Отмена);
            this.Controls.Add(this.Сохранить);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.Button Отмена;
        private StudentsLab.ControlComboBoxSelected controlComboBoxSelected;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFIO;
		private System.Windows.Forms.TextBox textBoxScholarship;
	}
}