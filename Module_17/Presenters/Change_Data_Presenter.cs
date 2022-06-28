using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
   public class Change_Data_Presenter
    {
        private MainWindow mainWindow;
        private Change_Data_Model change_Data_Model;

        public Change_Data_Presenter(MainWindow m)
        {
            mainWindow = m;
            change_Data_Model = new Change_Data_Model();
            mainWindow.ChangeDataEvent += ChangeDataHandler;

        }




        public void ChangeDataHandler(object sender, EventArgs e)
        {

            using (var context = new Context())
            {
                mainWindow.dataGrid.ItemsSource =
                change_Data_Model.ChangeData(mainWindow.customerIdBox.Text,
                                             mainWindow.changeSurnameBox.Text,
                                             mainWindow.changeNameBox.Text,
                                             mainWindow.changeFath_nameBox.Text,
                                             mainWindow.changeEmailBox.Text);
            }

            mainWindow.customerIdBox.Text = "";
            mainWindow.changeSurnameBox.Text = "";
            mainWindow.changeNameBox.Text = "";
            mainWindow.changeFath_nameBox.Text = "";
            mainWindow.changeEmailBox.Text = "";
        }





    }
}
