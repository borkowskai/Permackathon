using Permackathon.Common.FinancialManager.TransferObjects;
using Permackathon.Financial.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Financial.DAL.Extensions
{
    public static class PredictionExtensions
    {
            public static PredictionTO ToTransferObject(this PredictionEF prediction)
            {
                if (prediction is null)
                    throw new ArgumentNullException(nameof(prediction));

                return new PredictionTO
                {
                    Id = prediction.Id,
                    CashFlow = prediction.CashFlow,
                    Eat = prediction.Eat,
                    Grow = prediction.Grow,
                    Learn = prediction.Learn,
                    Month = prediction.Month,
                    Year = prediction.Year
                };
            }
        public static PredictionEF ToEF(this PredictionTO prediction)
        {
            if (prediction is null)
                throw new ArgumentNullException(nameof(prediction));

            return new PredictionEF
            {
                Id = prediction.Id,
                CashFlow = prediction.CashFlow,
                Eat = prediction.Eat,
                Grow = prediction.Grow,
                Learn = prediction.Learn,
                Month = prediction.Month,
                Year = prediction.Year
            };
        }
    }
}
