using System.Collections.Generic;
namespace BabySitter.Customer
{
    public abstract class Family
    {
        public abstract Dictionary<int, decimal> PayStructure { get; set; }
    }
}
