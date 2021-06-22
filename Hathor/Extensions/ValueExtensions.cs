﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hathor.Extensions
{
    public static class ValueExtensions
    {
        public static decimal ToHTR(this int value)
        {
            return Convert.ToDecimal(value) / 100;
        }

        public static string ToHTRString(this int value, IFormatProvider? provider = null)
        {
            return value.ToHTR().ToString("F2", provider) + " HTR";
        }

        public static int ToHTRCents(this decimal value)
        {
            return Convert.ToInt32(value * 100);
        }
    }
}
