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

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtAbreviation.Text;

            TextEntered = txtAbreviation.Text.ToUpper();

            for (int i = 0; i < 100; i++)
            {
                TextEntered = TextEntered.Replace("CUZ", "because" + Environment.NewLine);
                TextEntered = TextEntered.Replace("CU", "see you" + Environment.NewLine);
                TextEntered = TextEntered.Replace("see you", "CU" + Environment.NewLine);
                TextEntered = TextEntered.Replace(":-)", "I’m happy" + Environment.NewLine);
                TextEntered = TextEntered.Replace("I’m happy", ":-)" + Environment.NewLine);
                TextEntered = TextEntered.Replace(":-(", "I’m unhappy" + Environment.NewLine);
                TextEntered = TextEntered.Replace("I’m unhappy", ":-(" + Environment.NewLine);
                TextEntered = TextEntered.Replace(";-)", "wink" + Environment.NewLine);
                TextEntered = TextEntered.Replace("wink", ";-)" + Environment.NewLine);
                TextEntered = TextEntered.Replace(":-P", "stick out my tongue" + Environment.NewLine);
                TextEntered = TextEntered.Replace("stick out my tongue", ":-P" + Environment.NewLine);
                TextEntered = TextEntered.Replace("(˜.˜)", "sleepy" + Environment.NewLine);
                TextEntered = TextEntered.Replace("sleepy", "(˜.˜)" + Environment.NewLine);
                TextEntered = TextEntered.Replace("TA", "totally awesome" + Environment.NewLine);
                TextEntered = TextEntered.Replace("CCC", "Canadian Computing Competition" + Environment.NewLine);
                TextEntered = TextEntered.Replace("TTYL", "talk to you later" + Environment.NewLine);
                TextEntered = TextEntered.Replace("TY", " thank-you" + Environment.NewLine);
                TextEntered = TextEntered.Replace("YW", "you’re welcome" + Environment.NewLine);
                TextEntered = TextEntered.Replace("you’re welcome", "YW" + Environment.NewLine);
                TextEntered = TextEntered.Replace("totally awesome", "TA" + Environment.NewLine);
                TextEntered = TextEntered.Replace("Canadian Computing Competition", "CCC" + Environment.NewLine);
                TextEntered = TextEntered.Replace("talk to you later", "TTYL" + Environment.NewLine);
                TextEntered = TextEntered.Replace("thank-you", "TY " + Environment.NewLine);
                TextEntered = TextEntered.Replace(" ", " " + Environment.NewLine);
                //TextEntered = TextEntered.Replace("because", "CUZ" + Environment.NewLine);
            }
           lblOutput.Content = " " + TextEntered;

        }
        private void btnReplace1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
