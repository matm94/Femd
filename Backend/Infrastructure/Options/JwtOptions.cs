﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Infrastructure.Options
{
    public class JwtOptions
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public int LifeTime { get; set; }

    }
}
