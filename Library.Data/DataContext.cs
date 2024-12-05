using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Library.Data
{
    public class DataContext : DbContext
    
    {
        public DbSet<Subscribe> SubscribeList { get; set; }
        public DbSet<Borrow> BorrowList { get; set; }
        public DbSet<Books> BookList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library");
        }
        //public DataContext()
        //{
        //   SubscribeList = new List<Subscribe>(){ new Subscribe{ID="214872789",Name="Racheli Shachar",Address="Yavne 3",IsActive=true,Phone="0556756555",DateOfJoining=new DateTime(2024,1,1)} ,
        //   new Subscribe{ID="215555559",Name="Adina Cohen",Address="Chevron 10",IsActive=false,Phone="0527852321",DateOfJoining=new DateTime(2023,1,1)},
        //   new Subscribe{ID="123456789",Name="Ester Levi",Address="Desler 15",IsActive=false,Phone="0556735555",DateOfJoining=new DateTime(2024,5,10)}
        //};
        //   BookList = new List<Books>()
        //   {
        //   new Books { Name = "Dudi&Udi", Category = ECategories.children, IsBorrowed = false, Author = "Lion" },
        //   new Books { Name ="Nan",Category=ECategories.teenage,IsBorrowed=false,Author="Lea Frid"},
        //   new Books { Name ="a time to run",Category=ECategories.adult,IsBorrowed=false,Author="Rachel Shor"},
        //   new Books { Name ="let me stay",Category=ECategories.adult,IsBorrowed=false,Author="Libi "},
        //   new Books { Name ="Shatul",Category=ECategories.adult,IsBorrowed=false,Author="Sapir"}};
        //   BorrowList = new List<Borrow>()
        //   {
        //   new Borrow{BeginDate=new DateTime(2024,10,2),Book=BookList[0],Subscriber=SubscribeList[0]},
        //   new Borrow{BeginDate=new DateTime(2024,9,2),Book=BookList[1],Subscriber=SubscribeList[0]},
        //   new Borrow{BeginDate=new DateTime(2023,3,2),Book=BookList[2],Subscriber=SubscribeList[2]},
        //   new Borrow{BeginDate=new DateTime(2024,10,2),Book=BookList[3],Subscriber=SubscribeList[1]},
        //   };


        //}
        //public Books GetBookByCode(int code)
        //{
        //    return BookList.FirstOrDefault(x => x.Code == code);
        //}
        //public Subscribe GetSubscribeByID(string id)
        //{
        //    return SubscribeList.FirstOrDefault(x => x.SubscribeID == id);
        //}
        //public Borrow GetBorrowByCode(int code)
        //{
        //    return BorrowList.FirstOrDefault(x => x.Code == code);
        //}
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
