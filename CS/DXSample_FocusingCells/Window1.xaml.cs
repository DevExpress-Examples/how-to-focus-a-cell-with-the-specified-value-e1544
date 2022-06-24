using DevExpress.Xpf.Grid;
using System.Windows;

namespace DXSample_FocusingCells {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = ProductsData.GetProducts();
        }

        void FocusCell(object sender, RoutedEventArgs e) {
            if (!double.TryParse(textBox.Text, out double textValue))
                return;
            var rowHandle = grid.FindRowByValue(grid.Columns[nameof(Product.UnitPrice)], textValue);
            if (rowHandle == DataControlBase.InvalidRowHandle) 
                return;
            grid.CurrentColumn = grid.Columns[nameof(Product.UnitPrice)];
            view.FocusedRowHandle = rowHandle;
        }
    }
}
