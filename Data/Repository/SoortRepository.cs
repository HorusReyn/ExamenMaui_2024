using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.Data.Repository
{
    public class SoortRepository : BaseRepository, ISoortRepository
    {
        public ICollection<Soort> OphalenSoorten()
        {
            string sql = @"SELECT * FROM Soort";



            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Soort>(sql).ToList();
            }
        }
    }
}
