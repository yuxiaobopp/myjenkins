using System.Collections;
using System.Collections.Generic;
using System;

namespace memcachedtool.Models
{
    [Serializable]
    public class ServersModel
    {
        public IEnumerable<ServersObject> Data { get; set; }
    }

    [Serializable]
    public class ServersObject
    {
        public string ServerName { get; set; }
        public string Address { get; set; }
    }
}