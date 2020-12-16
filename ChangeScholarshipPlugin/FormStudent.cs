using StudentsLab;
using System;
using System.Windows.Forms;

namespace ChangeScholarshipPlugin
{
    public partial class FormStudent : Form
    {
        public StudentLogic logic = new StudentLogic();       

        public FormStudent()
        {
            InitializeComponent();                     
        }
        private int? id;          
        public int Id 
        { 
           // get { return id.GetValueOrDefault(); } 
            set { id = value;}

        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new Student { Id = id })?[0];
                    if (view != null)
                    {
                        labelName.Text = view.FIO;
                        textBox.Text = view.Scholarship.ToString();                                               
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";                
            }

            try
            {
                var student = logic.Read(new Student { Id = id })?[0];                
                student.Scholarship = Convert.ToInt32(textBox.Text); 
                logic.ChangeScholarShip(student);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);               
        }
     }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }        
    }
}
