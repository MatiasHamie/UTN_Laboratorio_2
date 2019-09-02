using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *    v1-----------v2
 *    |             |
 *    |             |
 *    v4-----------v3
 */

namespace Geometria
{
    class Rectangulo
    {
        private float area, perimetro;
        private Punto vertice1, vertice2, vertice3, vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            //Paso a crear el vertice 2 tomando la X del v3 y la Y del v1
            int auxVertice2X = this.vertice3.GetX();
            int auxVertice2Y = this.vertice1.GetY();
            this.vertice2 = new Punto(auxVertice2X, auxVertice2Y);

            //Paso a crear el vertice 4 tomando la X del v1 y la Y del v3
            int auxVertice4X = this.vertice1.GetX();
            int auxVertice4Y = this.vertice3.GetY();
            this.vertice4 = new Punto(auxVertice4X, auxVertice4Y);
        }

        public float Area()
        {
            int ver1Y = Math.Abs(this.vertice1.GetY());
            int ver3X = Math.Abs(this.vertice3.GetX());
            int ver4X = Math.Abs(this.vertice4.GetX());
            int ver4Y = Math.Abs(this.vertice4.GetY());

            float baseRect = ver3X - ver4X;
            float alturaRect = ver1Y - ver4Y;

            setArea(baseRect, alturaRect);

            return GetArea();
        }

        public float Perimetro()
        {
            int ver1Y = Math.Abs(this.vertice1.GetY());
            int ver3X = Math.Abs(this.vertice3.GetX());
            int ver4X = Math.Abs(this.vertice4.GetX());
            int ver4Y = Math.Abs(this.vertice4.GetY());

            float baseRect = ver3X - ver4X;
            float alturaRect = ver1Y - ver4Y;

            setPerimetro(baseRect, alturaRect);

            return GetPerimetro();
        }

        private void setArea(float baseRect, float alturaRect)
        {
            this.area = baseRect * alturaRect;
        }

        private void setPerimetro(float baseRect, float alturaRect)
        {
            this.perimetro = ((baseRect + alturaRect) * 2);
        }

        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }
    }
}
