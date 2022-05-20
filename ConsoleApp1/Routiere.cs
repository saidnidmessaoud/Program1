using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Emsi
{
    internal class Routiere:Cargaison
    {
        public Routiere(string r, double d, double p, double v):base(r, d, p, v){}
        public override double cout_total()
        {
            double cout = 0;
            if (this.get_volume() < 380000)
            {
                cout = 4 * this.get_distance() * this.get_poids();
            }
            else
            {
                cout = 6 * this.get_distance() * this.get_poids();
            }
            return cout;

        }
    }
}
