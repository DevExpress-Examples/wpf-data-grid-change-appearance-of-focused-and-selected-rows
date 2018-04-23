' Developer Express Code Central Example:
' How to change the appearance of a focused data row and selected rows
' 
' This example demonstrates how to use the View's RowStyle property to apply
' custom styles to focused and selected rows. To identify whether a row is focused
' and selected, the attached IsFocusedRow and IsSelected properties are used.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2066

Imports System.Windows
Imports System.Collections.Generic

Namespace DXGrid_ChangeRowAppearance
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = Products.GetData()
        End Sub
        Public Class Products
            Public Shared Function GetData() As List(Of Product)
                Dim data As New List(Of Product)()
               data.Add(New Product() With {.ProductName = "Chai", .UnitPrice = 18, .UnitsOnOrder = 10})
                data.Add(New Product() With {.ProductName = "Ipoh Coffee", .UnitPrice = 36.8, .UnitsOnOrder = 12})
                data.Add(New Product() With {.ProductName = "Outback Lager", .UnitPrice = 12, .UnitsOnOrder = 25})
                data.Add(New Product() With {.ProductName = "Boston Crab Meat", .UnitPrice = 18.4, .UnitsOnOrder = 18})
                data.Add(New Product() With {.ProductName = "Konbu", .UnitPrice = 6, .UnitsOnOrder = 24})
                Return data
            End Function
        End Class
        Public Class Product
            Public Property ProductName() As String
            Public Property UnitPrice() As Double
            Public Property UnitsOnOrder() As Integer
        End Class
    End Class
End Namespace
