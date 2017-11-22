using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI
{
    public static class Program
    {
        /// <summary>
        /// Biến chứa đối tượng form chính
        /// </summary>
        public static MainForm mainForm;
        /// <summary>
        /// Điểm bắt đầu của chương trình
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
