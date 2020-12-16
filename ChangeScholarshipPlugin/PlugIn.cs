using StudentsLab;

namespace ChangeScholarshipPlugin
{
    public class PlugIn : IPlugin
    {
        private string _PluginName = "ChangeScholarshipPlugin";
        private string _DisplayPluginName = "Назначить стипендию";       
        IPluginHost _Host;

        public void Show()
        {
            //выбираем студента
            // записываем новый курс
            FormMain form = new FormMain(this);
            form.ShowDialog();
        }

        public IPluginHost Host
        {
            get { return _Host; }
            set
            {
                _Host = value;
                _Host.Register(this);
            }
        }

        public string PluginName
        {
            get
            {
                return _PluginName;
            }
        }

        public string DisplayPluginName
        {
            get
            {
                return _DisplayPluginName;
            }
        }       
    }
}
