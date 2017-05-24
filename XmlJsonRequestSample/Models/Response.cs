using System.Runtime.Serialization;

namespace XmlJsonRequestSample.Models
{
    [DataContract(Namespace = "omer.com")]
    public class Response
    {
        [DataMember]
        public int Result { get; set; }
    }
}