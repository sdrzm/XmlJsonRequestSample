﻿using System.Runtime.Serialization;

namespace XmlJsonRequestSample.Models
{
    [DataContract(Namespace = "omer.com")]
    public class Emp
    {
        [DataMember]
        public string Name { get; set; }
    }
}