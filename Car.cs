using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG_My_Life_Is_Finished
{
    abstract class Car
    {
        public float x;
        public float y;
        public float height;
        public float width;
        public float velocity;

        public Car(float x, float y, float height, float width, float velocity)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.velocity = velocity;
        }

        public virtual void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, x - width / 2, y - height / 2, width, height);
        }
        public virtual void Move()
        {

        }
        
    }
}
