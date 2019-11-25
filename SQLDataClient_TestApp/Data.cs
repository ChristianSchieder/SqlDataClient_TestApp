using System.Runtime.Serialization;

namespace SQLDataClient_TestApp
{
    [DataContract(Namespace = "http://www.test.com", IsReference = true)]
    public class Data
    {
        [DataMember(Order = 00)]
        public int Id{ get; set; }
        [DataMember(Order = 20)]
        public string SomeField1{ get; set; }
        [DataMember(Order = 30)]
        public string SomeField2 { get; set; }
        [DataMember(Order = 40)]
        public string SomeField3 { get; set; }
        [DataMember(Order = 50)]
        public string SomeField4 { get; set; }
        [DataMember(Order = 60)]
        public string SomeField5 { get; set; }
    }
}
