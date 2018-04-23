Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.XtraScheduler
Imports DevExpress.Xpf.Scheduler
Imports System.Windows.Data
Imports System

Namespace SchedulerThemeIndependentStylesWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class DateTimeToShortDateStringConverter
		Implements IValueConverter
		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If value Is Nothing Then
				Return Nothing
			End If
			Dim dateTimeValue As DateTime = CDate(value)

			Dim param As String = If(parameter IsNot Nothing, parameter.ToString(), String.Empty)
			If param = String.Empty Then
				param = "MM/dd"
			End If

			Return dateTimeValue.ToString(param)
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		#End Region
	End Class
End Namespace
