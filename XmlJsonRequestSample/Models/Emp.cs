using System.Runtime.Serialization;

namespace WebApplication1.Models
{
    [DataContract(Namespace = "omer.com")]
    public class Emp
    {
        [DataMember]
        public string Name { get; set; }
    }
}