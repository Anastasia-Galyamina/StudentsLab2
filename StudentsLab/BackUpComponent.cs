using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json;


namespace StudentsLab
{
	public partial class BackUpComponent : Component
	{
		public BackUpComponent()
		{
			InitializeComponent();
		}

		public BackUpComponent(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
        public void SaveData<T>(String path, T[] data)
        {
            if (File.Exists(path + "/backup.rar"))
            {
                File.Delete(path + "/backup.rar");
            }
            var type = data.GetType();
            if (!type.IsSerializable)
            {
                throw new Exception("Класс не сериализуемый");
            }
            try
            {                
                string tempPath = path + "/temp";
                var tempDir = Directory.CreateDirectory(tempPath);
                string pathJson = tempPath + "/backup.json";

                using (StreamWriter file = File.CreateText(pathJson))
                {
                    JsonSerializer serializer = new JsonSerializer();                   
                    serializer.Serialize(file, data);
                }

                string archName = path + "/backup.rar";
                ZipFile.CreateFromDirectory(tempPath, archName);
                tempDir.Delete(true);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка сериализации", ex);
            }
        }
    }
}
