using Library.Core.Interface;
using Library.Core.Models;


namespace Library.Core.Helper
{
    public class FakeData : IDataContext
    {
        public List<Subscribe> SubscribeList { get; set; }
        public List<Borrow> Borrows { get; set; }
        public List<Books> BookList { get; set; }

        public FakeData()
        {
            SubscribeList = new List<Subscribe> {
             new Subscribe{ID="214872789",Name="Racheli Shachar",Address="Yavne 3",IsActive=true,Phone="0556756555",DateOfJoining=new DateTime(2024,1,1)},
             new Subscribe{ID="215555559",Name="Adina Cohen",Address="Chevron 10",IsActive=true,Phone="0527852321",DateOfJoining=new DateTime(2023,1,1)},
             new Subscribe{ID="123456789",Name="Ester Levi",Address="Desler 15",IsActive=true,Phone="0556735555",DateOfJoining=new DateTime(2024,5,10)}

            };
            Borrows = new List<Borrow>();
            BookList = new List<Books>();
        }
    }
}
