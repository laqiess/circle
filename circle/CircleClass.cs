using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class CircleClass
    {
        private double radius; 

        //конструктор без параметров
        public CircleClass() {
                 radius = 1.0;
             }

        //конструктор
        public CircleClass(double r) {
            setradius(r);
             }

        //считываем радиус
        public void setradius(double r)
        {
            //недопустимый ввод (r <= 0) проверяется в вызывающей функции.
            if (r <= 0) throw new ArgumentException ("radius set incorrectly");
            radius = r;
        }

        //находим площадь
        public double get_area()
        {
            return Math.PI * (this.radius * this.radius) ;
        }

        //находим длину окружности
        public double get_circum()
        {
            return (2 * Math.PI * this.radius);
        }

        //находим диаметр
        public double get_diameter()
        {
            return (2 * this.radius);
        }

        // перевод значений в строку
        public override String ToString()
        {
            return "diameter: " + Convert.ToString(get_diameter()) +
                "\ncircum: " + Convert.ToString(get_circum().ToString("0.00")) +
            "\narea: " + Convert.ToString(get_area().ToString("0.00"));
        }
    }
}
