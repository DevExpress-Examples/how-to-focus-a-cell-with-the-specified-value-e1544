﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.Grid

Namespace DXSample_FocusingCells
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New nwindDataSetTableAdapters.ProductsTableAdapter().GetData()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If grid.VisibleRowCount = 0 Then
				Return
			End If
			Dim rowHandle As Integer = grid.View.FocusedRowHandle + 1
			Do While Convert.ToDouble(grid.GetCellValue(rowHandle, "UnitPrice")) <> 10 _
				AndAlso grid.IsValidRowHandle(rowHandle)
					rowHandle += 1
			Loop
			If grid.IsValidRowHandle(rowHandle) Then
				grid.View.FocusedColumn = grid.Columns("UnitPrice")
				grid.View.FocusedRowHandle = rowHandle
			End If
		End Sub
	End Class
End Namespace
