using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
   public class Create_CustomerTable_Presenter
    {
        private MainWindow mainWindow;
        private Create_CustomerTable_Model createCustTableModel;

        public Create_CustomerTable_Presenter(MainWindow m)
        {
            mainWindow = m;
            createCustTableModel = new Create_CustomerTable_Model();
            mainWindow.CreateCustomerTableEvent += createCustTableModel.CreateCustomerTable;
        }


    }
}
