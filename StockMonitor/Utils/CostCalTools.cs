using System;

namespace StockMonitor.Utils
{
    public static class CostCalTools
    {
        //佣金最大值
        public static Decimal MinCommission = 5m;
        //佣金费率
        public static Decimal CommissionRate = 0.001m;
        //印花税税率
        public static Decimal StampTaxRate = 0.001m;
        //过户费最小值
        public static Decimal MinTransferFee = 1m;
        //过户费费率
        public static Decimal TransferFeeRate = 0.0006m;

        //计算券商佣金
        public static Decimal CommissionCal(int snumber, Decimal sprice)
        {
            decimal result;
            if (sprice * snumber * CommissionRate > MinCommission)
            {
                result = sprice * snumber * CommissionRate;
            }
            else
            {
                result = MinCommission;
            }
            return Math.Round(result,2);
        }

        public static Decimal StampTaxCal(int snumber, Decimal sprice)
        {
            return Math.Round(snumber * sprice * StampTaxRate,2);
        }

        public static decimal TransferFeeCal(int snumber)
        {
            decimal result;
            if (snumber * TransferFeeRate > MinTransferFee)
            {
                result = snumber * TransferFeeRate;
            }
            else
            {
                result = MinTransferFee;
            }
            return Math.Round(result, 2);
        }
    }
}
