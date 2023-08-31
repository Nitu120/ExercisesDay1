using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager
{
    internal class Car : Asset
    {
        public Car(int assetId, string description, 
            DateTime dateAcquired, double originalCost,
            int modelYear, double odometerReading) 
            : base(assetId, description, dateAcquired, originalCost)
        {
            ModelYear = modelYear;
            OdometerReading = odometerReading;
        }

        public int ModelYear { get; set; }
        public double OdometerReading { get; set; }
        public override double GetValue()
        {
            double depreciationCost = 0;
            if ((DateTime.Today.Year - ModelYear) < 7) 
            {
                depreciationCost = OriginalCost - OdometerReading / 5000 * 0.02;
                depreciationCost = depreciationCost > 0.9 * OriginalCost
                    ? 0.9 * OriginalCost : depreciationCost;
                
            }
            else
            {
                depreciationCost = OdometerReading < 100000 ? 
                    OriginalCost - OriginalCost * 0.7
                    : OriginalCost - OriginalCost*0.9;
            }

            return base.GetValue();
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
