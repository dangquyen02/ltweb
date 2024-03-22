using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV20T1020237.BusinessLayers
{
    /// <summary>
    /// Khởi tạo lưu trữ các thông tin cấu hình của BusinessLayer
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Chuỗi kết thông số kết nối đến csdl
        /// </summary>
        public static string ConnectionString { get; set; } = "";
        /// <summary>
        /// Khởi tạo cấu hình cho BusinessLayer
        /// (Hàm này phải đc gọi trước khi ứng dụng chạy)
        /// </summary>
        /// <param name="connectionString"></param>
        public static void Initialize(string connectionString)
        {
            Configuration.ConnectionString = connectionString;
        }
    }
}
//static class là gì? khác với class thông thường chỗ nào?
