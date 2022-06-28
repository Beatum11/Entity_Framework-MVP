using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using Module_17.Presenters;

namespace Module_17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region События
        public event EventHandler ShowBuysEvent;
        public event EventHandler AddCustomerEvent;
        public event EventHandler ShowTableEvent;
        public event EventHandler ChangeDataEvent;
        public event EventHandler DeleteDataEvent;
        public event EventHandler ShowBuysTableEvent;

        public event Action CreateBuysTableEvent;
        public event Action CreateCustomerTableEvent;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            CreateCustomerTableEvent.Invoke();
            CreateBuysTableEvent.Invoke();

            new Presenter(this);
            new Add_Customer_Presenter(this);
            new Change_Data_Presenter(this);
            new Delete_Data_Presenter(this);
            new Show_BuysTable_Presenter(this);
            new Create_BuysTable_Presenter(this);
        }

        #region Кнопки

        /// <summary>
        /// Вывод покупок клиента по Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showBuysButton_Click(object sender, RoutedEventArgs e)
        {
            ShowBuysEvent.Invoke(sender, e);
        }   

        /// <summary>
        /// Добавление новой записи о клиенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerEvent.Invoke(sender, e);
        }

        /// <summary>
        /// Вывод таблицы с клиентами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTableButton_Click(object sender, RoutedEventArgs e)
        {
            ShowTableEvent.Invoke(sender, e);
        }

        /// <summary>
        /// Изменение данных конкретного клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeDataButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeDataEvent.Invoke(sender, e);
 
        }

        /// <summary>
        /// Удаление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteDataButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteDataEvent.Invoke(sender, e);
        }

        /// <summary>
        /// Показывает таблицу с покупками клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showBuysTable_Click(object sender, RoutedEventArgs e)
        {
            ShowBuysTableEvent.Invoke(sender, e);
        }

        #endregion


    }
}
