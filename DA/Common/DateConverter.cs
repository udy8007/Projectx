using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA.Common
{
    public class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            base.DateTimeFormat = "dd-MMM-yyyy";
        }
    }
}
