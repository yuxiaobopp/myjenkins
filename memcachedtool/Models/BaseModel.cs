using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace memcachedtool.Models
{
    public class BaseModel
    {
        public T MapHashTableToModel<T>(Hashtable src,T to,string exceptname="")
        {
            var propertys = to.GetType().GetProperties();
            foreach (var item in propertys)
            {
                if (item.Name == exceptname)
                    continue;
                item.SetValue(to,src[item.Name]);
            }

            return to;
        }
    }
}