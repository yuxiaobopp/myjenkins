using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace memcachedtool.Models
{
    public class MemcacheConfig
    {
        /// <summary>
        /// 服务列表
        /// </summary>
        public string[] servers { get; set; }
        public int initConnections { get; set; }
        public int minConnections { get; set; }

        public int maxConnections { get; set; }
        public int SocketConnectTimeout { get; set; }
        public int SocketTimeout { get; set; }
        public int MaintenanceSleep { get; set; }
        public bool Failover { get; set; }
        public bool Nagle { get; set; }
        public bool EnableCompression { get; set; }
    }
}