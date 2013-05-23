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


namespace Prim.Forms
    
{
  /* Denne class for mål er at tage tallet fra textboxen, 
   * og gør det til en int og der efter tjekke om det er et prim tal
   * alt efter svaret, så reager den med et positiv svar eller negativt svar
   */
    public partial class EtPrim : UserControl, ISwitchable
            {
        public EtPrim()
        {
            InitializeComponent();
            Pic.Visibility = Visibility.Hidden;
           
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        //Back knappen som bare går tilbage til MyMainSiden
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
               	Switcher.Switch(new MyMainMenu());
        }
        // tager tallet i tekstboxen og gør den int, og bruger IsPrim til at tjekke om det er prim
        private void TjekTalKnap_Click(object sender, RoutedEventArgs e)
        {
            

            if (SkrivTalBox.Text.Length == 0)
            {
                ErrorMessage.errormessage();
            }
            else
            {


                int anInteger;
                anInteger = Convert.ToInt32(SkrivTalBox.Text);
                anInteger = int.Parse(SkrivTalBox.Text);

                if (IsPrim.isPrime(anInteger))
                {
                    TalBlock.Text = "Det er et PrimTal.. Wuuhuu";
                    Pic.Visibility = Visibility.Visible;
                }
                else
                {
                    TalBlock.Text = " Niks Nej Narda det er ikke prim!";
                    Pic.Visibility = Visibility.Hidden;
                }
            }
                

        }
        //Forhindre at der bliver skrevet bokstaver i textboksen
        private void SkrivTalBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int iValue = -1;

            if (Int32.TryParse(textBox.Text, out iValue) == false)
            {
                TextChange textChange = e.Changes.ElementAt<TextChange>(0);
                int iAddedLength = textChange.AddedLength;
                int iOffset = textChange.Offset;

                textBox.Text = textBox.Text.Remove(iOffset, iAddedLength);
            }
             
         }
        
  	}
}
