using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs_Api.Model
{
    public class ShopsRUsModel
    {
        public decimal Price { get; set; }
        public bool IsStoreEmployee { get; set; }
        public DateTime WorkDate { get; set; }
        public bool IsGroseries { get; set; }

    }
}
