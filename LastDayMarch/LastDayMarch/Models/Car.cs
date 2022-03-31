using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    class Car:Vehicle, IEngine, IWheel, ITransmission 
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }
        public int HorsePower { set; get; }
        public double TankSize { set; get; }

        public double CurrentFuel { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }

        public  double LeftFuelAmount()
        {
            return  TankSize-CurrentFuel;
        }
        public override double AverageSpeed()
        {
            return DriveTime * DrivePath;
        }
        public override void ShowInfo()
        {

        }
        
    }
}
