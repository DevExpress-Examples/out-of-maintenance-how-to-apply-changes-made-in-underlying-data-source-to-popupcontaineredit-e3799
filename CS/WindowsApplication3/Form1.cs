using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace EditValueRefresh {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        public void InitData() {
            for (int i = 0; i < 5; i++) {
                dataSet11.Tables[0].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i, imageList1.Images[i], DateTime.Today.AddDays(i), true });
                dataSet11.Tables[1].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i });
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
        }

        private void popupContainerEdit1_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
            e.Value = dataSet11.Tables[0].Rows[0]["FirstName"];
        }

        private void cmdRefreshEV_Click(object sender, EventArgs e) {
            DataRow row = dataSet11.Tables[0].Rows[0];
            row["FirstName"] += ", Add";
            popupContainerEdit1.RefreshEditValue();
        }
    }
}