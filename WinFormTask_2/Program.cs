using WinFormTask_2.Forms;
using WinFormTask_2.Forms.Form2;

namespace WinFormTask_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            //Application.Run(new Form1()); // ANKET

            Application.Run(new Form2()); // CALCULATOR


        }
    }
}