using CoreTweet;

namespace Twilight.Models
{
    class Tweet
    {
        private readonly Tokens _token;
        public Tweet()
        {
            // APIにアクセスするためのトークン
            _token = Tokens.Create(
                Key.consumerKey,
                Key.consumerSecret,
                Key.accessToken,
                Key.accessTokenSecret
            );
        }
    }
}
