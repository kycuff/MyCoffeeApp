using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        public ICommand IncreaseCount { get; }

        int count = 0;

        private string _countDisplay;

        public string CountDisplay
        {
            get => _countDisplay;
            set
            {
                if (value == _countDisplay)
                    return;

                _countDisplay = value;
                OnPropertyChanged(nameof(CountDisplay));
            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"you clicked {count} times(s)";
        }
    }
}
