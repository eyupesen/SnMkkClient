using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnMkkClient.Helpers
{
    public class SerializationHelper
    {
        /// <summary>
        /// DeSerialize ederek okuyan methoddur.
        /// </summary>
        /// <param name="_object">Tipin belirlenmesi için nesnenin kendisi gönderilir.</param>
        /// <param name="_path">Okunacak nesnenin yolu gönderilir.</param>
        /// <returns></returns>
        public static object DeSerialization(object _object, string _path)
        {
            FileStream stream = File.OpenRead(_path);
            var formatter = new BinaryFormatter();
            Type type = _object.GetType();
            var objectData = (Convert.ChangeType(formatter.Deserialize(stream), type));
            stream.Close();
            return objectData;
        }

        /// <summary>
        /// Serialize ederek kaydeden methoddur.
        /// </summary>
        /// <param name="_object">Kaydedilecek nesne gönderilir.</param>
        /// <param name="_path">Kaydedilecek nesneni yolu gönderilir.</param>
        public static void Serialization(object _object, string _path)
        {
            FileStream stream = File.Create(_path);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, _object);
            stream.Close();
        }


        public static object XmlDeSerialization(object _object, string _path)
        {
            if (File.Exists(_path))
            {
                FileStream stream = File.OpenRead(_path);
                XmlSerializer xmlS = new XmlSerializer(_object.GetType());
                Type type = _object.GetType();
                var objectData = Convert.ChangeType(xmlS.Deserialize(stream), type);
                stream.Close();
                return objectData;
            }
            else
            {
                return null;
            }
        }


        public static void XmlSerialization(object _object, string _path)
        {
            FileStream stream = File.Create(_path);
            XmlSerializer xmlPersonalMI = new XmlSerializer(_object.GetType());
            xmlPersonalMI.Serialize(stream, _object);
            stream.Close();
        }


    }
}
