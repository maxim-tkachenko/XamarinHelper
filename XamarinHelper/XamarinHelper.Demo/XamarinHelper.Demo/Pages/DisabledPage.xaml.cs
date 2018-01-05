using Xamarin.Forms.Xaml;

namespace XamarinHelper.Demo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisabledPage
    {
        public DisabledPage()
        {
            InitializeComponent();

            IsDisabled = true;
        }
    }
}
