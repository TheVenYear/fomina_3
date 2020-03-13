using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class GetMass
    {
        int n1, n2, m1, m2;
        public GetMass(string n1, string n2, string m1,string m2)
        {
            int.TryParse(n1, out this.n1);
            int.TryParse(n2, out this.n2);
            int.TryParse(m1, out this.m1);
            int.TryParse(m2, out this.m2);
        }
        public int[,] MassiveOne()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int[,] mass = new int[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mass[i, j] = rnd.Next(-50, 50);
                }
            }
            return mass;
        }
        public int[,] MassiveTwo()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int[,] mass = new int[n2, m2];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mass[i, j] = rnd.Next(-50, 50);
                }
            }
            return mass;
        }

    }
}
