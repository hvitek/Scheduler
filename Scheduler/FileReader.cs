using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class FileReader
    {
        MainWindow mainWindow;
      

        public FileReader(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            getData();
            //listOfDefFiles();
        }
        
        public List<String> getData()
        {
            List<String> fileContentList = new List<string>();

            mainWindow.console.ConsoleInfo("------Nahravam data------");
            foreach (String path in listOfDefFiles())
            {
                fileContentList.Add(fileContent(path));
                mainWindow.console.ConsoleInfo("Success " + path);
            }
            mainWindow.console.ConsoleInfo("------Nahrano------");

            return fileContentList;
        }

        public List<MethodModel> parseMethodsAndParams()
        {
            List<MethodModel> list = new List<MethodModel>();

            foreach(String data in getData())
            {
                





























            }

            return list;
        }

        private String fileContent(string path)
        {
            String content = null;
            try
            {
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] b = new byte[1024];

                    UTF8Encoding encoding = new UTF8Encoding(true);

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        content = encoding.GetString(b);
                    }

                }
                return content;
            }
            catch (FileNotFoundException e)
            {
                mainWindow.console.ConsoleWarning("Nepodarilo se nahrat soubor "+ path);
                return null;
            }
            
        }

        private List<String> listOfDefFiles()
        {
            List<string> list = new List<string>();
            
            string[] entries = Directory.GetFileSystemEntries(Constants.pathToDefFiles, Constants.defFileNamePattern, SearchOption.AllDirectories);

            foreach(string fullPath in entries)
            {
                list.Add(fullPath);
            }

            return list;
        }
    }
}
