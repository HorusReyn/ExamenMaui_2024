

namespace EindExamenMaui.Data.IRepository
{
    public interface IDierRepository
    {
        public ICollection<Dier> OphalenDieren();
        public void ToevoegenDier(string naam, int soortId,string geslacht);
        public void VerwijderDier(Dier dier);
        public void WijzigDier(Dier dier, string naam, int soortId,string geslacht);
    }
}
