Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub


	Protected Sub grid_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) OrElse (Not IsCallback) Then
			Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
			For i As Integer = 0 To grid.VisibleRowCount - 1
				If grid.IsGroupRow(i) AndAlso (grid.GetRowLevel(i) = 0) Then
					grid.ExpandRow(i)

				End If
			Next i
		End If
	End Sub
End Class

