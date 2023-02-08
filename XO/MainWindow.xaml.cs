using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a = null;
        bool hod = false;
        bool Win = false;
        string[] zapoln = new string[9];
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();

        }

        private string Proverka(string b)
        {
            if (((LefU.Content == b) && (LefB.Content == b) && (LefM.Content == b)) || ((LefU.Content == b) && (RigB.Content == b) && (MidM.Content == b)) || ((RigU.Content == b) && (RigB.Content == b) && (RigM.Content == b)) || ((MidU.Content == b) && (MidB.Content == b) && (MidM.Content == b)) || ((LefB.Content == b) && (RigU.Content == b) && (MidM.Content == b)) || ((LefB.Content == b) && (RigB.Content == b) && (MidB.Content == b)) || ((LefU.Content == b) && (RigU.Content == b) && (MidU.Content == b)) || ((LefM.Content == b) && (RigM.Content == b) && (MidM.Content == b)))
            {
                LefB.IsEnabled = false;
                LefM.IsEnabled = false;
                LefU.IsEnabled = false;
                MidB.IsEnabled = false;
                MidM.IsEnabled = false;
                MidU.IsEnabled = false;
                RigB.IsEnabled = false;
                RigM.IsEnabled = false;
                RigU.IsEnabled = false;
                return "Победа";
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled = false) && (RigM.IsEnabled = false) && (RigU.IsEnabled = false))
            {
                return "Ничья";
            }
            else { return "Нет"; }
        }

        void Robot()
        {
            a = "X";
            int rnd = random.Next(1, 9);
            if (rnd == 1)
            {
                if (LefU.IsEnabled == true)
                {
                    LefU.IsEnabled = false;
                    LefU.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 2)
            {
                if (MidU.IsEnabled == true)
                {
                    MidU.IsEnabled = false;
                    MidU.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 3)
            {
                if (RigU.IsEnabled == true)
                {
                    RigU.IsEnabled = false;
                    RigU.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 4)
            {
                if (LefB.IsEnabled == true)
                {
                    LefB.IsEnabled = false;
                    LefB.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 5)
            {
                if (MidB.IsEnabled == true)
                {
                    MidB.IsEnabled = false;
                    MidB.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 6)
            {
                if (RigB.IsEnabled == true)
                {
                    RigB.IsEnabled = false;
                    RigB.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 7)
            {
                if (LefM.IsEnabled == true)
                {
                    LefM.IsEnabled = false;
                    LefM.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 8)
            {
                if (MidM.IsEnabled == true)
                {
                    MidM.IsEnabled = false;
                    MidM.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            else if (rnd == 9)
            {
                if (RigM.IsEnabled == true)
                {
                    RigM.IsEnabled = false;
                    RigM.Content = a;
                }
                else
                {
                    Robot();
                }
            }
            zapoln.Append("-");
            if (Proverka(a) == "Ничья")
            {
                Result.Text = "Ничья";
                StartGame.IsEnabled = true;
            }
            else if (Proverka(a) == "Победа")
            {
                Result.Text = "Победа за " + a;
                StartGame.IsEnabled = true;

            }
            else
            {
                Player();
            }
        }

        private void Player()
        {
            a = "O";
        }

        private void LefU_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = a;
            (sender as Button).IsEnabled = false;
            if (Proverka(a) == "Ничья")
            {
                Result.Text = "Ничья";
                StartGame.IsEnabled = true;
            }
            else if (Proverka(a) == "Победа")
            {
                Result.Text = "Победа за " + a;
                StartGame.IsEnabled = true;

            }
            else { Robot(); }
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
            (sender as Button).IsEnabled=false;
            LefB.IsEnabled = true; 
            LefB.Content = "";
            LefM.IsEnabled = true;
            LefM.Content = "";
            LefU.IsEnabled = true;
            LefU.Content = "";
            MidB.IsEnabled = true;
            MidB.Content = "";
            MidM.IsEnabled = true;
            MidM.Content = "";
            MidU.IsEnabled = true;
            MidU.Content = "";
            RigB.IsEnabled = true;
            RigB.Content = "";
            RigM.IsEnabled = true;
            RigM.Content = "";
            RigU.IsEnabled = true;
            RigU.Content = "";
            hod = false;
            Robot();
        }
    }
}
