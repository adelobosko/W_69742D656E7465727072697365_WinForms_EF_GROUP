using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_EF.EF_Model
{
    internal class Shipment
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Organization { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Manager { get; set; }
        public int Amount { get; set; }
        public double Summ { get; set; }
    }
}
