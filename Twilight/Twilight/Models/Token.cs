using SQLite;
using CoreTweet;

namespace Twilight.Models
{
    public class Token
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string accessToken { get; set; }
        public string accessSecret { get; set; }
    }
}
