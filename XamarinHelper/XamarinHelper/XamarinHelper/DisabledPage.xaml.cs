using Xamarin.Forms.Xaml;

namespace XamarinHelper
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
