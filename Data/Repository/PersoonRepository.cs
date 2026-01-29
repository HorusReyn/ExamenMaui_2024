using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.Data.Repository
{
    public class PersoonRepository : BaseRepository, IPersoonRepository
    {
        public ICollection<Persoon> OphalenPersonen()
        {
            string sql = @"SELECT * FROM Soort";



            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Persoon>(sql).ToList();
            }
        }
        public ICollection<Persoon> OphalenPersonenViaTerm(string term)
        {
            
            //vind personen die voldoen aan waarde
                string sql = @"SELECT voornaam, achternaam FROM Persoon 
                WHERE voornaam like '%' + @term + '%'
                OR achternaam like '%' + @term + '%'";

                var parameters = new { @term = term };

                using (IDbConnection db = new SqlConnection(ConnectionString))
                {
                    return db.Query<Persoon>(sql, parameters).ToList();
                }
        }
      /* public ICollection<Eigenaar> OphalenEigenaarViaTerm(string term)
        {

            string sql = @"SELECT P.voornaam, P.achternaam 
                FROM Eigenaar E
                INNER JOIN Persoon P on E.persoonId = P.id

                WHERE voornaam like '%' + @term + '%'
                OR achternaam like '%' + @term + '%'";
        }*/
    }
}
