﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using RestSharp;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Jira.SDK.Domain
{
    public partial class NotificationScheme
    {
        public Jira Jira { get; set; }

        public NotificationScheme() { }

        public String Self { get; set; }
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        public string Expand { get; set; }
        public List<NotificationSchemeEvent> NotificationSchemeEvents { get; set; }
    }
}
