Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports System.Collections

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.CreateDocument(False)

			Dim addedPagesCount As Integer = 0
			Dim items As IDictionaryEnumerator = report.Groups.GetEnumerator()
			Do While items.MoveNext()
				Dim item As DictionaryEntry = CType(items.Current, DictionaryEntry)
				Dim i As Integer = Convert.ToInt32(item.Value) + addedPagesCount
				If i Mod 2 = 0 Then
					Dim emptyPage As New XtraReport2()
					emptyPage.CreateDocument(False)
					addedPagesCount += 1
					report.Pages.Insert(i+1, emptyPage.Pages(0))
				End If
			Loop


			Dim tool As New ReportPrintTool(report)
			tool.ShowPreviewDialog()

		End Sub
	End Class
End Namespace
