using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHelper.Demo.ViewModels;

namespace XamarinHelper.Demo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as StartViewModel;

            if (vm?.ItemTappedCommand != null && vm.ItemTappedCommand.CanExecute(e.Item))
                vm.ItemTappedCommand.Execute(e.Item);
        }
    }
}
