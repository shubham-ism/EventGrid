using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGrid1
{
    public class AlarmEvent
    {
        public string subject { get; set; }
        public string id { get; set; }
        public string eventType { get; set; }
        public string eventTime { get; set; }
        public Alarm data { get; set; }
    }
}
