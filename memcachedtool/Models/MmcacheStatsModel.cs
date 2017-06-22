using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace memcachedtool.Models
{
    public class MmcacheStatsModel:BaseModel
    {
        public string servsername { get; set; }

        [DisplayName("服务器的进程ID")]
        public string pid { get; set; }
        [DisplayName("服务器已经运行的秒数")]
        public string uptime { get; set; }
        [DisplayName("服务器当前的unix时间戳")]
        public string time { get; set; }
        [DisplayName("memcache版本")]
        public string version { get; set; }
        [DisplayName("libevent版本")]
        public string libevent { get; set; }
        [DisplayName("当前操作系统的指针大小（32位系统一般是32bit,64就是64位操作系统）")]
        public string pointer_size { get; set; }
        [DisplayName("进程的累计用户时间")]
        public string rusage_user { get; set; }
        [DisplayName("进程的累计系统时间")]
        public string rusage_system { get; set; }
        [DisplayName("服务器当前存储的items数量")]
        public string curr_connections { get; set; }
        [DisplayName("从服务器启动以后存储的items总数量")]
        public string total_connections { get; set; }
        [DisplayName("服务器分配的连接构造数")]
        public string connection_structures { get; set; }
        [DisplayName("")]
        public string reserved_fds { get; set; }
        [DisplayName("get命令（获取）总请求次数")]
        public string cmd_get { get; set; }
        [DisplayName("set命令（保存）总请求次数")]
        public string cmd_set { get; set; }
        [DisplayName("flush命令请求次数")]
        public string cmd_flush { get; set; }
        [DisplayName("touch命令请求次数")]
        public string cmd_touch { get; set; }
        [DisplayName("总命中次数")]
        public string get_hits { get; set; }
        [DisplayName("总未命中次数")]
        public string get_misses { get; set; }
        [DisplayName("delete命令未命中次数")]
        public string delete_misses { get; set; }
        [DisplayName("delete命令命中次数")]
        public string delete_hits { get; set; }
        [DisplayName("incr命令未命中次数")]
        public string incr_misses { get; set; }
        [DisplayName("incr命令命中次数")]
        public string incr_hits { get; set; }
        [DisplayName("decr命令未命中次数")]
        public string decr_misses { get; set; }
        [DisplayName("decr命令命中次数")]
        public string decr_hits { get; set; }
        [DisplayName("cas命令未命中次数")]
        public string cas_misses { get; set; }
        [DisplayName("cas命令命中次数")]
        public string cas_hits { get; set; }
        [DisplayName("使用擦拭次数")]
        public string cas_badval { get; set; }
        [DisplayName("touch命令命中次数")]
        public string touch_hits { get; set; }
        [DisplayName("touch命令命未中次数")]
        public string touch_misses { get; set; }
        [DisplayName("认证命令处理的次数")]
        public string auth_cmds { get; set; }
        [DisplayName("认证失败数目")]
        public string auth_errors { get; set; }
        [DisplayName("总读取字节数（请求字节数）")]
        public string bytes_read { get; set; }
        [DisplayName("总发送字节数（结果字节数）")]
        public string bytes_written { get; set; }
        [DisplayName("分配给memcache的内存大小（字节）")]
        public string limit_maxbytes { get; set; }
        [DisplayName("服务器是否达到过最大连接（0/1）")]
        public string accepting_conns { get; set; }
        [DisplayName("失效的监听数")]
        public string listen_disabled_num { get; set; }
        [DisplayName("当前线程数")]
        public string threads { get; set; }
        [DisplayName("连接操作主动放弃数目")]
        public string conn_yields { get; set; }
        [DisplayName("")]
        public string hash_power_level { get; set; }
        [DisplayName("")]
        public string hash_bytes { get; set; }
        [DisplayName("")]
        public string hash_is_expanding { get; set; }
        [DisplayName("")]
        public string expired_unfetched { get; set; }
        [DisplayName("")]
        public string evicted_unfetched { get; set; }

        [DisplayName("当前存储占用的字节数")]
        public string bytes { get; set; }

        [DisplayName("当前存储的数据总数")]
        public string curr_items { get; set; }

        [DisplayName("启动以来存储的数据总数")]
        public string total_items { get; set; }

        [DisplayName("为获取空闲内存而删除的items数（分配给memcache的空间用满后需要删除旧的items来得到空间分配给新的items)")]
        public string evictions { get; set; }

        [DisplayName("已过期的数据条目来存储新数据的数目")]
        public string reclaimed { get; set; }
    }
}