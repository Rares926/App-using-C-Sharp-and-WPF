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
  
    public partial class Divertisment : Window
    {
        Dictionary d;
        public List<Word> wordsForGame = new List<Word>();
        public int level;
        public int Scor;
        public Word actualWord = new Word();

        public Divertisment(Dictionary d)
        {
            InitializeComponent();
        this.d=d;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forNextBtn.Visibility = Visibility.Visible;
            level = 0;
            Scor = 0;
            forNextBtn.Content = "Next";
            var rnd = new Random();
            actualWord=d.Dict[rnd.Next(d.Dict.Count)];
            hintBtn.Text = actualWord.definitie;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
       
        
            if(level==4)
            {
                hintBtn.Text = "";
                forNextBtn.Visibility = Visibility.Hidden;
                if (Answer.Text == actualWord.cuv)
                {
                    correctWord.Background = new SolidColorBrush(Colors.Green);
                    correctWord.Text = "Correct";
                    Scor++;
                }
                else
                {
                    correctWord.Background = new SolidColorBrush(Colors.Red);
                    correctWord.Text = "Incorect, cuvantul corect era: "+actualWord.cuv;
                }
                MessageBox.Show("Felicitari ati obtinut: " + Scor + " puncte");
                hintBtn.Text = "Jocul s-a incheiat daca doriti sa jucati iar apasati pe butonul Start.";
                return;
            }
            else if (level != 5)
            {
                if (Answer.Text == actualWord.cuv)
                {
                    correctWord.Background = new SolidColorBrush(Colors.Green);
                    correctWord.Text = "Correct";
                    Scor++;
                }
                else
                {
                    correctWord.Background = new SolidColorBrush(Colors.Red);
                    correctWord.Text = "Incorect, cuvantul corect era: " + actualWord.cuv;
                    correctWord.Text = actualWord.cuv;
                }

                var rnd = new Random();
                actualWord = d.Dict[rnd.Next(d.Dict.Count)];

                hintBtn.Text = actualWord.definitie;
                level++;
                if(level==4)
                {
                    forNextBtn.Content = "Finnish";
                }
            }
       

        }
    }
}
