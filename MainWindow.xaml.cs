/* Computer Science
 * Dominic Langowski 6/19/2020
 * Mr. McTavish */
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

namespace Interger_Practise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {

        Random r = new Random();

        int number1;
        int number2;

        int Input;

        string random;

        int[] operations = new int[4];


        public MainWindow()
        {
          
            InitializeComponent();

            number1 = r.Next(12) + 1;
            number2 = r.Next(12) + 1;



            string [] functions = new string[4];

            

            functions[0] = "+";
            functions[1] = "-";
            functions[2] = "*";
            functions[3] = "/";

            

            
            

           // MessageBox.Show(operations[random].ToString());

            operations[0] = number1 + number2;
            operations[1] = number1 - number2;
            operations[2] = number1 * number2;
            operations[3] = number1 / number2;

            random = functions[r.Next(4)];
            //MessageBox.Show(random);
            //MessageBox.Show("r1: " + number1 + " " + "r2: " + number2);

            if(random == "+")
            {
                lblEquation.Content += number1 + " + " + number2;
            }

            else if(random == "-")
            {
                lblEquation.Content += number1 + " - " + number2;
            }

            else if(random == "*")
            {
                lblEquation.Content += number1 + " * " + number2;
            }

            else if(random == "/")
            {
                lblEquation.Content += number1 + " / " + number2;
            }
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtInput.Text, out Input);
    
            if (Input == operations[0])
            {
                lblCheckedAnswer.Content += "Correct Answer ";
            }
            else if (Input == operations[1])
            {
                lblCheckedAnswer.Content += "Correct Answer ";
            }
            else if (Input == operations[2])
            {
                lblCheckedAnswer.Content += "Correct Answer ";
            }
            else if (Input == operations[3]) 
            {
                lblCheckedAnswer.Content += "Correct Answer ";
            }
            else
            {
                lblCheckedAnswer.Content += "Incorrect Answer, Try Again ";
            }
        }
    }
}
