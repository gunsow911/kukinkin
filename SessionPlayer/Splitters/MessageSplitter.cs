using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionPlayer.Splitters
{
    /// <summary>
    /// TWE-AN-P2525からの返却形式
    /// 例)
    /// ::rc=80000000:lq=168:ct=017E:ed=810F1AFA:id=0:ba=2950:a1=1360:a2=0697:x=-005:y=-011:z=0096
    /// </summary>
    public class MessageSplitter
    {
        public event Action<Dictionary<string, string>> OnMessage ;

        private string message;

        public MessageSplitter()
        {
            message = string.Empty;
        }

        public void Add(string data)
        {
            message += data;
            if (message.Contains("\r\n"))
            {
                string[] splits = message.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, string> dict = new Dictionary<string, string>();
                foreach (string split in splits)
                {
                    KeyValuePair<string, string> pair = GetKeyValuePair(split);
                    if (pair.Key == null) continue;
                    if (!dict.ContainsKey(pair.Key))
                    {
                        dict.Add(pair.Key, pair.Value);
                    }
                }
                OnMessage(dict);
                message = message.Substring(message.IndexOf("\r\n") + 2);
            }
        }

        private KeyValuePair<string, string> GetKeyValuePair(string str)
        {
            string[] strs = str.Split(new char[] { '=' });
            if (strs.Count() != 2) return new KeyValuePair<string,string>();
            return new KeyValuePair<string, string>(strs[0], strs[1]);
        }
    }
}
