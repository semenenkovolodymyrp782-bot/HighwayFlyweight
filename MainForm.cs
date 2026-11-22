
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HighwayFlyweight.Models;
using HighwayFlyweight.Flyweights;

namespace HighwayFlyweight
{
    public partial class MainForm : Form
    {
        private CarFactory factory = new CarFactory();
        private List<Car> cars = new List<Car>();
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            timer1.Interval = 20;

            btnAddCar.Click += (s, e) =>
                AddCar("Легковий автомобіль");

            btnAddTruck.Click += (s, e) =>
                AddCar("Вантажівка");

            btnAddBus.Click += (s, e) =>
                AddCar("Автобус");

            btnStart.Click += (s, e) =>
                timer1.Start();

            btnPause.Click += (s, e) =>
                timer1.Stop();

            timer1.Tick += Timer1_Tick;
            pnlRoad.Paint += PnlRoad_Paint;
        }

        private void AddCar(string type)
        {
            CarFlyweight flyweight = factory.GetCar(type);

            bool right = random.Next(2) == 0;

            float x = right ? -flyweight.Width : pnlRoad.Width;

            float y = random.Next(
                20,
                Math.Max(21, pnlRoad.Height - flyweight.Height - 20));

            Car car = new Car(
                flyweight,
                x,
                y,
                random.Next(2, 6),
                right);

            cars.Add(car);

            pnlRoad.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (Car car in cars)
            {
                car.Move();
            }

            cars.RemoveAll(car =>
                car.MovingRight
                    ? car.X > pnlRoad.Width
                    : car.X < -car.Flyweight.Width);

            pnlRoad.Invalidate();
        }

        private void PnlRoad_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (Car car in cars)
            {
                car.Flyweight.Draw(
                    e.Graphics,
                    car.X,
                    car.Y,
                    car.MovingRight);
            }
        }
    }
}
