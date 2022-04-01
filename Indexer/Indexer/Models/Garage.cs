using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Models
{
    class Garage
    {
        private Car[] Cars;

        public Garage(int size)
        {
            Cars = new Car[size];
        }

        public Car this[int index] {
            get { return Cars[index]; }
            set { Cars[index] = value; }
        }

    }
}
