using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCercle
{
    /// <summary>
    /// Class représentant un cercle. Un cercle est caractérisé par un centre de type Point et un rayon de type float
    /// </summary>
    public class Cercle
    {
        // attributs
        private Point _Centre;
        private double _Rayon;

        /// <summary>
        /// Conrtucteur d'un cercle.
        /// Pour être construit un cercle a besoin d'un point représentant son centre et d'un rayon
        /// </summary>
        /// <param name="centre"></param>
        /// <param name="rayon"></param>
        public Cercle(Point centre, double rayon)
        {
            Centre = centre;
            Rayon = rayon;
        }

        /// <summary>
        /// Centre du cercle
        /// </summary>
        public Point Centre { get => _Centre; set => _Centre = value; }
        /// <summary>
        /// Rayon du cercle
        /// </summary>
        public double Rayon { get => _Rayon; set => _Rayon = value; }

        /// <summary>
        /// Fonction retournant le périmètre du cercle
        /// </summary>
        /// <returns></returns>
        public double GetPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        /// <summary>
        /// Fonction retournant la surface du cercle
        /// </summary>
        /// <returns></returns>
        public double GetSurface()
        {
            return Math.PI * Rayon * Rayon;
        }

        /// <summary>
        /// Procédure affichant le cercle
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine($"CERCLE({Centre.X},{Centre.Y},{Rayon})");
        }

        /// <summary>
        /// Fonction indiquant si le point donnée en paramètre appartient au cercle.
        /// Un point appartient au cercle si la distance entre le centre du cercle et du point est inférieure ou égale au rayon du cercle
        /// </summary>
        /// <param name="p">Point dont on souhaite savoir si il appartient au cercle</param>
        /// <returns>true si le point appartient au cercle, false sinon</returns>
        public bool Appartient(Point p)
        {
            if (Centre.DistanceAvecPoint(p) <= Rayon)
            {
                return true;
            }
            return false;
        }

    }
}
