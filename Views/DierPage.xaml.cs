namespace EindExamenMaui.Views
{
    public partial class DierPage : ContentPage
    {
        public DierPage(DierViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}