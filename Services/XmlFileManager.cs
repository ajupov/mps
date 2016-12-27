using System.IO;
using System.Xml.Serialization;
using Mps.Models;

namespace Mps.Services
{
    /// <summary>
    /// Класс-помощник для сериализации и десериализации в файл
    /// </summary>
    public static class XmlFileManager
    {
        /// <summary>
        /// Сохранить в файл
        /// </summary>
        /// <param name="fileModel">Модель файла</param>
        /// <param name="fileName">Имя файла</param>
        public static void Save(FileModel fileModel, string fileName)
        {
            // Сериализатор
            var serializer = new XmlSerializer(typeof(FileModel));

            // Записать в файловый поток сериализованный объект
            using (var fileStream = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fileStream, fileModel);
            }
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>Модель файла</returns>
        public static FileModel Open(string fileName)
        {
            // Сериализатор
            var serializer = new XmlSerializer(typeof(FileModel));

            // Полуить из файлового потока и десериализовать объект
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                return (FileModel)serializer.Deserialize(fileStream);
            }
        }
    }
}