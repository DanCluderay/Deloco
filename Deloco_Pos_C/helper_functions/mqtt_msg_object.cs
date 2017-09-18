using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deloco_Pos_C.helper_functions
{
    class mqtt_msg_object
    {
        public string msg_payload { get; set; }
        public DateTime msg_recieved { get; set; }
        public string msg_topic { get; set; }
    }
}
