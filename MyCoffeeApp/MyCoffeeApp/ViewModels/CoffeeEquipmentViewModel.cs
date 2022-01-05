using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public ObservableRangeCollection<string> Coffee { get; }
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            CallServerCommand = new AsyncCommand(CallServer);
            Coffee = new ObservableRangeCollection<string>();
            Title = "Coffee Equipment";
        }

        public ICommand CallServerCommand { get;}

        async Task CallServer()
        {
            var items = new List<string> { "Yes Plz", "Tonx","Blue bottle"};
            Coffee.AddRange(items);
        }

        public ICommand IncreaseCount { get; }

        int count = 0;

        private string _countDisplay;

        public string CountDisplay
        {
            get => _countDisplay;
            set => SetProperty(ref _countDisplay, value);
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"you clicked {count} times(s)";
        }
    }
}
