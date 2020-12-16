using StudentsLab;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormStudent : Form
    {
        public StudentLogic logic = new StudentLogic();
        public FormStudent()
        {
            InitializeComponent();
            controlComboBoxSelected.addElement("1");
            controlComboBoxSelected.addElement("2");
            controlComboBoxSelected.addElement("3");
            controlComboBoxSelected.addElement("4");
            controlComboBoxSelected.addElement("5");
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
                        controlComboBoxSelected.SelectedItem = view.Year.ToString();
                        textBoxFIO.Text = view.FIO;
                        textBoxScholarship.Text = view.Scholarship.ToString();
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
            if (string.IsNullOrEmpty(controlComboBoxSelected.SelectedText))
            {
                MessageBox.Show("Выберите курс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                logic.CreateOrUpdate(new Student
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    Scholarship = Convert.ToInt32(textBoxScholarship.Text),
                    Year = Convert.ToInt32(controlComboBoxSelected.SelectedText)                    
                   
                });
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
