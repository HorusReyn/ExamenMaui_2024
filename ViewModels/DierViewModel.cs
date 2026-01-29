using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.ViewModels
{
    public partial class DierViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Dier selectedDier;

        private IDierRepository _dierRepository;
        private ISoortRepository _soortRepository;
        [ObservableProperty]
        private ObservableCollection<Dier> dieren;
        [ObservableProperty]
        private ObservableCollection<Soort> soorten;
        [ObservableProperty]
        public string actieLabel = "Nieuw dier toevoegen";

        [ObservableProperty]
        public string geslacht = "";
        [ObservableProperty]
        public string naam = "";
        [ObservableProperty]
        public int soortId = 0;
        public DierViewModel(DierRepository dierRepository, SoortRepository soortRepository)
        {
            _dierRepository = dierRepository;
            _soortRepository = soortRepository;
            Dieren = new ObservableCollection<Dier>(_dierRepository.OphalenDieren());
            Soorten = new ObservableCollection<Soort>(_soortRepository.OphalenSoorten());
            Title = "Dier beheren Lucas Das";
        }

        
        partial void OnSelectedDierChanged(Dier value)
        {
            if (value.Id == 0)
            {
                ActieLabel = "Nieuw dier toevoegen";
            }
            else
            {
                ActieLabel = "Dier wijzigen";
            }
        }


        [RelayCommand]
        private void Toevoegen()
        {
            _dierRepository.ToevoegenDier(Naam,SoortId,Geslacht);
              
        }
        [RelayCommand]
        private void Wijzigen()
        {
            _dierRepository.WijzigDier(SelectedDier, Naam, SoortId, Geslacht);
        }
        [RelayCommand]
        private void Verwijderen()
        {
            _dierRepository.VerwijderDier(SelectedDier);
        }
        [RelayCommand]
        private void Deselecteren()
        {
            Naam = "";
            SoortId = 0;
            Geslacht = "";
            SelectedDier = null;
        }


    }
}
