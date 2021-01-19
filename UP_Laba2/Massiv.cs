using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba2
{
    class Massiv
    {
        int[] mas;
        Random random = new Random();

        public Massiv(int n)
        {
            mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-10, 1);
            }
        }

        private int NaxojdeniePredposlOtr()
        {
            int counter = 0,predposlOtr=0;
            for (int i = mas.Length-1;i > 0; i--)
            {
                if (counter<2)
                {
                    if (mas[i] < 0)
                    {
                        predposlOtr = mas[i];
                        counter++;
                    }
                }
                else
                {
                    break;
                }
            }
            return predposlOtr;
        }

        public void UvelichenieKajdogoOtricNaPredposlOtric()
        {
            int predposlOtr = NaxojdeniePredposlOtr();
            for (int i = 0; i < mas.Length ; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] += predposlOtr;
                }
            }
        }

        public override string ToString()
        {
            return string.Join(" ",mas);
        }
    }
}
