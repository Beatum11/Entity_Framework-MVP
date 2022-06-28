using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
   public class Show_BuysTable_Presenter
    {
        private MainWindow mainWindow;
        private Show_Buys_Table_Model buysTableModel;


        public Show_BuysTable_Presenter (MainWindow m)
        {
            mainWindow = m;
            buysTableModel = new Show_Buys_Table_Model();
            mainWindow.ShowBuysTableEvent += ShowBuysTableHandler;
        }


        /// <summary>
        /// Показывает таблицу с покупками клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowBuysTableHandler(object sender, EventArgs e)
        {
            using (var newContext = new NewContext())
            {
                mainWindow.dataGrid.ItemsSource = buysTableModel.ShowBuysTable();
                newContext.SaveChanges();

            }
        }

    }
}
