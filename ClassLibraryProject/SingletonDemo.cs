using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProject
{
    public class Counter
    {
        private static Counter instance = null;
        private  int count;

            private Counter()
        {
            count = 0;
        }

        public static Counter GetInstance() 
        { 
            if(instance == null)
            {
                instance = new Counter();
            }
            
            return instance; 
        }

        public int getCounter => count; 

        public void Increment()
        {
            count++;
        }

        public void Decrement(){
            count--; 
        }

    }
}
