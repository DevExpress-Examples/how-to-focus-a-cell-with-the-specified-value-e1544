Imports System
Imports System.Collections.ObjectModel

Namespace DXSample_FocusingCells

    Public Class Product

        Public Property ProductName As String

        Public Property Country As String

        Public Property City As String

        Public Property UnitPrice As Double

        Public Property Quantity As Integer

        Public Property OrderDate As Date
    End Class

    Public Class ProductsData

        Public Shared Function GetProducts() As ObservableCollection(Of Product)
            Dim products As ObservableCollection(Of Product) = New ObservableCollection(Of Product) From {New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10, .OrderDate = New DateTime(2021, 10, 23)}, New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16, .OrderDate = New DateTime(2021, 10, 22)}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12, .OrderDate = New DateTime(2021, 10, 21)}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .UnitPrice = 22, .Quantity = 50, .OrderDate = New DateTime(2021, 10, 15)}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .UnitPrice = 18, .Quantity = 20, .OrderDate = New DateTime(2021, 10, 8)}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52, .OrderDate = New DateTime(2021, 10, 1)}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120, .OrderDate = New DateTime(2021, 9, 17)}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15, .OrderDate = New DateTime(2021, 9, 25)}}
            Return products
        End Function
    End Class
End Namespace
