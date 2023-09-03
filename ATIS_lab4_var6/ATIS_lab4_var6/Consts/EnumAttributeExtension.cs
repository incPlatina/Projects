using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIS_lab4_var6.Enums
{
        public static class EnumAttributeExtension
        {
            public static DescriptionAttribute GetAttribute<TAttribute>(this Enum e)
                           {
                return e.GetType()
                    ?.GetMember(e.ToString())
                    ?.FirstOrDefault()
                    ?.GetCustomAttributes(typeof(TAttribute), false)
                    ?.Cast<DescriptionAttribute>()
                    .FirstOrDefault();
            }

            public static string GetDescription(this Enum e)
            {
                return e.GetAttribute<DescriptionAttribute>()?.Description ?? string.Empty;
            }
       
    }
    }


