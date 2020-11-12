using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab2
{
    class EquationOfTheLine // Ax + By + C = 0
    {
        private int[] ABC;

        public EquationOfTheLine(int[] param)
        {
            this.ABC = new int[3];
            for (int i = 0; i < 3; i++)
            {
                this.ABC[i] = param[i];
            }
        }

        public int this [int i] //indexator
        {
            get
            {
                return ABC[i];
            }
            set
            {
                Random rand = new Random();
                if (ABC[0] == 0 && ABC[1] == 0)
                {
                    ABC[0] = rand.Next(-50, 50);
                    ABC[1] = rand.Next(-50, 50);
                }
                ABC[i] = value;
            }
        }

        public string Output()
        {
            return ABC[0] + "x + " + ABC[1] + "y + " + ABC[2] + "=0";
        }
    }
}
