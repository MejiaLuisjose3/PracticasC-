using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.EjerciciosArray
{
    class Programas
    {
        public static int RepeatedNTimes(int[] A)
        {
            var data = (from array in A
                        group array by array into g
                        select new
                        {
                            IdGrupo = g.Key,
                            NoArticulos = g.Count(),
                            SumaCantidad = g.Sum(s => s),
                        }).ToList();

            return data.FirstOrDefault(x => x.NoArticulos == (data.Max(c => c.NoArticulos))).IdGrupo;
        }

        public static int[] SortArrayByParity(int[] A)
        {
            var data = new List<int>();

            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] % 2 == 0)
                {
                    data.Insert(0, A[i]);
                }
                else
                {
                    data.Add(A[i]);
                }

            }
            // Otra forma de hacerlo : public int[] SortArrayByParity(int[] A) => A.OrderBy(x => x % 2).ToArray();
            return data.ToArray();
        }
    }
}
