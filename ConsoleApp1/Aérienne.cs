using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emsi
{
    class Aérienne:Cargaison
    {
        public Aérienne(string r, double d, double p, double v) : base(r, d, p, v) { }
        public override double cout_total()
        {
            double cout = 0;
            if (this.get_volume() < 80000)
            {
                cout = 10 * this.get_distance() * this.get_poids();
            }
            else
            {
                cout = 12 * this.get_distance() * this.get_poids();
            }
            return cout;

        }
    }
}
