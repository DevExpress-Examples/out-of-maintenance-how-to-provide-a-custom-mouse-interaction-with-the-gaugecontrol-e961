using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;

namespace ClockHover {
    public partial class FormWithGauge : Form {
        public FormWithGauge() {
            InitializeComponent();
        }
        void OnGaugeControlMouseMove(object sender, MouseEventArgs e) {
            float value = CalculateMouseValue(gaugeControl1, arcScaleComponent1, e);
            if(value < 0) return;
            float nearest = (float)Math.Round(value);
            if(Math.Abs(nearest - value) < 0.1f) {
                MessageBox.Show(string.Format("Time: {0:F0}h", nearest));
            }
        }
        float CalculateMouseValue(IGaugeContainer container, IConvertibleScaleEx scale, MouseEventArgs e) {
            float result = -1;
            BasePrimitiveHitInfo hi = container.CalcHitInfo(e.Location);
            if(hi.Element != null) {
                PointF modelPt = MathHelper.PointToModelPoint(scale as IElement<IRenderableElement>, hi.HitPoint);
                float percent = scale.PointToPercent(modelPt);
                result = scale.PercentToValue(percent);
            }
            return result;
        }
    }
}