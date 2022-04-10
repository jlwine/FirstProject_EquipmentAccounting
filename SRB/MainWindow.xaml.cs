using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.Data;
using System.Data.SqlClient;

namespace SRB
{


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Учёт_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = Учёт;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Склад";
        }

        private void Учёт_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Сотрудники_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = AccBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Учёт оборудования";
        }

        private void Сотрудники_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        

        private void Кабинеты_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Учёт_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("/Stock.xaml", UriKind.Relative));

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            Main.NavigationService.Navigate(new Uri("/DeleteEq.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

            Main.NavigationService.Navigate(new Uri("/EditingEq.xaml", UriKind.Relative));

        }

        private void Stock_Click_1(object sender, RoutedEventArgs e)
        {
            
            Main.NavigationService.Navigate(new Uri("/AddEquipment.xaml", UriKind.Relative));

        }

        private void AccBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("/EqAccounting.xaml", UriKind.Relative));

        }

        private void FeedbackBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            popup_uc.PlacementTarget = FeedbackBtn;
            popup_uc.Placement = PlacementMode.Right;
            popup_uc.IsOpen = true;
            Header.PopupText.Text = "Сообщить о поломке";
        }

        private void FeedbackBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            popup_uc.Visibility = Visibility.Collapsed;
            popup_uc.IsOpen = false;
        }

        private void FeedbackBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Uri("/FeedbackCrash.xaml", UriKind.Relative));

        }
    }
}
