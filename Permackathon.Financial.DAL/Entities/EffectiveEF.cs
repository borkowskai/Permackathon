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
        public long Eat { get; set; }
        public long Grow { get; set; }
        public long Learn { get; set; }
        public long CashFlow { get; set; }
    }
}
