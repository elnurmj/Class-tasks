using System;
using System.Collections.Generic;
using System.Text;

namespace Faktorial
{
    class Faktorial
    {
        int n;
        public Faktorial(int n)
        {
            this.n = n;

        }

        public void Factorial()
        {
            int multiplication = 1;
            if (n > 0)
            {
                for (int i = 1; i <= this.n; i++)
                {
                    multiplication *= i;
                }
                Console.WriteLine(multiplication);

            }
            else if (n == 0)
            {
                Console.WriteLine(n);
            }

            
            else
            {
                Console.WriteLine("The number is wrong");
            }
        }
    }
    
}

    


