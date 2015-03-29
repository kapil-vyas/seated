using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatedSensor
{

    public class CoreInfo
    {
        public string last_app { get; set; }
        public string last_heard { get; set; }
        public bool connected { get; set; }
        public string last_handshake_at { get; set; }
        public string deviceID { get; set; }
    }

    public class RootObject
    {
        public string cmd { get; set; }
        public string name { get; set; }
        public int result { get; set; }
        public CoreInfo coreInfo { get; set; }
    }
}
