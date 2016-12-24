using System;

namespace Credentialing.Business.Helpers
{
    public static class NumberHelper
    {
        public static decimal? ParseDecimal(string data)
        {
            decimal tmp;

            if (Decimal.TryParse(data, out tmp))
            {
                return tmp;
            }

            return null;
        }
    }
}