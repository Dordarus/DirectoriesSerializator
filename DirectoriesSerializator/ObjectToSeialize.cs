using System;
using System.IO;

namespace DirectoriesSerializator
{
    [Serializable]
    class ObjectToSeialize
    {
        public FileInfo Path;
        public byte[] Data;
        public ObjectToSeialize(string path, byte[] data)
        {
            Path = new FileInfo(path);
            Data = data;
        }
    }
}
