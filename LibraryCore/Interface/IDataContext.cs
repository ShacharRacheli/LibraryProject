using Library.Core.Models;


namespace Library.Core.Interface
{
    public interface IDataContext
    {
        List<Subscribe> SubscribeList { get; set; }
        List<Borrow> Borrows { get; set; }
        List<Books> BookList { get; set; }
    }
}
