namespace View
{
    partial class FormPlagin
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(151, 34);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(161, 24);
            this.comboBox.TabIndex = 2;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(339, 34);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(137, 30);
            this.buttonChoose.TabIndex = 4;
            this.buttonChoose.Text = "Выбрать";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.Plagin_Selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите плагин";
            // 
            // FormPlagin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.comboBox);
            this.Name = "FormPlagin";
            this.Text = "FormPlagin";
            this.Load += new System.EventHandler(this.FormPlagin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label1;
    }
}