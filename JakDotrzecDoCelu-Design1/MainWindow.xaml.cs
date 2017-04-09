using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JakDotrzecDoCelu_Design1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmb_NumberLine.Items.Add("Wybierz numer lini...");
            cmb_NumberLine.Items.Add("214");
            cmb_NumberLine.Items.Add("215");
            cmb_NumberLine.Items.Add("216");
            cmb_NumberLine.Items.Add("217");
            cmb_NumberLine.Items.Add("218");

            cmb_FinalStop.Items.Add("Wybierz przystanek końcowy");
            cmb_FinalStop.Items.Add("Dworzec Główny");
            cmb_FinalStop.Items.Add("Lubicz");
            cmb_FinalStop.Items.Add("Rondo Mogilskie");
            cmb_FinalStop.Items.Add("Białucha");


            cmb_StartStop.Items.Add("Wybierz przystanek początkowy");
            cmb_StartStop.Items.Add("Lubicz");
            cmb_StartStop.Items.Add("Rondo Mogilskie");
            cmb_StartStop.Items.Add("Białucha");

        }

        private void connent_Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wybrałeś dobrą linię?");
           

        }

        private void content_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            contain_StartStop.Content = $"Przystanek początkowy: {cmb_StartStop.SelectedItem}";


        }

        private void connent1_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contain_NumberLine.Content = $"Numer linii: {cmb_NumberLine.SelectedItem}";
        }

        private void connent_Copy1_Click(object sender, RoutedEventArgs e)
        {
            contain_NumberLine.Content = $"Numer linii: {cmb_NumberLine.SelectedItem}";
        }

        private void connent1_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contain_FinalStop.Content = $"Przystanek końcowy: {cmb_FinalStop.SelectedItem}";
        }

        private void cmb_StartStop_TouchEnter(object sender, TouchEventArgs e)
        {
            
        }

        private void connent_FinalStop_Click(object sender, RoutedEventArgs e)
        {
            contain_FinalStop.Content = $"Przystanek końcowy: {cmb_FinalStop.SelectedItem}";
        }

        private void connent_StartStop_Click(object sender, RoutedEventArgs e)
        {
            contain_StartStop.Content = $"Przystanek początkowy: {cmb_StartStop.SelectedItem}";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
