using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ApiSample.Serializer.Object
{
    public class BinarySerializer<T>
    {
        public T objectSerializer { get; set; }
        private BinarySerializerOption serializerOption {get; set;}

        public BinarySerializer(T objectSerializer, 
        BinarySerializerOption serializerOption = null)
        {
            this.objectSerializer = objectSerializer;

            serializerOption ??= new BinarySerializerOption() {
                extension = ".asf",
                fileName = "ApiSampleFile",
                filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            this.serializerOption = serializerOption;
        }

        public void Serializer() 
        {
            BinaryFormatter binaryFormatter = new();
            FileStream fileStream = new(serializerOption.fullName, FileMode.Create);

            try
            {
                //NOT RECOMENDED
                binaryFormatter.Serialize(fileStream, objectSerializer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            finally 
            {
                fileStream.Close();
            }
        }
    }
}