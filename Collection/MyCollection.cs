using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class MyCollection<TKey, TValue> : Dictionary<KeyValuePair<object, object>, object>
    {
        private readonly object root = new object();
        
        public List<KeyValuePair<object, object>> GetElementsById(object o)
        {
            List<KeyValuePair<object, object>> result = new List<KeyValuePair<object, object>>();
            foreach (var i in this)
            {
                if (i.Key.Key.Equals(o))
                        result.Add(i.Key);
            }
            if (result != null)
                return result;
            else
                return null;
        }
        public List<KeyValuePair<object, object>> GetElementsByName(object o)
        {
            List<KeyValuePair<object, object>> result = new List<KeyValuePair<object, object>>();
            foreach (var i in this)
            {
                if (i.Key.Value.Equals(o))
                        result.Add(i.Key);
            }
            if (result != null)
                return result;
            else
                return null;
        }
        public KeyValuePair<KeyValuePair<object, object>, object> GetElement(KeyValuePair<object, object> o)
        {
            return this.Where(x => x.Key.Key.Equals(o.Key) && x.Key.Value.Equals(o.Value)).SingleOrDefault();
        }
        public void Remove(bool b, object o)
        {
            List<KeyValuePair<object, object>> res;
            if (b == false)
            {
                res = GetElementsById(o);
                lock (root)
                    foreach (var i in res)
                    {
                        this.Remove(i);
                    }
            }
            else
            {
                res = GetElementsByName(o);

                lock (root)
                    foreach (var i in res)
                    {
                        this.Remove(i);
                    }
            }
        }
    }
}
