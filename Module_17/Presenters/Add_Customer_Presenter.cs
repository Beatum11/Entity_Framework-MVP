using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17.Models;

namespace Module_17.Presenters
{
    public class Add_Customer_Presenter
    {
        private MainWindow mainWindow;
        private Add_Customer_Model addModel;

        public Add_Customer_Presenter(MainWindow m)
        {
            mainWindow = m;
            addModel = new Add_Customer_Model();
            mainWindow.AddCustomerEvent += AddCustomerHandler;

        }

        public void AddCustomerHandler(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                mainWindow.dataGrid.ItemsSource = addModel.AddCustomer(mainWindow.surnameBox.Text,
                                                                       mainWindow.nameBox.Text,
                                                                       mainWindow.fath_nameBox.Text,
                                                                       mainWindow.emailBox.Text);

                mainWindow.surnameBox.Text = "";
                mainWindow.nameBox.Text = "";
                mainWindow.fath_nameBox.Text = "";
                mainWindow.emailBox.Text = "";
            }

        }

    }
}
