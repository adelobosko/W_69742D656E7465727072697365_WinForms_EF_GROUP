using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_EF.EF_Model;
using System.Configuration;
using System.Linq;
using System.Linq.Dynamic;

namespace WinForm_EF
{
    public partial class TestCSForm : Form
    {
        public TestCSForm()
        {
            InitializeComponent();
        }

        private void dateGroupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox cb))
                return;

            var dataBaseContext = Helper.GetDataBaseContext();
            var shipments = dataBaseContext.Shipments.ToList();

            var groupList = new List<string>();
            foreach (var control in groupBox.Controls)
            {
                if (!(control is CheckBox cbx)) continue;

                var columnName = cbx.Name.Replace("CheckBox", "Column");
                var column = tableDataGridView.Columns[columnName];
                if (column == null)
                    continue;

                column.Visible = cbx.Checked;

                if (!cbx.Checked)
                    continue;

                groupList.Add(cbx.Name.Replace("CheckBox", "").FirstCharToUpper());
            }

            if (!groupList.Any())
            {
                Helper.SetAllColumnsVisibility(tableDataGridView, true);
                Helper.ShipmentToDataGridView(shipments, tableDataGridView);
                return;
            }

            var keySelector = $"new({groupList.Aggregate((i,j) => $"{i},{j}")})";

            var sels = groupList.Select(s => $"Key.{s}").Aggregate((i, j) => $"{i}, {j}");
            var selector = $"new({sels}, Sum(Amount) as Amount, Sum(Summ) as Summ)";


            var query = shipments
                .GroupBy(keySelector, "new(Amount, Summ)")
                .Select(selector);

            groupList.Add("Amount");
            groupList.Add("Summ");
            Helper.DynamicsToDataGridView(query, groupList, tableDataGridView);
        }

        private void TestCSForm_Load(object sender, EventArgs e)
        {
            Helper.InitializeGroupingDataGrid(tableDataGridView);
        }
    }
}
