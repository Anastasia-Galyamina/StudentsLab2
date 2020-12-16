using StudentsLab;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormPlagin : Form, IPluginHost
    {

        PluginManager manager = new PluginManager();       

        public FormPlagin()
        {
            InitializeComponent();
        }  

        public bool Register(IPlugin plug)
        {
            return true;
        }

        private void FormPlagin_Load(object sender, EventArgs e)
        {

           manager.LoadPlugins(Application.StartupPath);
           manager.AddPluginsItems(comboBox); 
          
        }


        private void Plagin_Selected(object sender, EventArgs e)
        {
            manager.GetPlugin(comboBox.SelectedItem.ToString()).Show();

        }
    }
}
   
