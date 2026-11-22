
using HighwayFlyweight.Flyweights;

namespace HighwayFlyweight.Models
{
    public class Car
    {
        public CarFlyweight Flyweight { get; private set; }

        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public bool MovingRight { get; set; }

        public Car(CarFlyweight flyweight, float x,
            float y, float speed, bool movingRight)
        {
            Flyweight = flyweight;
            X = x;
            Y = y;
            Speed = speed;
            MovingRight = movingRight;
        }

        public void Move()
        {
            X += MovingRight ? Speed : -Speed;
        }
    }
}
