using System;
using System.Windows.Forms;

static class Program
{
    /// <summary>
    /// Точка входу.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();                     //  ?
        Application.SetCompatibleTextRenderingDefault(false); // ?
        Application.Run(new CalcForm());
    }
}