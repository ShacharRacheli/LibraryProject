using System.ComponentModel.DataAnnotations;

namespace Library.Core.Models
{
    public class Borrow
    {
        static int code = 100;
        [Key]
        public int Id { get; set; }
        public int Code { get; } = code++;
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Subscribe Subscriber { get; set; }
        public Books Book { get; set; }
        public bool IsReturned { get; set; }
        //public static List<Borrow> Borrows = new List<Borrow>() { };
        ////fine 

    }
}
