using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCercle
{
    /// <summary>
    /// Classe permettant de créer des Point. Un point est caractérisé par son abscisse X et son ordonnée Y
    /// </summary>
    public class Point
    {
        // Attributs
        private double _X;
        private double _Y;

        /// <summary>
        /// Constructeur d'un point
        /// Nécessite de donner l'abscisse et l'ordonnée
        /// </summary>
        /// <param name="x">Abscisse du point</param>
        /// <param name="y">Ordonnée du point</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Abscisse du point
        /// </summary>
        public double X { get => _X; set => _X = value; }
        /// <summary>
        /// Ordonnée du point
        /// </summary>
        public double Y { get => _Y; set => _Y = value; }

        /// <summary>
        /// Procédure permettant d'afficher le point
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine($"POINT({X},{Y})");
        }

        /// <summary>
        /// Fonction retournant la distance entre le point appelant la fonction et le point donné en paramètre
        /// </summary>
        /// <param name="point">Point dont on souhaite connaître la distance par rapport au point appelant la fonction</param>
        /// <returns>Distance</returns>
        public double DistanceAvecPoint(Point point)
        {
            return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(this.Y - point.Y, 2));
        }
        /// <summary>
        /// fonction retournant la distance entre deux points donnés en paramètre
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns>Distance entre les deux points</returns>
        public static double DistanceEntre2Points(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
