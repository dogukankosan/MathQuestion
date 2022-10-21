using System.Data.SQLite;
using System.Windows.Forms;
namespace MatematikIslemleri.Class
{
    internal class Connection
    {
        internal static readonly SQLiteConnection dbConnection = new($"Data source={Application.StartupPath}\\Database\\dbMath.db;Versiyon=3");
    }
}