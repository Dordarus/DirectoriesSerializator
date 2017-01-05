using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DirectoriesSerializator
{
    static class MainClass
    {
        //Looking for all branches of current file structure 
        public static string[] AllPathes(string directoryPath)
        {
            var sb = new StringBuilder();
            var dirInfo = new DirectoryInfo(directoryPath);

            //looking for files in top directory
            foreach (var fi in dirInfo.EnumerateFiles())
            {
                sb.Append(fi.FullName + "*");
            }

            foreach (var di in dirInfo.EnumerateDirectories("*", SearchOption.AllDirectories))
            {
                //Looking for empty folders, end whith * just for simplify splitting
                if (di.GetFileSystemInfos().Length == 0)
                {
                    sb.Append(di.FullName + "*");
                }
                //looking for all files in all folders
                foreach (var fi in di.EnumerateFiles("*"))
                {
                    sb.Append(fi.FullName + "*");
                }
            }
            return sb.ToString().TrimEnd('*').Split('*');
        }

        public static void BinarySerialization(List<ObjectToSeialize> sourceFile, string serializedFile)
        {
            var formatter = new BinaryFormatter();

            using (var targetStream = File.Create(serializedFile))
            {
                formatter.Serialize(targetStream, sourceFile);

                Console.WriteLine("Serealization complete");
            }
        }

        public static void BinaryDeserialization(string serializedFile, string newDerictory)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(serializedFile, FileMode.OpenOrCreate))
            {
                var infoPath = (List<ObjectToSeialize>)formatter.Deserialize(fs);

                foreach (var f in infoPath)
                {
                    CreatingFile(f.Path.FullName, f.Data, newDerictory);
                }
            }
            Console.WriteLine("Deserialization complete");
        }

        //Creating instanses firstly folders, after adding files
        public static void CreatingFile(string path, byte[] data, string newDirectory)
        {
            var dirs = new StringBuilder();
            var files = new StringBuilder();
            var newPath = newDirectory+"\\"+ path;

            var a = newPath.Split('\\').Distinct().ToArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (i < a.Length - 1)
                    dirs.Append(a[i] + @"\");

                files.Append(a[i] + @"\");
            }
            Directory.CreateDirectory(dirs.ToString().TrimEnd('\\'));

            using (var fs = File.Create(files.ToString().TrimEnd('\\')))
            {
                fs.Write(data, 0, data.Length);
            }
        }
    }
}
