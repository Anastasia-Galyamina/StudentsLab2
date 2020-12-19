using Microsoft.Reporting.WinForms;
using StudentsLab;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateReference
{
    public partial class FormMain : Form
    {
        IPlugin _plug;
        StudentLogic logic = new StudentLogic();

        public FormMain(IPlugin plug)
        {
            InitializeComponent();
            this._plug = plug;            
        }

        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                controlTree.CreateTree(list, "Year");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           LoadData();
           
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            reportViewer.RefreshReport();
            StudentLogic logic = new StudentLogic();
            Student st = logic.FindStudent(controlTree.GetSelectedId());
            ReportParameter repPar = new ReportParameter("Student", "ФИО: " + st.FIO + " Год: " + st.Year.ToString() + " Стипендия: " + st.Scholarship.ToString());
            
            reportViewer.LocalReport.SetParameters(repPar);   
            reportViewer.RefreshReport();      
            
        }

    }
}
