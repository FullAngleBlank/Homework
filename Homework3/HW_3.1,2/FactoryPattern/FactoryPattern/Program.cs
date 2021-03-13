using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        public interface Shape
        {
            void Draw();
            double GetArea();
            void IsLegitimate();
            void Display();
        }


        public class Rectangle : Shape
        {
            private double length;
            private double width;
            public Rectangle(double length,double width)
            {
                this.length = length;

                this.width = width;

            }
            public void Draw()
            {
                Console.WriteLine("画了一个矩形。");
            }

           
            public double GetArea()
            {
                return (this.length * this.width);
            }

            public void IsLegitimate()
            {
                Console.WriteLine("该图形合法!");
            }

            public void Display()
            {
                Console.WriteLine("该长方形的长为{0},宽为{1}", this.length, this.width);
            }
        }
        public class Square : Shape
        {
            private double length;
            public Square(double length)
            {
                this.length = length;
            }
            public void Draw()
            {
                Console.WriteLine("画了一个正方形。");
            }
            public double GetArea()
            {
                return (length * length * length * length);
            }

            public void IsLegitimate()
            {
                Console.WriteLine("该图形合法!");
            }

            public void Display()
            {
                Console.WriteLine("该正方形的边长为{0:0.0}", this.length);
            }
        }

        public class Triangle : Shape
        {
            private double x;
            private double y;
            private double z;
            public Triangle(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void Draw()
            {
                Console.WriteLine("画了一个三角形。");
            }
            
            public double GetArea()
            {
                double p = (this.x + this.y + this.z) * 0.5;
                return Math.Sqrt(p * (p - this.x) * (p - this.y) * (p - this.z));
            }

            public void IsLegitimate()
            {
                if (this.x + this.y > this.z && this.x + this.z > this.y && this.y + this.z > this.x)
                {
                    Console.WriteLine("该图形合法!");
                }
                else
                {
                    Console.WriteLine("该图形不合法!");
                }
            }


            public void Display()
            {
                Console.WriteLine("该三角形的边长1为{0:0.0},边长2为{1:0.0},边长3为{2:0.0}", this.x, this.y,this.z);
            }
        }

        public class ShapeFactory
        {
            public Shape GetShape(String shapetype)
            {
                Random random = new Random();
                if(shapetype == null)
                {
                    return null;
                }
                if (shapetype.Equals("0"))
                {
                    return new Rectangle(random.Next(2,10),random.Next(2,10));
                }else if(shapetype.Equals("1")){
                    return new Square(random.Next(2,10));
                }else if (shapetype.Equals("2"))
                {
                    return new Triangle(random.Next(2,10),random.Next(2,10),random.Next(2,10));
                }
                return null;
            }
        }

        

        static void Main(string[] args)
        {

            ShapeFactory factory = new ShapeFactory();
            Shape[] shape = new Shape[10];
            Random random = new Random();
            double TotalArea = 0;
            for (int i = 0; i < 10; i++)
            {
                shape[i] = factory.GetShape(random.Next(0, 3).ToString());
                shape[i].Draw();
                shape[i].Display();
                shape[i].IsLegitimate();
                Console.WriteLine("面积为{0:0.0}", shape[i].GetArea());
                Console.WriteLine("");
                TotalArea += shape[i].GetArea();
            }
            Console.WriteLine("创建的图形的总面积为: {0:0.00}", TotalArea);

            Console.ReadKey();

        }
    }
}
