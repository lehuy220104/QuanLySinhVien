using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-2IP3FB5;Initial Catalog=QLSinhVien;Integrated Security=True");
    }
}
