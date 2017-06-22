using Memcached.ClientLibrary;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace memcachedtool.Models
{
    public class MemcachedHelper
    {
        private MemcachedClient _mc;

        public MemcachedHelper(string[] servers)
        {
            //初始化池
            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(servers);
            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;
            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3000;
            pool.MaintenanceSleep = 30;
            pool.Failover = true;
            pool.Nagle = false;
            pool.Initialize();
            _mc = new MemcachedClient { EnableCompression = false };
        }

        /// <summary>获取Memcached的状态
        ///
        /// </summary>
        /// <returns></returns>
        public List<MmcacheStatsModel> Stats()
        {
            List<MmcacheStatsModel> ret = new List<MmcacheStatsModel>();

            var tempHt = _mc.Stats();
            var arr = new ArrayList(tempHt.Keys);
            arr.Sort();

            MmcacheStatsModel model = null;
            //顺序存储
            foreach (string svalue in arr)
            {
                IDictionaryEnumerator ide = tempHt.GetEnumerator();
                while (ide.MoveNext())
                {
                    if (ide.Key.ToString() == svalue)
                    {
                        model = new MmcacheStatsModel()
                        {
                            servsername = ide.Key.ToString()
                        };

                        ret.Add(model.MapHashTableToModel(((Hashtable)ide.Value), model, "servsername"));
                    }
                }
            }
            return ret;
        }


        /// <summary>获取设置的服务器集群
        ///
        /// </summary>
        /// <returns></returns>
        public static ServersModel GetServerList()
        {
            StreamReader sr = System.IO.File.OpenText(System.Web.HttpContext.Current.Server.MapPath("~/Config/Servers.json"));
            StringBuilder jsonArrayTextTmp = new StringBuilder();
            string input;
            while ((input = sr.ReadLine()) != null)
            {
                jsonArrayTextTmp.Append(input);
            }
            sr.Close();
            ServersModel model = JsonConvert.DeserializeObject<ServersModel>(jsonArrayTextTmp.ToString());
            return model;
        }
    }
}