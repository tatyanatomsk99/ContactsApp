using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    
    public static class Projectmanager
    {
        public static string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ContactApp.notes";// хранение

        ///<summary>
        ///сохраняет список контактов в файл 
        ///</summary>
        public static void Serialization(Project SaveContacts, string Path) //сериализация, сохранение данных
        {

            JsonSerializer serializer = new JsonSerializer()// Создаем экземпляр сериализации

            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };

            using (StreamWriter sw = new StreamWriter(Path))// открываем поток для записи в файл с указнием пути
            using (JsonWriter writer = new JsonTextWriter(sw))

                serializer.Serialize(writer, SaveContacts);// Вызываем сериализацию и передаем объект, который хотим сериализовать
        }
        ///<summary>
        ///выгружает список контактов из файла 
        ///</summary>
        public static Project Deserialization(Project unloading_contacts, string Path) //десериализация, выгрузка данных 
        {
             unloading_contacts = null;//Создаем переменную, в которую поместимм результат десериализации
            JsonSerializer serializer = new JsonSerializer()// создаем экземпляр сериализатора
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            try
            {
                using (StreamReader sr = new StreamReader(Path))// открываем поток для чтения файла с указанием пути 
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var deserializedObject = serializer.Deserialize(reader);// Вызывает десериализацию и явно преобразует результат в целевой тип данных
                    unloading_contacts = (Project)deserializedObject;
                }
            }
            catch (Exception e)
            {
                unloading_contacts = new Project();
            }
            if (unloading_contacts == null)
                unloading_contacts = new Project();
            return unloading_contacts;
        }
    }
}