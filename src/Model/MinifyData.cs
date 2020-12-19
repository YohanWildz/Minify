using MongoDB.Bson;

namespace Minify.Model{
    public class MinifyData {
        public ObjectId _id { get; set; }
        public string Key { get; set; }
        public string Url { get; set; }
    }
}