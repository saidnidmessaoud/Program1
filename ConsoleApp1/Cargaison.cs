using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emsi
{
    class Cargaison
    {
        private static int cpt = 0;
        private readonly int num_cargaison;
        private string reference;
        private double distance;
        private double poids;
        private double volume;

        public Cargaison() { }
        public Cargaison(string r, double d, double p, double v)
        {
            this.num_cargaison = ++cpt;
            this.reference = r;
            this.distance = d;
            this.poids = p;
            this.volume = v;
        }

        public virtual double cout_total() { return 0; }
        public void afficher()
        {
            Console.WriteLine("le numero : " + this.num_cargaison);
            Console.WriteLine("la reference : " + this.reference);
            Console.WriteLine("la distance : " + this.distance);
            Console.WriteLine("le poid : " + this.poids);
            Console.WriteLine("le volume : " + this.volume);
        }
        public double get_distance() { return distance; }
        public double get_poids() { return poids; }
        public double get_volume() { return volume; }

    }
}
