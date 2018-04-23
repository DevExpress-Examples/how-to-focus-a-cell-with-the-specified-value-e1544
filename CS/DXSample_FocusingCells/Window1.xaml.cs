using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Wpf.Grid;

namespace DXSample_FocusingCells {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = new nwindDataSetTableAdapters.ProductsTableAdapter().GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (grid.VisibleRowCount == 0) return;
            int rowHandle = grid.View.FocusedRowHandle + 1;
            while (Convert.ToDouble(grid.GetCellValue(rowHandle, "UnitPrice")) != 10 && 
                grid.IsValidRowHandle(rowHandle)) {
                    rowHandle++;
            }
            if (grid.IsValidRowHandle(rowHandle)) {
                grid.View.FocusedColumn = grid.Columns["UnitPrice"];
                grid.View.FocusedRowHandle = rowHandle;
            }
        }
    }
}
