namespace DataAcess
{
    public class Class1
    {
        public static string getFullpath(this string fileName)//prizeModel.csv //this. help to make it 
                                                              //as extension so when we call it (getFullpath.String)
        {
            // Get the base directory from the configuration
            string baseDirectory = ConfigurationManager.AppSettings["filePath"];

            // Combine the base directory, directoryName, and fileName
            string fullPath = Path.Combine(baseDirectory, "Tourament Treacker by youcef", fileName);

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
    }
}