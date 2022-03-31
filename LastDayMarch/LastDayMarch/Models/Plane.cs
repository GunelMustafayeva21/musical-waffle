using System;
using System.Collections.Generic;
using System.Text;

namespace LastDayMarch.Models
{
    class Plane:Vehicle, IEngine, ITransmission
    {
        public int WingLength { get; set; }
        public int HorsePower { set; get; }
        public double TankSize { set; get; }

        public double CurrentFuel { get; set; }
        public string TransmissionKind { get; set; }

        public  double LeftFuelAmount()
        {
            return TankSize- CurrentFuel ;
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
