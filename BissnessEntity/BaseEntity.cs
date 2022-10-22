using System;
using System.Collections.Generic;
using System.Text;

namespace BissnessEntity
{
   public class BaseEntity
    {
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public bool IsRemoved { get; set; }
        public DateTime? RemovedTime { get; set; }
    }
}
