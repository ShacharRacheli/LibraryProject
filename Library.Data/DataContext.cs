

using Library.Core.Models;

namespace Library.Core.Helper
{
    public class DataContext 
    {
        public List<Subscribe> SubscribeList { get; set; }
        public List<Borrow> Borrows { get; set; }
        public List<Books> BookList { get; set; }

        public DataContext()
        {
            SubscribeList = new List<Subscribe>();
            Borrows = new List<Borrow>();
            BookList = new List<Books>();
        }
        //public List<Subscribe> SubscribeList {  get; set; }
        // public static List<Subscribe> SubscribeList = new List<Subscribe>()
        // {
        //new Subscribe{ID="214872789",Name="Racheli Shachar",Address="Yavne 3",IsActive=true,Phone="0556756555",DateOfJoining=new DateTime(2024,1,1)},
        //new Subscribe{ID="215555559",Name="Adina Cohen",Address="Chevron 10",IsActive=true,Phone="0527852321",DateOfJoining=new DateTime(2023,1,1)},
        //new Subscribe{ID="123456789",Name="Ester Levi",Address="Desler 15",IsActive=true,Phone="0556735555",DateOfJoining=new DateTime(2024,5,10)}
        // };
        //public static List<Books> BookList = new List<Books>() {
        //new Books { Name ="Dudi&Udi",Category=ECategories.children,IsBorrowed=false,Author="Lion"},
        //new Books { Name ="Nan",Category=ECategories.teenage,IsBorrowed=false,Author="Lea Frid"},
        //new Books { Name ="a time to run",Category=ECategories.adult,IsBorrowed=false,Author="Rachel Shor"},
        //new Books { Name ="let me stay",Category=ECategories.adult,IsBorrowed=false,Author="Libi "},
        //new Books { Name ="Shatul",Category=ECategories.adult,IsBorrowed=false,Author="Sapir"}};
        //public static List<Borrow> Borrows = new List<Borrow>() { 
        //new Borrow{BeginDate=new DateTime(2024,10,2),Book=BookList[0],Subscriber=SubscribeList[0]},
        //new Borrow{BeginDate=new DateTime(2024,9,2),Book=BookList[1],Subscriber=SubscribeList[0]},
        //new Borrow{BeginDate=new DateTime(2023,3,2),Book=BookList[2],Subscriber=SubscribeList[2]}
        // new Borrow{BeginDate=new DateTime(2024,10,2),Book=BookList[3],Subscriber=SubscribeList[1]},
    };

}
