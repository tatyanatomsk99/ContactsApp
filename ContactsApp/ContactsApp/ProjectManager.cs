using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    //TODO: именование
    public static class Projectmanager
    {
        private const string _FilePath = @"C:\Users\днс\Documents\ContactsApp.notes";

        ///<summary>
        ///сохраняет список контактов в файл 
        ///</summary>
        public static void Serialization(Project S1) //сериализация
        {

            JsonSerializer serializer = new JsonSerializer()

            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };

            using (StreamWriter sw = new StreamWriter(_FilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))

                serializer.Serialize(writer, S1);
        }
        ///<summary>
        ///выгружает список контактов из файла 
        ///</summary>
        public static Project Deserialization() //десериализация
        {
            Project S1 = null;
            JsonSerializer serializer = new JsonSerializer()
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include
            };
            try
            {
                using (StreamReader sr = new StreamReader(_FilePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var deserializedObject = serializer.Deserialize(reader);
                    S1 = (Project)deserializedObject;
                }
            }
            catch (Exception e)
            {
                S1 = new Project();
            }
            if (S1 == null)
                S1 = new Project();
            return S1;
        }
    }
}