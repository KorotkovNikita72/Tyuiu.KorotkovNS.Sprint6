using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.KorotkovNS.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for (int i = 0; i < mas.Length - 1; i++)
                    {
                        resStr += mas[mas.Length - 1] + " ";
                        break;
                    }
                }
            }
            return resStr.Trim();
        }

    }
    
}
