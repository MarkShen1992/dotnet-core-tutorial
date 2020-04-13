using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceProvider.Entity
{
    public class ConsulEntity
    {
        public string ip { set; get; }

        public int port { set; get; }

        public string ServiceName { set; get; }

        public string ConsulIP { set; get; }

        public int ConsulPort { set; get; }
    }
}
