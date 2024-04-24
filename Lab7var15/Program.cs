using CoinCollection.Data;
using System;
using System.Windows.Forms;

namespace CoinCollection
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var dbContext = new CoinCollectionDbContext())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(dbContext));
            }
        }
    }
}