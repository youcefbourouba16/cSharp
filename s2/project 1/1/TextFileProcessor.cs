using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public static class TextFileProcessor
    {
        
        public static string getFullpath(this string fileName)
        {
           
            // path tae bin debugue win kyn file
            // "C:\dev study\C# winForm\S2\project 1\1\bin\Debug"
            string baseDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            // Combine the base directory, directoryName, and fileName
            string fullPath = Path.Combine(baseDirectory, "User Folder", fileName);

            // Create the directory if it doesn't exist
            string directory = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return fullPath;
        }

        ///// take the full file path and load that string
        public static List<string> loadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<UserAndPassword> convertToUserClass(this List<string> lines)
        {
            //lines.Add($"{p.Id},{p.Username},{p.Password},{p.nom},{p.gender},{p.email}");
            List<UserAndPassword> output = new List<UserAndPassword>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                UserAndPassword temp=new UserAndPassword();
                temp.Id = Convert.ToInt16( parts[0]);
                temp.Username = parts[1];
                temp.Password = parts[2];
                temp.nom = parts[3];
                temp.gender = Convert.ToInt16(parts[4]);
                temp.email = parts[5];
                output.Add(temp);
            }
            return output;
        }

        public static void saveUserToTextfile(this List<UserAndPassword> Models, string fileName)
        {
            /// bch n3rfo ida file yexisti wla lala
            if (File.Exists(fileName))
            {
                //fo somthin
            }
            List<string> lines = new List<string>();

            foreach (UserAndPassword p in Models)
            {

                lines.Add($"{p.Id},{p.Username},{p.Password},{p.nom},{p.gender},{p.email}");

            }
            ///Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)==C:\dev study\C# winForm\S2\project 1\1\bin\Debug\textFile.txt
            ////File.Create(fileName.getFullpath());         create file
            ///File.Delete(fileName.getFullpath());          Delete file
            File.WriteAllLines(@"C:\dev study\C# winForm\S2\project 1\1\bin\Debug\textFile", lines);   /// create file and write line than close the file
        }
        public static int getLastId(List<string> lines)
        {
            if (lines.Count==0)
            {
                return 0;
            }
            string temp = lines[lines.Count-1];
            string[] temp2 = temp.Split(',');
            return Convert.ToInt32( temp2[0]);
            
            
        }
    }
}
