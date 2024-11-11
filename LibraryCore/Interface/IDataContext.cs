using WebApplication1.module;

namespace Library.Interface
{
    public interface IDataContext
    {
        List<Subscribe> SubscribeList { get; set; }
        List<Borrow> Borrows { get; set; }
        List<Books> BookList { get; set; }
    }
}
