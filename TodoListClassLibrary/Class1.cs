using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListClassLibrary
{
    public class GenericObjects<T> where T: Mxolisi
    {
        public GenericObjects()
        {

        }

        public void DoStuff<I>(I thing)
        {
            
        }
    }

    public class Mxolisi { }
}
