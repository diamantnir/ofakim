using System;
using System.Collections.Generic;

namespace Currencies.Models
{
    public partial class CurrenciesDetails
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
    }
}
