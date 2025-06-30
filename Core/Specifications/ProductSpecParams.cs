namespace Core.Specifications;

public class ProductSpecParams
{
    private const int MaxPageSize = 50;
    public int PageIndex { get; set; } = 1;

    private int _pageSize = 6;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }
//     Khi gán giá trị (set):
// Khi bạn gán giá trị cho PageSize (ví dụ: obj.PageSize = 50;)
// Trình biên dịch sẽ gọi phần set với tham số ngầm định value là giá trị được gán (50 trong ví dụ này)
// Giá trị này sẽ được kiểm tra:
// a. Nếu value lớn hơn MaxPageSize thì _pageSize sẽ được gán bằng MaxPageSize
// b. Nếu không, _pageSize sẽ được gán bằng value
    

    private List<string> _brands = [];
    public List<string> Brands
    {
        get => _brands;
        set
        {
            _brands = value.SelectMany(x => x.Split(',',
                StringSplitOptions.RemoveEmptyEntries)).ToList();
        }
    }
    //obj.Brands = new List<string> { "Apple,Samsung", "Google,Microsoft" }; => _brands = ["Apple", "Samsung", "Google", "Microsoft"]

    private List<string> _types = [];
    public List<string> Types
    {
        get => _types;
        set
        {
            _types = value.SelectMany(x => x.Split(',',
                StringSplitOptions.RemoveEmptyEntries)).ToList();
        }
    }

    public string? Sort { get; set; }

    private string? _search;
    public string Search
    {
        get => _search ?? "";
        set => _search = value.ToLower();
    }
    

}