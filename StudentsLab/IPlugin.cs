namespace StudentsLab
{
    public interface IPlugin
    {
        string PluginName { get; } // имя плагина
        string DisplayPluginName { get; } // имя плагина, которое отображается            
        IPluginHost Host { get; set; } // ссылка на главную форму

        void Show(); // отображает форму
    }    
}
