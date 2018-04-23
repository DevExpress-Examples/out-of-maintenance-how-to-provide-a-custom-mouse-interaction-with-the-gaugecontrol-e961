Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive

Namespace ClockHover
	Partial Public Class FormWithGauge
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnGaugeControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gaugeControl1.MouseMove
			Dim value As Single = CalculateMouseValue(gaugeControl1, arcScaleComponent1, e)
			If value < 0 Then
				Return
			End If
			Dim nearest As Single = CSng(Math.Round(value))
			If Math.Abs(nearest - value) < 0.1f Then
				MessageBox.Show(String.Format("Time: {0:F0}h", nearest))
			End If
		End Sub
		Private Function CalculateMouseValue(ByVal container As IGaugeContainer, ByVal scale As IConvertibleScaleEx, ByVal e As MouseEventArgs) As Single
			Dim result As Single = -1
			Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
			If hi.Element IsNot Nothing Then
				Dim modelPt As PointF = MathHelper.PointToModelPoint(TryCast(scale, IElement(Of IRenderableElement)), hi.HitPoint)
				Dim percent As Single = scale.PointToPercent(modelPt)
				result = scale.PercentToValue(percent)
			End If
			Return result
		End Function
	End Class
End Namespace