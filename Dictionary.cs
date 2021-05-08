using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_MVP_Dictionar
{
    public class Dictionary
    {
        public List<Word> Dict=new List<Word>();
        public List<string> Categ = new List<string>();

        public void AddWord(Word nW)
        {
            Dict.Add(nW);
        }

        public bool CheckWord(string ToCheck)
        {
            foreach(Word a in Dict)
            {
                if (a.cuv == ToCheck)
                    return true;
            }
            return false;
        }

        public int ReturnIndexOfWord(string ToCheck)
        {
            int i = -1;
            int j = 0;
            foreach (Word a in Dict)
            {
                if (a.cuv == ToCheck)
                {
                    i = j;
                }
                j++;
            }
            return i;
        }

        public void EraseWord(string ToErase )
        {
            int i = -1;
            int j = 0;
            foreach (Word a in Dict)
            {
                if (a.cuv == ToErase)
                {
                    i = j;
                }
                j++;
            }
             if(i!=-1)
                 Dict.RemoveAt(i);
        }

        public string PrintDict()
        {
            string check= "";
            foreach (Word a in Dict)
            {
                check += a.cuv;
            }
            return check;
        }

     


    }
}
