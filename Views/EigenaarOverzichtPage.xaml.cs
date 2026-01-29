namespace EindExamenMaui.Views
{
    public partial class EigenaarOverzichtPage : ContentPage
    {
        public EigenaarOverzichtPage(EigenaarOverzichtViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}