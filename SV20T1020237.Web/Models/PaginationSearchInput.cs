namespace SV20T1020237.Web.Models
{
    /// <summary>
    /// Đầu vào tìm kiếm dữ liệu để nhận dữ liệu dưới dạng phân trang
    /// </summary>
    public class PaginationSearchInput
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 0;
        public string SearchValue { get; set; } = "";
    }

    /// <summary>
    /// Đầu vào sử dụng cho tìm kiếm mặt hàng
    /// </summary>
    public class ProductSearchInput : PaginationSearchInput 
    {
        public int CategoryID { get; set; } = 0;
        public int SupplierID { get; set; } = 0;
        public decimal minPrice { get; set; }
        public decimal maxPrice { get; set; }
    }

}
