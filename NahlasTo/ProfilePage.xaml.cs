using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NahlasTo.Dialogs;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NahlasTo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            this.InitializeComponent();
        }

        private bool _isDialogOpen = false;

        private void SubmitProblemButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private async void AddCommunityButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isDialogOpen)
            {
                _isDialogOpen = true;
                AddCommunityDialog addCommunityDialog = new AddCommunityDialog();
                _ = await addCommunityDialog.ShowAsync();
                _isDialogOpen = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _ = Frame.Navigate(typeof(CommunityDetailPage));
        }
    }
}
