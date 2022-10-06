using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10._1Exercise
{
    internal class MyClass
    {
        protected string myString;
        public virtual string GetString()
        {
            return myString;
        }
        public string ContainedString 
        { 
            set
            {
                myString = value;
            }
        }
    }
}
