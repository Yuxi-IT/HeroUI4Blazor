using MauiApp1.HeroUI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.HeroUI.Extensions
{
    public static class HColorExtensions
    {
        public static string ToHex(this HColor color)
        {
            return color switch
            {
                HColor.Default => "#3f3f46",
                HColor.Primary => "#006FEE",
                HColor.Secondary => "#9353d3",
                HColor.Success => "#17c964",
                HColor.Warning => "#f5a524",
                HColor.Danger => "#f31260",
                _ => "#3f3f46"
            };
        }
    }
}
