using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsLab
{
    public class PluginManager
    {
        public List<IPlugin> _plugins;
        public void LoadPlugins(string path)
        {
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            this._plugins = new List<IPlugin>();

            foreach (string pluginPath in pluginFiles)
            {
                Type objType = null;
                try
                {
                    // пытаемся загрузить библиотеку
                    Assembly assembly = Assembly.LoadFrom(pluginPath);
                    if (assembly != null)
                    {
                        objType = assembly.GetType(Path.GetFileNameWithoutExtension(pluginPath) + ".PlugIn");
                    }
                }
                catch
                {
                    continue;
                }
                try
                {
                    if (objType != null)
                    {
                        _plugins.Add((IPlugin)Activator.CreateInstance(objType));
                        //this._plugins[this._plugins.Count - 1].Host = form;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
        public void AddPluginsItems(ComboBox box)
        {
            box.Items.Clear();
            foreach (IPlugin plugin in _plugins)
            {
                if (plugin == null)
                {
                    continue;
                }
                box.Items.Add(plugin.DisplayPluginName);              
              
            }
        }
        public IPlugin GetPlugin(String Name)
        {
            for (int i = 0; i < _plugins.Count; i++)
            {
                if (_plugins[i].DisplayPluginName == Name)
                    return _plugins[i];
            }
            return null;
        }
    }
}
