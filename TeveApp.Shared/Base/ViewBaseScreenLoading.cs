using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TeveApp.Shared.Base
{
    public class ViewBaseScreenLoading : Grid
    {
        public ViewBaseScreenLoading()
        {
            SetupGrid();
            BuildContainer();
        }

        private void SetupGrid()
        {
            this.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
            this.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
            this.VerticalOptions = LayoutOptions.Fill;
            this.HorizontalOptions = LayoutOptions.Fill;
            this.BackgroundColor = Color.FromArgb("#80000000");
        }
        private void BuildContainer()
        {
            Image image = new Image();
            //image.Source = "circle_loading.gif";
            //image.IsAnimationPlaying = true;
            image.HorizontalOptions = LayoutOptions.Center;
            image.HeightRequest = 30;
            image.WidthRequest = 30;
            image.Margin = new Thickness(50, 30);

            Frame frame = new Frame();
            frame.VerticalOptions = LayoutOptions.Center;
            frame.HorizontalOptions = LayoutOptions.Center;
            frame.BackgroundColor = Color.FromHex("FFFFFF");
            frame.Content = image;
            this.Add(frame, 0, 0);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
