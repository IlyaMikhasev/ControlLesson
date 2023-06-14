using System.IO;
using System.Text;

namespace ControlLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string tmp = "ABCD";
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++) {
                DateTime time = DateTime.UtcNow;
                int numberT = time.Millisecond;
                number = numberT%100;
                Thread.Sleep(33);
                stringBuilder.Append(number + " ");
                Console.WriteLine(number);
                Console.WriteLine($"hash {time.GetHashCode()}");
            }
            using (StreamWriter sw = new StreamWriter("output.txt",true)) {
                sw.WriteLine(stringBuilder);
            }
            Console.WriteLine(stringBuilder);
            var path = Environment.CurrentDirectory;
            var pathDoc = Environment.SpecialFolder.MyDocuments;
            DirectoryInfo info = new DirectoryInfo(path);
            var files = info.EnumerateFiles();
            foreach (var item in files)
            {
                FileInfo fileInfo = new FileInfo(item.ToString());
                Console.WriteLine($"{item}  {fileInfo.LastWriteTime}");
            }

            Console.ReadKey();
        }
    }
}