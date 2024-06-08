using ForgetMeNotDemo.ViewModel;

namespace ForgetMeNotDemo
{
    public partial class MainPage : ContentPage
    {
        MainViewModel vm = new();
        public MainPage()
        {
            vm.FullName = "Billy";

            InitializeComponent();

            BindingContext = vm;
        }

    }

}
