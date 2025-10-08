using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Controls.Components
{
    public partial class AdvancedProgressBar : UserControl
    {
        private int minValue = 0;
        private int maxValue = 100;
        private int currentValue = 0;
        private Color barColor = Color.ForestGreen;

        [Category("Behavior")]
        public int MinValue
        {
            get => minValue;
            set
            {
                minValue = value;
                Invalidate();
            }
        }

        [Category("Behavior")]
        public int MaxValue
        {
            get => maxValue;
            set
            {
                maxValue = value;
                Invalidate();
            }
        }

        [Category("Behavior")]
        public int CurrentValue
        {
            get => currentValue;
            set
            {
                currentValue = Math.Min(Math.Max(value, minValue), maxValue);
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BarColor
        {
            get => barColor;
            set
            {
                barColor = value;
                Invalidate();
            }
        }

        public AdvancedProgressBar()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var backgroundBrush = new SolidBrush(Color.LightGray))
                g.FillRectangle(backgroundBrush, 0, 0, Width, Height);

            float percent = (float)(currentValue - minValue) / (maxValue - minValue);
            int barWidth = (int)(Width * percent);

            using (var barBrush = new SolidBrush(barColor))
                g.FillRectangle(barBrush, 0, 0, barWidth, Height);
 
            using (var borderPen = new Pen(Color.Gray, 2))
                g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);

            string percentText = $"{(int)(percent * 100)}%";
            SizeF textSize = g.MeasureString(percentText, Font);
            PointF textPos = new PointF(
                (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2
            );

            using (var textBrush = new SolidBrush(Color.Black))
                g.DrawString(percentText, Font, textBrush, textPos);
        }
    }
}
