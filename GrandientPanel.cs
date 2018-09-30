using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace ClickerGameSimple
{
    class GrandientPanel: Panel
    {
        public Color ColourTop { get; set; }
        public Color ColourBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush Lgh = new LinearGradientBrush(this.ClientRectangle, this.ColourTop, this.ColourBottom,95f);
            Graphics g = e.Graphics;
            g.FillRectangle(Lgh, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
