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
using System.Windows.Shapes;
using System.Windows.Forms;




namespace Tema_MVP_Dictionar
{
 
    public partial class CautareCuvant : Window
    {

        [System.ComponentModel.Browsable(true)]
        public System.Windows.Forms.AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }
        Dictionary d;
        public CautareCuvant(Dictionary d)
        {
            InitializeComponent();
            this.d = d;
            ForCategory.Items.Add("All");
            foreach (string a in d.Categ)
            {
                ForCategory.Items.Add(a);
            }
            ForCategory.Text = "All";
           
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ForDefinition.Visibility = Visibility.Visible;
            ForWords.Visibility = Visibility.Visible;

            foreach (Word a in d.Dict)
            {
                if(a.cuv==searchBar.Text)
                {
                    ForDefinition.Text = a.definitie;
                    ForWords.Text = a.category;
                }
            }
        }

        private void searchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            ForDefinition.Visibility = Visibility.Hidden;
            ForWords.Visibility = Visibility.Hidden;

            listToComplete.Items.Clear();
 
            if (searchBar.Text.Length>1)
            {
               
                foreach (Word a in d.Dict)
                {
                    if (ForCategory.Text == "All")
                    {
                        if (a.cuv.StartsWith(searchBar.Text) && a.cuv != searchBar.Text)
                        {
                            listToComplete.Items.Add(a.cuv);
                        }
                    }
                    else
                    {
                        if (a.category == ForCategory.Text)
                        {
                            if (a.cuv.StartsWith(searchBar.Text) && a.cuv != searchBar.Text)
                            {
                                listToComplete.Items.Add(a.cuv);
                            }
                        }
                    }
       
                }

            }
        }

        private void listToComplete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listToComplete.SelectedItem==null)
                return;

            searchBar.Text = listToComplete.SelectedItem.ToString(); 
        }

        private void ForCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchBar.Text = "";
        }
    }
}
