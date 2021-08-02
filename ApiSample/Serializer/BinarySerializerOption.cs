namespace ApiSample.Serializer
{
    public sealed class BinarySerializerOption
    {
        public string extension {internal get; init;}
        public string fileName {internal get; init;}
        public string filePath {internal get; init;}

        internal string fullName {get => filePath + @"\" + fileName + extension;}
    }
}