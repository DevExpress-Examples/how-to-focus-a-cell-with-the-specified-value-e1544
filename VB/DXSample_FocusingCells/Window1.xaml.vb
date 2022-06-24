Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace DXSample_FocusingCells

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = ProductsData.GetProducts()
        End Sub

        Private Sub FocusCell(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim textValue As Double = Nothing
            If Not Double.TryParse(Me.textBox.Text, textValue) Then Return
            Dim rowHandle = Me.grid.FindRowByValue(Me.grid.Columns(NameOf(Product.UnitPrice)), textValue)
            If rowHandle = DataControlBase.InvalidRowHandle Then Return
            Me.grid.CurrentColumn = Me.grid.Columns(NameOf(Product.UnitPrice))
            Me.view.FocusedRowHandle = rowHandle
        End Sub
    End Class
End Namespace
