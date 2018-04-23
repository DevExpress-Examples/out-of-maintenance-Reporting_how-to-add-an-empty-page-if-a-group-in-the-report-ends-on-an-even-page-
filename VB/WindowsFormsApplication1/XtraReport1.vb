Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
			Groups = New SortedList()
		End Sub
		Private privateGroups As SortedList
		Public Property Groups() As SortedList
			Get
				Return privateGroups
			End Get
			Set(ByVal value As SortedList)
				privateGroups = value
			End Set
		End Property
		Private Sub xrLabel2_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel2.PrintOnPage
			Groups.Add((CType(sender, XRLabel)).Tag, e.PageIndex)
		End Sub

	End Class
End Namespace
