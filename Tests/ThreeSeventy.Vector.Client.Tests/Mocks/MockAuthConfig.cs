using System;
using System.Collections.Generic;

namespace ThreeSeventy.Vector.Client.Tests
{
    class MockAuthConfig : IAuthConfig
    {
        public string ApiKey
        {
            get { return "sdkunittest"; }
            set { }
        }

        public string Secret
        {
            get { return "nob4dtest5!"; }
            set { }
        }
    }
}
