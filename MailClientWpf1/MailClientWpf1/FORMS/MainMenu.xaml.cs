using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailClientWpf1.FORMS
{
    //Dette er min Main Menu, som fungere som den første side man ser, og som den side man vender tilbage til.
    public partial class MyMainMenu : UserControl, ISwitchable
    {
        public MyMainMenu()
        {
            InitializeComponent();
        }
        // switcher billede om til siden med programmet et prim tal
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Switcher.Switch(new EtPrim());
        }


        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        // switcher billedet om til siden med programmet, som viser alle prim tal i mellem to tal.
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FlerePrim());
        }
    }
}
