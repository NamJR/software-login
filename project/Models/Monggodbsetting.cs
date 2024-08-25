using MongoDB.Driver;

namespace project.Models
{
    public class Monggodbsetting
    {
        public static object Value { get; internal set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName {get; set;}
    }
}
