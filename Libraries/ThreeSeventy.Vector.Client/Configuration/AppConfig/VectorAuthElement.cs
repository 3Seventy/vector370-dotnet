using System;
using System.Collections.Generic;
using System.Configuration;

namespace ThreeSeventy.Vector.Client
{
    /// <summary>
    /// App.Config interface for IAuthConfig
    /// </summary>
    public class VectorAuthElement : ConfigurationElement, IAuthConfig
    {
        /// <summary>
        /// The apikey should be sent.
        /// </summary>
        [ConfigurationProperty("apikey", IsRequired = true)]
        public string ApiKey
        {
            get { return (string)this["apikey"]; }
            set { this["apikey"] = value; }
        }

        /// <summary>
        /// The secret that should be sent.
        /// </summary>
        [ConfigurationProperty("secret", IsRequired = true)]
        public string Secret
        {
            get { return (string) this["secret"]; }
            set { this["secret"] = value; }
        }


    }
}
