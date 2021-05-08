using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_MVP_Dictionar
{
    class FileReader
    {
         
        public void setDictFromFile(Dictionary d)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\test\source\repos\Tema_MVP_Dictionar\DictFile.txt");
            foreach(string line in lines)
            {
                string[] info = line.Split(',');
                Word tmp = new Word(info[0],info[1],info[2]);
                d.Dict.Add(tmp);
                if (d.Categ.Contains(info[2]) == false)
                    d.Categ.Add(info[2]);

            }

        }

        public void setDictInFile(Dictionary d)
        {
            string filename = @"C:\Users\test\source\repos\Tema_MVP_Dictionar\DictFile.txt";

            List<string> toWrite = new List<string>();
            foreach(Word w in d.Dict)
            {
                string tmp;
                tmp = w.cuv + "," + w.definitie + "," + w.category;
                toWrite.Add(tmp);
            }
            File.WriteAllLines(filename,toWrite);
        }


    }
}
