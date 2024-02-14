using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Sample_TotalFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //При помощи лямбды выражения создали функцию из двух параметров которая вызывает метод FilterInitialize()
            //Фактически это заменяет такой формат обработчка:
            //private void EquipmentFilterCB_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    FilterInitialize();
            //}

            NumberFilterTB.TextChanged += (sender, e) => FilterInitialize();
            PriorityFilterTB.TextChanged += (sender, e) => FilterInitialize();
            EquipmentFilterCB.SelectedIndexChanged += (sender, e) => FilterInitialize();
            ClientFilterCB.SelectedIndexChanged += (sender, e) => FilterInitialize();
            ExecutorFilterCB.SelectedIndexChanged += (sender, e) => FilterInitialize();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        //Инициализация без фильтрации
        private void Initialize()
        {
            #region Адаптеры таблиц
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.EXECUTORS". При необходимости она может быть перемещена или удалена.
            this.eXECUTORSTableAdapter.Fill(this.requestServicesDataSet.EXECUTORS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.EQUIPMENTS". При необходимости она может быть перемещена или удалена.
            this.eQUIPMENTSTableAdapter.Fill(this.requestServicesDataSet.EQUIPMENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.CLIENTS". При необходимости она может быть перемещена или удалена.
            this.cLIENTSTableAdapter.Fill(this.requestServicesDataSet.CLIENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.requestServicesDataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.REQUESTS". При необходимости она может быть перемещена или удалена.
            this.rEQUESTSTableAdapter.Fill(this.requestServicesDataSet.REQUESTS);
            #endregion


            RequestsLV.Items.Clear();
            foreach (RequestServicesDataSet.REQUESTSRow row in requestServicesDataSet.REQUESTS.Rows)
            {
                DataRow refRow;
                string[] items = new string[6];
                items[0] = row.DateAdd.ToString("dd.MM.yyyy HH:mm:ss");
                items[1] = row.Priority.ToString();
                refRow = row.GetParentRow("FK_REQUESTS_EQUIPMENTS");
                items[2] = refRow["Title"].ToString();
                refRow = row.GetParentRow("FK_REQUESTS_CLIENTS");
                var client = requestServicesDataSet.USERS.FirstOrDefault(u=>u.IDUser == (int)refRow["IDUser"]);
                items[3] = client.FIO;
                refRow = row.GetParentRow("FK_REQUESTS_EXECUTORS");
                var executor = requestServicesDataSet.USERS.FirstOrDefault(u=>u.IDUser == (int)refRow["IDUser"]);
                items[4] = executor.FIO;
                items[5] = row.Status;
                ListViewItem it = new ListViewItem()
                {
                    Text = row.IDRequest.ToString()
                };
                it.SubItems.AddRange(items);
                RequestsLV.Items.Add(it);
            }

            //Очищаем список от прошлых значений
            EquipmentFilterCB.Items.Clear();
            //Ставим заглушку для выборки всех значений
            EquipmentFilterCB.Items.Add("Вся техника");
            //В качестве выбранного элемента ставим первый, как все значения
            EquipmentFilterCB.SelectedIndex = 0;
            //Заполняем список
            foreach (DataRow row in requestServicesDataSet.EQUIPMENTS.Rows)
            {
                EquipmentFilterCB.Items.Add(row["Title"].ToString());
            }

            ClientFilterCB.Items.Clear();
            ClientFilterCB.Items.Add("Все клиенты");
            ClientFilterCB.SelectedIndex = 0;
            foreach (DataRow row in requestServicesDataSet.CLIENTS.Rows)
            {
                DataRow refRow;
                //Получаем ФИО клиента
                refRow = row.GetParentRow("FK_CLIENTS_USERS");
                ClientFilterCB.Items.Add(refRow["FIO"].ToString());
            }

            ExecutorFilterCB.Items.Clear();
            ExecutorFilterCB.Items.Add("Все исполнители");
            ExecutorFilterCB.SelectedIndex = 0;
            foreach (DataRow row in requestServicesDataSet.EXECUTORS.Rows)
            {
                DataRow refRow;
                //Получаем ФИО исполнителя
                refRow = row.GetParentRow("FK_EXECUTORS_USERS");
                ExecutorFilterCB.Items.Add(refRow["FIO"].ToString());
            }
        }
        //Инициализация с фильтрацией
        private void FilterInitialize()
        {
            //Адаптеры таблиц
            #region Адаптеры таблиц
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.EXECUTORS". При необходимости она может быть перемещена или удалена.
            this.eXECUTORSTableAdapter.Fill(this.requestServicesDataSet.EXECUTORS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.EQUIPMENTS". При необходимости она может быть перемещена или удалена.
            this.eQUIPMENTSTableAdapter.Fill(this.requestServicesDataSet.EQUIPMENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.CLIENTS". При необходимости она может быть перемещена или удалена.
            this.cLIENTSTableAdapter.Fill(this.requestServicesDataSet.CLIENTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter.Fill(this.requestServicesDataSet.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "requestServicesDataSet.REQUESTS". При необходимости она может быть перемещена или удалена.
            this.rEQUESTSTableAdapter.Fill(this.requestServicesDataSet.REQUESTS);
            #endregion

            RequestsLV.Items.Clear();
            // Фильтрация производим с помощью Linq запроса Where
            // r - псевдоним экземпляра класса RequestServicesDataSet.REQUESTSRow,
            // который представляет строку перебора таблицы
            // Метод Filtered, созданный нами функция возвращающая bool, которая даёт разрешения пропустить строку
            foreach (RequestServicesDataSet.REQUESTSRow row in requestServicesDataSet.REQUESTS.Where(r=>Filtered(r)))
            {
                DataRow refRow;
                string[] items = new string[6];
                items[0] = row.DateAdd.ToString("dd.MM.yyyy HH:mm:ss");
                items[1] = row.Priority.ToString();
                refRow = row.GetParentRow("FK_REQUESTS_EQUIPMENTS");
                items[2] = refRow["Title"].ToString();
                refRow = row.GetParentRow("FK_REQUESTS_CLIENTS");
                var client = requestServicesDataSet.USERS.FirstOrDefault(u => u.IDUser == (int)refRow["IDUser"]);
                items[3] = client.FIO;
                refRow = row.GetParentRow("FK_REQUESTS_EXECUTORS");
                var executor = requestServicesDataSet.USERS.FirstOrDefault(u => u.IDUser == (int)refRow["IDUser"]);
                items[4] = executor.FIO;
                items[5] = row.Status;
                ListViewItem it = new ListViewItem()
                {
                    Text = row.IDRequest.ToString()
                };
                it.SubItems.AddRange(items);
                RequestsLV.Items.Add(it);
            }
        }

        //Метод фильтрации
        private bool Filtered(RequestServicesDataSet.REQUESTSRow input)
        {
            DataRow refRow;

            //Объявляем логическую переменную в которой ID конверктируем в строку
            //и сравниваем со строкой введённой в фильтрующем элементе NumberFilterTB
            bool isNumberValid = input.IDRequest.ToString().Contains(NumberFilterTB.Text);

            //Так как приоритет в бд строковой тип, то конверктировать его не надо
            // Метод Contains можно назвать похожим на метод Like в SQL
            bool isPriorityValid = input.Priority.Contains(PriorityFilterTB.Text);

            //Получили строку оборудования по её связи
            refRow = input.GetParentRow("FK_REQUESTS_EQUIPMENTS");
            //Создали тернарную операцию, которая проверяет, выбрана ли Вся техника в списке,
            //если выбрана или выбрано ничего (""), то этот параметр пропускаем, если же нет,
            //то проверяем по параметру с другой строкой.
            bool isEquipmentValid = EquipmentFilterCB.Text == "Вся техника" || EquipmentFilterCB.Text == "" ?
                true : refRow["Title"].ToString() == EquipmentFilterCB.Text;

            //Получили строку User, по пути от строки Requests к Clients, и от Clients к Users
            refRow = input.GetParentRow("FK_REQUESTS_CLIENTS").GetParentRow("FK_CLIENTS_USERS");
            //Реализовали фильтрацию по клиенту
            bool isClientValid = ClientFilterCB.Text == "Все клиенты" || ClientFilterCB.Text == "" ?
                true : refRow["FIO"].ToString() == ClientFilterCB.Text;

            //По аналогии...
            refRow = input.GetParentRow("FK_REQUESTS_EXECUTORS").GetParentRow("FK_EXECUTORS_USERS");
            //Реализовали фильтрацию по клиенту
            bool isExecutorValid = ExecutorFilterCB.Text == "Все исполнители" || ExecutorFilterCB.Text == "" ?
                true : refRow["FIO"].ToString() == ExecutorFilterCB.Text;



            //Теперь возвращаем логическое И между несколькими значениями
            //Фактически мы говорим что, если стрка не прошла фильтр хотябы по одному параметру,
            //то её не выводит в таблицу
            return isNumberValid && isPriorityValid && isEquipmentValid && isClientValid && isExecutorValid;
        }

    }
}