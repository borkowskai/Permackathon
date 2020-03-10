using Permackathon.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.DAL.Entities
{
    public class EffectiveEF
    {
        public int Id { get; set; }
        public Months Month { get; set; }
        public int Year { get; set; }
        public double Eat { get; set; }
        public double Grow { get; set; }
        public double Learn { get; set; }
        public double CashFlow { get; set; }
    }
}
