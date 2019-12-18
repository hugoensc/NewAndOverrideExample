using System;
using System.Collections.Generic;
using System.Text;

namespace NewAndOverrideExample
{
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }   
}
