using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
    public class Create_BuysTable_Presenter
    {
        private MainWindow mainWindow;
        private Create_BuysTable_Model createTableModel;

        public Create_BuysTable_Presenter(MainWindow m)
        {
            mainWindow = m;
            createTableModel = new Create_BuysTable_Model();
            mainWindow.CreateBuysTableEvent += createTableModel.CreateBuysTable;
        }

    }
}
