using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
    public class Delete_Data_Presenter
    {
        private MainWindow mainWindow;
        private Delete_Data_Model delete_Data_Model;

        public Delete_Data_Presenter(MainWindow m)
        {
            mainWindow = m;
            delete_Data_Model = new Delete_Data_Model();

            mainWindow.DeleteDataEvent += DeleteDataHandler;
        }


        public void DeleteDataHandler(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                mainWindow.dataGrid.ItemsSource = delete_Data_Model.DeleteData
                                              (mainWindow.deleteCustomerIdBox.Text);

                mainWindow.deleteCustomerIdBox.Text = "";

            }

        }



    }
}
