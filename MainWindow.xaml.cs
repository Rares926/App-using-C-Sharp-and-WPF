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

namespace Tema_MVP_Dictionar
{


    public partial class MainWindow : Window
    {

        FileReader fss = new FileReader();
        public Dictionary d = new Dictionary();


        public MainWindow()
        {
        
            InitializeComponent();
            fss.setDictFromFile(d);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var adm = new Administrativ(d);
            adm.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var tmp = new CautareCuvant(d);
            tmp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var tmp = new Divertisment(d);
            tmp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            fss.setDictInFile(d);
            this.Close();
        }
    }
}
