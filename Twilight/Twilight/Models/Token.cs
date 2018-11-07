using SQLite;
using CoreTweet;

namespace Twilight.Models
{
    public class Token
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Tokens myToken { get; set; }
    }
}
