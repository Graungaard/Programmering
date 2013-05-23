using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Mailklient
{
    class Switcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       public static PageSwitcher PageSwitcher;
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      //      Application.Run(new Form1());
          public static void Switch(UserControl newPage)
    	{
      		PageSwitcher.Navigate(newPage);
    	}

    	public static void Switch(UserControl newPage, object state)
    	{
      		PageSwitcher.Navigate(newPage, state);
    	}
        }
    }
}
