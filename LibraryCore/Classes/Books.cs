namespace WebApplication1.module
{
    public enum ECategories
    {
        children, teenage, adult
    }
    public class Books
    {
        public static int code = 1;
        public int Code { get; } = code++;
        public string Name { get; set; }
        public string Author { get; set; }
        public ECategories Category { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime DateOfPurchase { get; set; }


        //public static List<Books> BookList = new List<Books>() {
        //new Books { Name ="Dudi&Udi",Category=ECategories.children,IsBorrowed=false,Author="Lion"},
        //new Books { Name ="Nan",Category=ECategories.teenage,IsBorrowed=false,Author="Lea Frid"},
        //new Books { Name ="Shatul",Category=ECategories.adult,IsBorrowed=false,Author="Sapir"}};
    }
}
