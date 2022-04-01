using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Models
{
    class Car
    {
        public string Model;
        public string Make;

        public Car(string Model, string Make)
        {
            this.Model = Model;
            this.Make = Make;
        }
        public override string ToString()
        {
            return $"{Model} --{Make}";
        }
    }
}
