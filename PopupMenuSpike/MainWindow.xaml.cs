using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PopupMenuSpike
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Profiles { get; } = new() { "Apple", "Banana", "Cherry" };

        public string selectedProfile;

        public MainWindow()
        {
            selectedProfile = string.Empty;
            InitializeComponent();
        }

        private void Popup_Opened(object sender, EventArgs e)
        {
            var popup = (Popup)sender;
            var border = (Border)popup.Child;
            var listBox = (ItemsControl)border.Child;

            listBox.Focus();
            //Keyboard.Focus(listBox);
        }

        private void ProfileTemplates_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).Content.ToString());
            ProfilePopUp.IsOpen = false;
        }
    }
}
