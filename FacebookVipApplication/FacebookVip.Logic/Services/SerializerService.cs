﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FacebookVip.Logic.Services
{
    class SerializerService
    {
        public static void SaveToFile(string filePath, Object i_Obj)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(i_Obj.GetType());
                serializer.Serialize(stream, i_Obj);
            }
        }

        public static Object LoadFromFile(string filePath, Object i_Obj)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(i_Obj.GetType());
                return serializer.Deserialize(stream);
            }
        }

    }
}
