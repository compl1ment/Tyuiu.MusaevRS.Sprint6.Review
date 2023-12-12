using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.MusaevRS.Sprint6.Review.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int R, int k, int l)
        {
            int p = 1;

            for (int j = k; j < l; j++)
            {
                if (array[R, j] % 2 != 0)
                {
                    p = array[R, j] * p;
                }
                else
                {
                    if (j > l && p == 1)
                    {
                        p = 0;
                    }
                }
            }


            return p;
        }
    }
}
