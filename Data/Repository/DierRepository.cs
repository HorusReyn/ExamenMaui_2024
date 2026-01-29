using EindExamenMaui.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.Data.Repository
{
    public class DierRepository : BaseRepository, IDierRepository
    {
        public ICollection<Dier> OphalenDieren()
        {
            string sql = @"SELECT * FROM Dier";

            

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Dier>(sql).ToList();
            }
        }
        public void ToevoegenDier(string naam, int soortId,string geslacht)
        {
             string sql = @"INSERT INTO Dier (naam, soortId, geslacht)
        VALUES (@naam, @soortId, @geslacht)";

        var parameters = new
        {
            @naam = naam,
            @soortId = soortId,
            @geslacht = geslacht,                  
        };

            using IDbConnection db = new SqlConnection(ConnectionString);
            var affectedRows = db.Execute(sql, parameters);
        }
        public void VerwijderDier(Dier dier)
        {
            
                string sql = @"DELETE FROM Eigenaar WHERE dierId = @id;
                DELETE FROM Dier WHERE Id = @id";

                using IDbConnection db = new SqlConnection(ConnectionString);
                var affectedRows = db.Execute(sql, new { id = dier.Id });
        }
        public void WijzigDier(Dier dier,string naam, int soortId, string geslacht)
        {
            
                string sql = @"UPDATE Dier
                    SET naam = @naam,
                        soortId = @soortId,                      
                        geslacht = @geslacht
                    WHERE Id = @id";

                var parameters = new
                {
                    @id = dier.Id,
                    @naam = naam,
                    @soortId = soortId,
                    @geslacht = geslacht,                  
                };

                using IDbConnection db = new SqlConnection(ConnectionString);
                var affectedRows = db.Execute(sql, parameters);

        }
      
    }
}
