Imports System.Windows
Imports System.Collections.Generic

Namespace DXGrid_ChangeRowAppearance

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = Products.GetData()
        End Sub

        Public Class Products

            Public Shared Function GetData() As List(Of Product)
                Dim data As List(Of Product) = New List(Of Product)()
                data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
                data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12})
                data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25})
                data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18})
                data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24})
                Return data
            End Function
        End Class

        Public Class Product

            Public Property ProductName As String

            Public Property UnitPrice As Double

            Public Property UnitsOnOrder As Integer
        End Class
    End Class
End Namespace
