using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_MVP_Dictionar
{
    public class Word
    {
        public string cuv
        { get; set; }
    public string definitie;
        public string category;

        public Word()
        {

        }

        public Word(string c,string d,string ca)
        {
            cuv = c;
            definitie = d;
            category = ca;
        }
        


    }
}
