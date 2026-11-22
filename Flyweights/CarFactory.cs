
using System.Collections.Generic;
using System.Drawing;

namespace HighwayFlyweight.Flyweights
{
    public class CarFactory
    {
        private Dictionary<string, CarFlyweight> cars =
            new Dictionary<string, CarFlyweight>();

        public CarFlyweight GetCar(string type)
        {
            if (!cars.ContainsKey(type))
            {
                switch (type)
                {
                    case "Вантажівка":
                        cars[type] = new CarFlyweight(
                            type, Color.Orange, 85, 27);
                        break;

                    case "Автобус":
                        cars[type] = new CarFlyweight(
                            type, Color.ForestGreen, 100, 28);
                        break;

                    default:
                        cars[type] = new CarFlyweight(
                            "Легковий автомобіль",
                            Color.DodgerBlue, 55, 22);
                        break;
                }
            }

            return cars[type];
        }
    }
}
