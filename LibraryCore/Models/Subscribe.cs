using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Library.Core.Models
{
    public class Subscribe
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        //[JsonConverter(typeof(DateOnlyConverter))]
        public DateTime DateOfJoining { get; set; }
        //     public static List<Subscribe> SubscribeList = new List<Subscribe>()
        //{
        //    new Subscribe{ID="214872789",Name="Racheli Shachar",Address="Yavne 3",IsActive=true,Phone="0556756555"},
        //    new Subscribe{ID="215555559",Name="Adina Cohen",Address="Chevron 10",IsActive=true,Phone="0527852321"},
        //    new Subscribe{ID="123456789",Name="Ester Levi",Address="Desler 15",IsActive=true,Phone="0556735555"}
        // };

    }
}
