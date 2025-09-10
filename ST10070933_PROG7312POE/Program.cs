using System;
using System.Windows.Forms;
using ST10070933_PROG7312POE.Forms;

namespace ST10070933_PROG7312POE
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenuForm());
        }
    }
}