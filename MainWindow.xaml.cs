/* Andrea Bonafini
 * 25 march,2019
 * Text message translator
 */ 
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

namespace U2AndreaTXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();                      
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtEntered.Text;

            //TextEntered = txtEntered.Text.ToUpper();

                if (TextEntered == "CU")
                {
                    lblOutput.Content = "see you";
                }
                else if (TextEntered == ":-)")
                {
                    lblOutput.Content = "I'm happy";
                }
                else if (TextEntered == ":-(")
                {
                    lblOutput.Content = "I'm unhappy";
                }
                else if (TextEntered == ";-)")
                {
                    lblOutput.Content = "wink";
                }
                else if (TextEntered == ":-P")
                {
                    lblOutput.Content = "Stick out toungue";
                }
                else if (TextEntered == "(~.~)")
                {
                    lblOutput.Content = "sleepy";
                }
                else if (TextEntered == "TA")
                {
                    lblOutput.Content = "totally awesome";
                }
                else if (TextEntered == "CCC")
                {
                    lblOutput.Content = "Canadian Computing Competition";
                }
                else if (TextEntered == "CUZ")
                {
                    lblOutput.Content = "because";
                }
                else if (TextEntered == "TY")
                {
                    lblOutput.Content = "thank-you";
                }
                else if (TextEntered == "YW")
                {
                    lblOutput.Content = "you're welcome";
                }
                else if (TextEntered == "TTYL")
                {
                    lblOutput.Content = "talk to you later";
                }
                else if (TextEntered == "see you")
                {
                    lblOutput.Content = "CU";
                }
                else if (TextEntered == "I'm happy")
                {
                    lblOutput.Content = ":-)";
                }
                else if (TextEntered == "I'm unhappy")
                {
                    lblOutput.Content = ":-(";
                }
                else if (TextEntered == "wink")
                {
                    lblOutput.Content = ";-)";
                }
                else if (TextEntered == "Stick out toungue")
                {
                    lblOutput.Content = ":-P";
                }
                else if (TextEntered == "sleepy")
                {
                    lblOutput.Content = "(~.~)";
                }
                else if (TextEntered == "totally awesome")
                {
                    lblOutput.Content = "TA";
                }
                else if (TextEntered == "Canadian Computing Competition")
                {
                    lblOutput.Content = "CCC";
                }
                else if (TextEntered == "because")
                {
                    lblOutput.Content = "CUZ";
                }
                else if (TextEntered == "thank-you")
                {
                    lblOutput.Content = "TY";
                }
                else if (TextEntered == "you're welcome")
                {
                    lblOutput.Content = "YW";
                }
                else if (TextEntered == "talk to you later")
                {
                    lblOutput.Content = "TTYL";
                }
        }        
    }
}

