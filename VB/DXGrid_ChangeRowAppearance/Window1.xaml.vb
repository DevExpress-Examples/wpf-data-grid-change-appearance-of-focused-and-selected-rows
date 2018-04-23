Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Collections.Generic

Namespace DXGrid_ChangeRowAppearance
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = Products.GetData()
		End Sub
		Public Class Products
			Public Shared Function GetData() As List(Of Product)
				Dim data As New List(Of Product)()
				data.Add(New Product() With {.ProductName = "Chai", _
					.UnitPrice = 18, .UnitsOnOrder = 10})
				data.Add(New Product() With {.ProductName = "Ipoh Coffee", _
					.UnitPrice = 36.8, .UnitsOnOrder = 12})
				data.Add(New Product() With {.ProductName = "Outback Lager", _
					.UnitPrice = 12, .UnitsOnOrder = 25})
				data.Add(New Product() With {.ProductName = "Boston Crab Meat", _
					.UnitPrice = 18.4, .UnitsOnOrder = 18})
				data.Add(New Product() With {.ProductName = "Konbu", _
					.UnitPrice = 6, .UnitsOnOrder = 24})
				Return data
			End Function
		End Class
		Public Class Product
			Private privateProductName As String
			Public Property ProductName() As String
				Get
					Return privateProductName
				End Get
				Set(ByVal value As String)
					privateProductName = value
				End Set
			End Property
			Private privateUnitPrice As Double
			Public Property UnitPrice() As Double
				Get
					Return privateUnitPrice
				End Get
				Set(ByVal value As Double)
					privateUnitPrice = value
				End Set
			End Property
			Private privateUnitsOnOrder As Integer
			Public Property UnitsOnOrder() As Integer
				Get
					Return privateUnitsOnOrder
				End Get
				Set(ByVal value As Integer)
					privateUnitsOnOrder = value
				End Set
			End Property
		End Class
	End Class
End Namespace
