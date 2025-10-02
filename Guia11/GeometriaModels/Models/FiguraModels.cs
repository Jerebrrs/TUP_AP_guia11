using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models
{
    public abstract class FiguraModels
    {
        public int? Id { get; set; }
        public double? Area { get; set; }

        protected FiguraModels(int id,double area)
        {
            this.Id = id;
            this.Area = area;
        }
    }
}
