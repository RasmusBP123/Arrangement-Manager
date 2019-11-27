using Group15.EventManager.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group15.EventManager.Domain.Models
{
    public class Address : Entity
    {
        public string RoadName { get; set; }
        public int RoadNumber { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
