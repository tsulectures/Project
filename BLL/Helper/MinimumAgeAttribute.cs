using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Helper
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _min;

        public MinimumAgeAttribute(int min)
            :base()
        {
            _min = min;
        }

        public override bool IsValid(object value)
        {

            DateTime dtV = (DateTime)value;
            long lTicks = DateTime.Now.Ticks - dtV.Ticks;
            long minThicks = DateTime.MinValue.Ticks;
            if(lTicks < minThicks)
            {
                return false;
            }

            DateTime dtAge = new DateTime(lTicks);
            if(!(dtAge.Year >= _min))
            {
                return false;
            }
            return true;
        }
    }
}
