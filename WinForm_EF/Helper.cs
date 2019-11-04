using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Dynamic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_EF.EF_Model;

namespace WinForm_EF
{
    internal static class Helper
    {
        public static DataBaseContext GetDataBaseContext()
        {
            var dataSource = ConfigurationManager.AppSettings["DataSource"];
            var initialCatalog = ConfigurationManager.AppSettings["InitialCatalog"];
            var userId = ConfigurationManager.AppSettings["UserId"];
            var password = ConfigurationManager.AppSettings["Password"];

            return new DataBaseContext(dataSource, initialCatalog, userId, password);
        }
        public static void InitializeGroupingDataGrid(DataGridView dgv)
        {
            var dataBaseContext = GetDataBaseContext();

            List<Shipment> initialTable;
            if (!dataBaseContext.Shipments.Any())
            {
                initialTable = Helper.InitializeTable();
                dataBaseContext.Shipments.AddRange(initialTable);
                dataBaseContext.SaveChanges();
            }
            else
            {
                initialTable = dataBaseContext.Shipments.ToList();
            }

            ShipmentToDataGridView(initialTable, dgv);
        }

        public static void DGVAddColumn(DataGridView dgv, params string[] colNames)
        {
            foreach (var colName in colNames)
            {
                dgv.Columns.Add(colName, colName);
            }
        }

        public static List<Shipment> InitializeTable()
        {
            return new List<Shipment>()
                {
                    new Shipment()
                    {
                        Id = Guid.NewGuid(),
                        Date = DateTime.Parse("01.01.10"),
                        Organization = "Восход",
                        City = "Киев",
                        Country = "Украина",
                        Manager = "Иванов",
                        Amount = 1,
                        Summ = 100.00
                    },
                    new Shipment()
                    {
                        Id = Guid.NewGuid(),
                        Date = DateTime.Parse("01.01.10"),
                        Organization = "РиК",
                        City = "Москва",
                        Country = "Россия",
                        Manager = "Иванов",
                        Amount = 2,
                        Summ = 250.00
                    },
                    new Shipment()
                    {
                        Id = Guid.NewGuid(),
                        Date = DateTime.Parse("01.01.10"),
                        Organization = "РиК",
                        City = "Москва",
                        Country = "Россия",
                        Manager = "Петров",
                        Amount = 5,
                        Summ = 450.00
                    },
                    new Shipment()
                    {
                        Id = Guid.NewGuid(),
                        Date = DateTime.Parse("02.01.10"),
                        Organization = "Восход",
                        City = "Киев",
                        Country = "Украина",
                        Manager = "Петров",
                        Amount = 7,
                        Summ = 750.00
                    },
                    new Shipment()
                    {
                        Id = Guid.NewGuid(),
                        Date = DateTime.Parse("02.01.10"),
                        Organization = "РиК",
                        City = "Москва",
                        Country = "Россия",
                        Manager = "Сидоров",
                        Amount = 10,
                        Summ = 1050.00
                    }
                };
        }

        public static void ShipmentToDataGridView(IEnumerable<Shipment> list, DataGridView tableDataGridView)
        {
            tableDataGridView.Rows.Clear();
            tableDataGridView.RowCount = list.Count();
            var i = 0;
            foreach (var item in list)
            {
                tableDataGridView["dateColumn", i].Value = item.Date.ToShortDateString();
                tableDataGridView["organizationColumn", i].Value = item.Organization;
                tableDataGridView["cityColumn", i].Value = item.City;
                tableDataGridView["countryColumn", i].Value = item.Country;
                tableDataGridView["managerColumn", i].Value = item.Manager;
                tableDataGridView["amountColumn", i].Value = item.Amount.ToString();
                tableDataGridView["summColumn", i].Value = item.Summ.ToString();
                i++;
            }
        }


        public static void SetAllColumnsVisibility(DataGridView dgv, bool visibility = true)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Visible = visibility;
            }
        }

        public static void DynamicsToDataGridView(IEnumerable list, IEnumerable<string> names, DataGridView tableDataGridView)
        {
            tableDataGridView.Rows.Clear();
            tableDataGridView.RowCount = list.Count();
            var i = 0;
            foreach (dynamic item in list)
            {
                foreach (var name in names)
                {
                    if (name == "Date")
                    {
                        tableDataGridView[$"{name.FirstCharToLower()}Column", i].Value = item.Date.ToShortDateString();
                        continue;
                    }
                    tableDataGridView[$"{name.FirstCharToLower()}Column", i].Value = item.GetType().GetProperty(name).GetValue(item, null).ToString();
                }
                i++;
            }
        }
    }
}
