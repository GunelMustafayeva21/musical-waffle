using System;
using LastDayMarch.Models;

namespace LastDayMarch
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            
        }
    }

    public interface IEngine{
        public int HorsePower { set; get; }
        public double TankSize { set; get; }

        public double CurrentFuel { get; set; }

        public abstract double LeftFuelAmount();
        

    }

    public interface IWheel {
        public double WheelThickness { get; set; }
    }

    public interface ITransmission
    {
        public string TransmissionKind { get; set; }
    }


}
