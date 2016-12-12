using System;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace WebApplication1.Api
{
    public class Db
    {
        private static readonly IFirebaseConfig Config;

        static Db()
        {
            Config = new FirebaseConfig
            {
                AuthSecret = "NX97gxGII2pZBbrn2LK0ndSzGw3kzhH3lTAu9LRc",
                BasePath = "https://csvslideshow.firebaseio.com/"
            };
        }

        public static IFirebaseClient Client => new FirebaseClient(Config);
    }
}