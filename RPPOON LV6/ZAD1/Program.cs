using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {

            Note z1 = new Note("zabiljeska1", "Ovo je zabiljeska 1");
            Note z2 = new Note("zabiljeska2", "Ovo je zabiljeska 2");
            Note z3 = new Note("zabiljeska3", "Ovo je zabiljeska 3");

            Notebook biljeznica = new Notebook();

            biljeznica.AddNote(z1);
            biljeznica.AddNote(z2);
            biljeznica.AddNote(z3);

            IAbstractIterator iterator = biljeznica.GetIterator();

            while (!iterator.IsDone)
            {
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}
