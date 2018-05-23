using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QRZingSample.Services
{
    public interface IScanInterface
    {
       Task<String> ScanAsync();
    }
}
