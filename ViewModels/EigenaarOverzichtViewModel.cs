using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindExamenMaui.ViewModels
{
    public partial class EigenaarOverzichtViewModel : BaseViewModel
    {
        [ObservableProperty]
        string zoektermEigenaar;
        [ObservableProperty]
        private ObservableCollection<Eigenaar> eigenaars;

        private IPersoonRepository _persoonRepository;
        public EigenaarOverzichtViewModel(PersoonRepository persoonRepository)
        {
            ZoektermEigenaar = string.Empty;
            _persoonRepository = persoonRepository;
            Title = "Overzicht dieren Lucas Das";
        }

        [RelayCommand]
        private void ZoekEigenaar()
        {
            //Eigenaars = new ObservableCollection<Eigenaar>( _persoonRepository.OphalenPersonenViaTerm(zoektermEigenaar));
        }
    }
}
