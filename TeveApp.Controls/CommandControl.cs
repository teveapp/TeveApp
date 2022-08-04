using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeveApp.Controls
{
    public class CommandControl : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Func<Task> ActionExecute { get; set; }

        public CommandControl(Func<Task> action)
        {
            ActionExecute = action; 
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            var page = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

            try
            {
                await Task.Delay(50);
                page.IsBusy = true;

                await ActionExecute();

                page.IsBusy = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await page.DisplayAlert("Atenção", "Ocorreu um erro inesperado, tente novamente mais tarde.", "Ok");
                page.IsBusy = false;
            }
        }
    }
}
