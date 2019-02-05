using MVVMHelloWorld.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage ()
        {
            ViewModel = new PlaylistsViewModel(new PageService());
            
            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }

        public PlaylistsViewModel ViewModel
        {
            get { return BindingContext as PlaylistsViewModel; }
            set { BindingContext = value; }
        }
    }
}
