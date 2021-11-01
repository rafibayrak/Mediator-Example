﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject.Model.Core
{
    public class ProjectConfig
    {
        public string CookieName { get; set; }
        public string[] CorsUrls { get; set; }
        public string SqlServerConnectionString { get; set; }
    }
}
