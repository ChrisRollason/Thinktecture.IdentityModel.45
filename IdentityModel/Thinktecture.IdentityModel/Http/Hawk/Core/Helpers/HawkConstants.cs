﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinktecture.IdentityModel.Http.Hawk.Core.Helpers
{
    /// <summary>
    /// Global constants
    /// </summary>
    public static class HawkConstants
    {
        /// <summary>"hawk"</summary>
        public const string Scheme = "hawk";
        
        /// <summary>"1"</summary>
        public const string Version = "1";

        /// <summary>"Server-Authorization"</summary>
        public const string ServerAuthorizationHeaderName = "Server-Authorization";

        /// <summary>"bewit"</summary>
        public const string Bewit = "bewit";
    }

    /// <summary>
    /// The hashing algorithms currently supported by this implementation.
    /// </summary>
    public enum SupportedAlgorithms
    {
        SHA1,
        SHA256
    }
}
