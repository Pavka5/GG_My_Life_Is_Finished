using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG_My_Life_Is_Finished
{
    internal class RightCar : Car
    {
        Random r = new Random();
        public RightCar(float x, float y, float height, float width, float velocity) 
            : base(x, y, height, width, velocity)
        {
        }
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
            g.FillRectangle(brush, x - width / 2, y - height / 2, width, height);
            g.FillEllipse(Brushes.Black, x - width + 9, y - height + 17, 10, 10);
            g.FillEllipse(Brushes.Black, x - width + 9, y + height / 2 - 10, 10, 10);
        }
        public override void Move()
        {
            y += velocity;
        }
    }
}
