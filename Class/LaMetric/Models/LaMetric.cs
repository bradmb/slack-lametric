using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.LaMetric.Models
{
    public class LaMetric
    {
        public Frame[] frames { get; set; }
    }

    public class Frame
    {
        public int index { get; set; }

        public string text { get; set; }

        public string icon { get; set; }
    }
}