using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TeveApp.Shared.Base.Interfaces;

namespace TeveApp.ViewModel.Base
{
    public class ViewModelBase : IViewModelBase, INotifyPropertyChanged
    {
        private bool isLoading;
        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                if (isLoading != value)
                {
                    isLoading = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelBase()
        {
            PropertyChanged += OnPropertyChanged;
        }

        public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IsLoading))
            {

            }
        }

        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {

        }
    }
}
