namespace GG_My_Life_Is_Finished
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        LeftCar left;
        RightCar right;
        List<LeftCar> leftCars = new List<LeftCar>();
        List<RightCar> rightCars = new List<RightCar>();
        public Form1()
        {
            pictureBox1 = new PictureBox();
            InitializeComponent();
            left = new LeftCar(0, 0, 0, 0, 0);
            right = new RightCar(0, 0, 0, 0, 0);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(LeftCar car in leftCars)
            {
                car.Draw(e.Graphics);
            }
            foreach (RightCar car in rightCars)
            {
                car.Draw(e.Graphics);
            }
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                left = new LeftCar(e.Location.X, e.Location.Y, 25, 35, random.Next(1, 6));
                leftCars.Add(left);
            }

            if (e.Button == MouseButtons.Right)
            {
                right = new RightCar(e.Location.X, e.Location.Y, 35, 25, random.Next(1, 6));
                rightCars.Add(right);
            }
            Refresh();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(LeftCar car in leftCars)
            {
                car.Move();
            }
            foreach (RightCar car in rightCars)
            {
                car.Move();
            }

            CheckForCollision();
            Refresh();
        }
        private void CheckForCollision()
        {
            foreach(LeftCar car in leftCars)
            {
                if (car.x + car.width / 2 > pictureBox1.Width || car.x < car.width / 2)
                {
                    car.velocity *= -1;
                }
            }
            foreach(RightCar car in rightCars)
            {
                if (car.y < car.height / 2 || car.y + car.height / 2 > pictureBox1.Height)
                {
                    car.velocity *= -1;
                }
            }
            
        }
    }
}