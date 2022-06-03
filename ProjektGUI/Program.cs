using System;
using System.Windows.Forms;

namespace ColorCorrectionProgram
{
    static class ColorCorrection
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ColorCorr());
        }
    }
}
