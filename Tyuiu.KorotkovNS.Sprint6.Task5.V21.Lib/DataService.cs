using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace Tyuiu.KorotkovNS.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line  = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            //удаление из массива неудовлетворитворяющих условию элементов
            numsArray = numsArray.Where(val => (val % 3 == 0)).ToArray();

            return numsArray;
        }
    }
}
