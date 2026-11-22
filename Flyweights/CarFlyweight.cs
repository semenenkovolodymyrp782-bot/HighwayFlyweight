
using System;
using System.Drawing;

namespace HighwayFlyweight.Flyweights
{
    public class CarFlyweight
    {
        public string Type { get; private set; }
        public Color BodyColor { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public CarFlyweight(string type, Color color, int width, int height)
        {
            Type = type;
            BodyColor = color;
            Width = width;
            Height = height;
        }

        public void Draw(Graphics g, float x, float y, bool right)
        {
            int left = (int)x;
            int top = (int)y;

            using (SolidBrush body = new SolidBrush(BodyColor))
            {
                g.FillRectangle(body, left, top, Width, Height);
            }

            using (SolidBrush window = new SolidBrush(Color.LightBlue))
            {
                g.FillRectangle(window, left + Width / 2, top + 3,
                    Width / 3, Height / 2);
            }

            using (SolidBrush wheel = new SolidBrush(Color.Black))
            {
                g.FillEllipse(wheel, left + 7, top + Height - 5, 10, 10);
                g.FillEllipse(wheel, left + Width - 17, top + Height - 5, 10, 10);
            }
        }
    }
}
