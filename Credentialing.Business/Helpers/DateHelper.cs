using System;

namespace Credentialing.Business.Helpers
{
    public static class DateHelper
    {
        public static DateTime ParseDate(string date)
        {
            var parts = date.Split('/');
            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);
            year += year > 30 ? 1900 : 2000;

            var retVal = new DateTime(year, month, 1);

            return retVal;
        }
    }
}