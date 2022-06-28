using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
   public class Presenter
    {
        private MainWindow mainWindow;
        private Model model;

        private Show_Table_Model showTableModel;

        public Presenter(MainWindow m)
        {
            mainWindow = m;
            model = new Model();
            showTableModel = new Show_Table_Model();

            mainWindow.ShowBuysEvent += ShowBuysHandler;
            mainWindow.ShowTableEvent += ShowTableHandler;
        }


        #region Методы
       
        /// <summary>
        /// Показать покупки клиента по Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowBuysHandler(object sender, EventArgs e)
        {
            using (var newContext = new NewContext())
            {
                mainWindow.dataGrid.ItemsSource = model.ShowBuys(mainWindow.clientEmail.Text);
            }
        }


        /// <summary>
        /// Показать таблицу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ShowTableHandler(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                mainWindow.dataGrid.ItemsSource = showTableModel.ShowTable();
                context.SaveChanges();
            }


        }

        #endregion
    }
}
