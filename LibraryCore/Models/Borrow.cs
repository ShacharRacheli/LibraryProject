namespace Library.Core.Models
{
    public class Borrow
    {
        static int id = 10;
        public int Code { get; } = id++;
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Subscribe Subscriber { get; set; }
        public Books Book { get; set; }
        public bool IsReturned { get; set; }
        //public static List<Borrow> Borrows = new List<Borrow>() { };
        ////fine 

    }
}
