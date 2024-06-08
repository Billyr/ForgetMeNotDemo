using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNotDemo.ViewModel
{
    
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty] private string fullName;
        [ObservableProperty] private string _favoriteFlower = "flower";

        [ObservableProperty] private bool flowerVisible = true;


        [RelayCommand]
        private void ToggleFlowerVisibility()
        {
            FlowerVisible = !FlowerVisible;
            //flowerVisible = !FlowerVisible;
        }

    }
}
