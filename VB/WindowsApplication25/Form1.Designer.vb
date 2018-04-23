Imports Microsoft.VisualBasic
Imports System
Namespace ClockHover
	Partial Public Class FormWithGauge
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(431, 407)
			Me.gaugeControl1.TabIndex = 0
'			Me.gaugeControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnGaugeControlMouseMove);
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 419, 395)
			Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge1.Name = "Clock"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3})
			Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() { Me.arcScaleSpindleCapComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Clock
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 270F
			Me.arcScaleComponent1.MajorTickCount = 13
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -7F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Default4
			Me.arcScaleComponent1.MajorTickmark.ShowFirst = False
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 12F
			Me.arcScaleComponent1.MinorTickCount = 0
			Me.arcScaleComponent1.Name = "hours"
			Me.arcScaleComponent1.RadiusX = 98F
			Me.arcScaleComponent1.RadiusY = 98F
			Me.arcScaleComponent1.StartAngle = -90F
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleEffectLayerComponent1.Name = "glass"
			Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
			Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(196F, 98F)
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = 10F
			Me.arcScaleNeedleComponent1.Name = "hourNeedle"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleNeedleComponent2
			' 
			Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleNeedleComponent2.EndOffset = 10F
			Me.arcScaleNeedleComponent2.Name = "minuteNeedle"
			Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
			Me.arcScaleNeedleComponent2.ZOrder = -50
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent2.EndAngle = 270F
			Me.arcScaleComponent2.MajorTickCount = 13
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Diamond
			Me.arcScaleComponent2.MajorTickmark.ShowFirst = False
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 12F
			Me.arcScaleComponent2.MinorTickCount = 0
			Me.arcScaleComponent2.Name = "minutes"
			Me.arcScaleComponent2.RadiusX = 98F
			Me.arcScaleComponent2.RadiusY = 98F
			Me.arcScaleComponent2.StartAngle = -90F
			Me.arcScaleComponent2.Value = 2F
			Me.arcScaleComponent2.ZOrder = 1001
			' 
			' arcScaleNeedleComponent3
			' 
			Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
			Me.arcScaleNeedleComponent3.Name = "secondNeedle"
			Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
			Me.arcScaleNeedleComponent3.ZOrder = -50
			' 
			' arcScaleComponent3
			' 
			Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent3.EndAngle = 270F
			Me.arcScaleComponent3.MajorTickCount = 13
			Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Diamond
			Me.arcScaleComponent3.MajorTickmark.ShowFirst = False
			Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent3.MaxValue = 12F
			Me.arcScaleComponent3.MinorTickCount = 0
			Me.arcScaleComponent3.Name = "seconds"
			Me.arcScaleComponent3.RadiusX = 98F
			Me.arcScaleComponent3.RadiusY = 98F
			Me.arcScaleComponent3.StartAngle = -90F
			Me.arcScaleComponent3.Value = 4F
			Me.arcScaleComponent3.ZOrder = 1001
			' 
			' arcScaleSpindleCapComponent1
			' 
			Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleSpindleCapComponent1.Name = "cap"
			Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
			Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(20F, 20F)
			Me.arcScaleSpindleCapComponent1.ZOrder = -100
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(431, 407)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
	End Class
End Namespace

