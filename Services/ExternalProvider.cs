using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ExternalProvider
    {
        public int ID { get; }
        public ExternalProvider(string provider)
        {
            if (provider == "Google") ID = 1;
            else if (provider == "Facebook") ID = 2;
            else if (provider == "VK") ID = 3;
            else throw new Exception("Not Supported external provider");
        }
    }
}
