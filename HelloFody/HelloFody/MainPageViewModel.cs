using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloFody
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string Message { get; set; } = "Hello, Fody!";

        public ICommand UpdateMessage => new Command(() => Message = "Updated Message!!");

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
