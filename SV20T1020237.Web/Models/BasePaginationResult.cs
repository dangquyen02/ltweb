using SV20T1020237.DomainModels;

namespace SV20T1020237.Web.Models
{
    /// <summary>
    /// Lớp cha cho các lớp biểu diễn dữ liệu kết quả tìm kiếm, phân trang
    /// </summary>
    public abstract class BasePaginationResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; } = "";
        public int RowCount { get; set; }
        public int PageCount
        {
            get
            {
                if (PageSize == 0)
                    return 1;

                int c = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                    c += 1;
                return c;
            }
        }
    }

    public abstract class BasePaginationProductResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SearchValue { get; set; } = "";
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int RowCount { get; set; }
        public int PageCount
        {
            get
            {
                if (PageSize == 0)
                {
                    return 1;
                }
                int c = RowCount / PageSize;
                if (RowCount % PageSize > 0)
                {
                    c += 1;
                }
                return c;
            }
        }
    }

    /// <summary>
    /// kết quả tìm kiếm và lấy danh sách khách hàng
    /// </summary>
    public class CustomerSearchResult : BasePaginationResult
    {
        public List<Customer> Data { get; set; }
    }

    public class ShipperSearchResult : BasePaginationResult
    {
        public List<Shipper> Data { get; set; }
    }

    public class SupplierSearchResult : BasePaginationResult
    {
        public List<Supplier> Data { get; set; }
    }

    public class CategorySearchResult : BasePaginationResult
    {
        public List<Category> Data { get; set; }
    }

    public class EmployeeSearchResult : BasePaginationResult
    {
        public List<Employee> Data { get; set; }
    }

    public class ProductSearchResult : BasePaginationProductResult
    {
        public List<Product> Data { get; set; }
    }
}
