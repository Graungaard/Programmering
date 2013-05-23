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

namespace Prim.Forms
{
    /* Denne Classe skal tage 1 tal fra hver af de 2 tekstbokse, og laver dem til int,
     * derefter køre det en while løkke som køre indtil de to tal er ens, og i mellem tiden udskriver den alle prim tal den rammer 
     */ 
    
    
    public partial class FlerePrim : UserControl,ISwitchable
    {
        public FlerePrim()
        {
            InitializeComponent();
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        //back knappen som får en tilbage til MyMainMenu
        private void FlerePrimButtom_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MyMainMenu());
        }

        // ved at klikke på knappen tager du tallet fra begge bokse og laver dem til int
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (IntervalTal1.Text.Length == 0 || IntervalTal2.Text.Length == 0)
            {
                ErrorMessage.errormessage();
            }
            else
            {
                int anInteger1;
                int anInteger2;

                anInteger1 = Convert.ToInt32(IntervalTal1.Text);
                anInteger1 = int.Parse(IntervalTal1.Text);

                anInteger2 = Convert.ToInt32(IntervalTal2.Text);
                anInteger2 = int.Parse(IntervalTal2.Text);

                TextResultat.Text = string.Empty;

                //denne While løkke køre så længe de to tal ikke er ens, da der da ikke ville være noget interval at tjekke for prim tal
                while (anInteger1 != anInteger2)
                {
                    //denne if sætning formål af at køre tallet i den første boks er mindre ind tallet i boks 2
                    if (anInteger1 < anInteger2)
                    {
                        for (int i = anInteger1; i <= anInteger2; i++)
                        {
                            if (IsPrim.isPrime(i))
                            {
                                TextResultat.Text = TextResultat.Text + " " + i;
                            }
                            anInteger1 = i;
                        }
                    }
                    //den if sætning køre hvis det først tal overgår nummer 2.
                    if (anInteger2 < anInteger1)
                    {
                        for (int i = anInteger2; i <= anInteger1; i++)
                        {
                            if (IsPrim.isPrime(i))
                            {
                                TextResultat.Text = TextResultat.Text + " " + i;
                            }
                            anInteger2 = i;
                        }
                    }


                }
            }
        }
        //Forhindre at der bliver tastet text i textboxen
        private void IntervalTal1_TextChanged(object sender, TextChangedEventArgs e)
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
        //Forhindre at der bliver tastet text i textboxen
        private void IntervalTal2_TextChanged(object sender, TextChangedEventArgs e)
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
