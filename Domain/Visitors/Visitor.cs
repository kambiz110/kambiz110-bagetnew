using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Visitors
{
    public class Visitor
    {

        public long Id { get; set; }
        public  string Ip { get; set; }
        public string CurrentLink { get; set; }
        public string ReferrerLink { get; set; }
        public string Method { get; set; }
        public string Protocol { get; set; }
        public string PhysicalPath { get; set; }
        public string VisitorVersionFamily { get; set; }
        public string VisitorVersionVersion { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceFamily { get; set; }
        public string DeviceModel { get; set; }
        public bool DeviceIsSpider { get; set; }
        public DateTime Time { get; set; }
        public string VisitorId { get; set; }

    }
}
