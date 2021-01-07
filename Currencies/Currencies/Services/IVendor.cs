using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currencies.Services
{
    public interface IVendor
    {
        string from { get; set; }
        string to { get; set; }

        Task<string> GetData();
    }
}
