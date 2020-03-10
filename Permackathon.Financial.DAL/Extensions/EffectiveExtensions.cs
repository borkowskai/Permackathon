using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.DAL.Extensions
{
    public static class EffectiveExtensions
    {
        public static EffectiveTO ToTransferObject(this EffectiveEF effective)
        {
            if (effective is null)
                throw new ArgumentNullException(nameof(effective));

            return new EffectiveTO
            {
                Id = effective.Id,
                CashFlow = effective.CashFlow,
                Eat = effective.Eat,
                Grow = effective.Grow,
                Learn = effective.Learn,
                Month = effective.Month,
                Year = effective.Year
            };
        }

        public static EffectiveEF ToEF(this EffectiveTO effective)
        {
            if (effective is null)
                throw new ArgumentNullException(nameof(effective));

            return new EffectiveEF
            {
                Id = effective.Id,
                CashFlow = effective.CashFlow,
                Eat = effective.Eat,
                Grow = effective.Grow,
                Learn = effective.Learn,
                Month = effective.Month,
                Year = effective.Year
            };
        }
    }
}
