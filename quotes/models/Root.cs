using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quotes.models
{
    class Root
    {
        public Success success { get; set; }
        public Contents contents { get; set; }
        public string baseurl { get; set; }
        public Copyright copyright { get; set; }
    }
}
