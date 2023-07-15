using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDB2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BsonMapper.Global.RegisterType<DateTimeOffset>
                    (
                        serialize: obj =>
                        {
                            var doc = new BsonDocument();
                            doc["DateTime"] = obj.DateTime.Ticks;
                            doc["Offset"] = obj.Offset.Ticks;
                            return doc;
                        },
                        deserialize: doc => new DateTimeOffset(doc["DateTime"].AsInt64, new TimeSpan(doc["Offset"].AsInt64)));
        }
    }
}
