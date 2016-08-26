using System;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using Antlr4.StringTemplate;
using ConsoleApplication1;

namespace TemplateDesigner
{
    using System.Text;

    public class Program
    {
        private static string path;

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        static void Main(string[] args)
        {
            if(args.Length >= 1)
                path = args[0];
            else
                path = Application.StartupPath;

            var fileSystemWatcher = new FileSystemWatcher(path, "*.stg");
            fileSystemWatcher.IncludeSubdirectories = true;
            fileSystemWatcher.Changed += new FileSystemEventHandler(fileSystemWatcher_Changed);
            fileSystemWatcher.Created += new FileSystemEventHandler(fileSystemWatcher_Created);
            fileSystemWatcher.EnableRaisingEvents = true;

            try
            {
                ParseDirectories(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Fin de la génération");
            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q')
            {}
        }

        static void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
             try
            {
                ParseDirectories(path);
            }
             catch (Exception ex)
             {
                 Console.WriteLine(ex);
             }
        }

        static void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {  try
        {
            ParseDirectories(path);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        }

        private static void ParseDirectories(string path)
        {
            if (Directory.Exists(path))
            {
                // On génère les fichiers pour le répertoire courrant
                GenerateFiles(path);

                var directories = Directory.EnumerateDirectories(path);

                foreach (var directory in directories)
                {
                    GenerateFiles(directory);

                    // Récurence 
                    ParseDirectories(directory);
                }
            }
        }

        private static void GenerateFiles(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var file in files)
            {


                try
                {
                    var extention = Path.GetExtension(file);
                    if (extention == ".stg" || extention == ".st")
                    {
                        GenerationHtml(file, directory);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur dans le fichier: " + file);
                    Console.WriteLine(ex);
                }
            }
        }

        private static void GenerationHtml(string file, string directory)
        {
            string filePath = file;

            var errorListener = new ErrorListener();

            TemplateGroup templateGroupFile = new TemplateGroupCustom(filePath, Encoding.Default, '$', '$');
            templateGroupFile.Listener = errorListener;
            Template page = templateGroupFile.GetInstanceOf("master");
            page.Add("model", "mon model de page");

            string result = page.Render();
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            using (var outfile = new StreamWriter(directory + @"\" + fileName + @".htm"))
                outfile.Write(result);
            Console.WriteLine("Fin génération fichier: " + file);
        }
    }
}
