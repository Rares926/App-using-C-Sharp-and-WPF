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


namespace Tema_MVP_Dictionar
{

    public partial class Administrativ : Window
    {

        Dictionary d;

        public Administrativ(Dictionary d)
        {
           
            InitializeComponent();
            this.d = d;
            foreach (string a in d.Categ)
            {
                ForCategory.Items.Add(a);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ForWords.Text.Length==0||ForDefinition.Text.Length==0||ForCategory.Text.Length==0)
            {
                Update.Text = "Ati omis completarea unei casute necesare pentru adaugarea unui cuvant noi in dictionar";
            }
             else
                {
                if (d.CheckWord(ForWords.Text) == false)
                {
                    if (d.Categ.Contains(ForCategory.Text) != true)
                    {
                        d.Categ.Add(ForCategory.Text);
                        ForCategory.Items.Add(ForCategory.Text);
                    }
                    Word nW = new Word(ForWords.Text, ForDefinition.Text, ForCategory.Text);
                    d.Dict.Add(nW);
                    Update.Text = "A fost adaugat cuvantul '" + ForWords.Text + "' in dictionar";

                }
                else
                    Update.Text = "Cuvantul exista deja in dictionar";
                }
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            if(d.CheckWord(ForWords.Text)==true)
            {
                d.EraseWord(ForWords.Text);
                Update.Text = "A fost sters cuvantul '" + ForWords.Text + "' din dictionar";
            }
            else
            {
                Update.Text = "Cuvantul '" + ForWords.Text + "' nu exista in dictionar";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(d.CheckWord(ForWords.Text))
            {
                int index = d.ReturnIndexOfWord(ForWords.Text);
                d.Dict[index].definitie = ForDefinition.Text;
                Update.Text = "Datele cuvantului '" + ForWords.Text + "' au fost modificate";
            }
        }
    }
}
