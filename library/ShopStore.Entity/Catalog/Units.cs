using ShopStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStore.Entity
{
    public class Units : EntityBase
    {
        public decimal? Depth { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public int Quantity { get; set; }
        public Guid? DimensionMeasurementsID { get; set; }
        public decimal Weight { get; set; }
        public Guid? WeightMeasurementsID { get; set; }
     public string Code { get; set; }
        public virtual Units MainUnits { get; set; }
        public Guid? MainUnitsID { get; set; }
    }
}
