using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "kek.txt"; // имя файла который я хочу создать
            string PathString = @"C:\Users\Acer\Desktop\PP2\week 2"; // и где я его хочу создать
            PathString = Path.Combine(PathString, fileName); // нужно скомбинировать их пути
            FileStream fs = File.Create(PathString); // и создаем файл
            fs.Close(); // нужно чтобы прекратил работу

            string PathString2 = @"C:\Users\Acer\Desktop\PP2\week 2\Task 4"; // путь куда я должен я скопировать

            string destFile = System.IO.Path.Combine(PathString2, fileName); // скомбинируем путь
            File.Copy(PathString, destFile, true); // копируем туда

            File.Delete(PathString); // и удаляем оригинал
        }

    }
}