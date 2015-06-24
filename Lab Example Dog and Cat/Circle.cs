using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_example_Dog_and_Cat
{
    public class Circle
    {
        public float radius;
        public float x;
        public float y;

        public float Area
        {
            get
            {
                return ((float)Math.PI) * radius * radius;
            }
        }

        public float Circumference
        {
            get
            {
                return ((float)Math.PI) * Diameter;
            }
        }
        
        public float Diameter
        {
            get
            {
                return radius * 2.0f;
            }
            set
            {
                radius = value / 2.0f;
            }
        }

        public override string ToString()
        {
            return "Radius: " + radius + " x: " + x + " y: " + y;
        }

        public Circle()
        {
            radius = 0.0f;
            x = 0.0f;
            y = 0.0f;
        }

        public Circle(float radius, float x, float y)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

    }
}
