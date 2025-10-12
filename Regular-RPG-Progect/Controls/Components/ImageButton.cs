using System;
using System.ComponentModel;
using System.Drawing;
using Regular_RPG_Progect.Entities.Characters;
using System.Windows.Forms;

namespace Regular_RPG_Progect.Controls.Components
{
    public class ImageButton : Control
    {
        private Image _icon;
        private Color _backgroundColor = Color.DodgerBlue;
        private Color _textColor = Color.White;
        private bool _hovered = false;
        private bool _pressed = false;

        public ImageButton()
        {
            this.Size = new Size(160, 50);
            this.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;
        }

        [Category("Data")]
        [Description("Клас гравця, який асоційований із цією кнопкою.")]
        public PlayerClass PlayerClass { get; set; }

        [Category("Appearance")]
        [Description("Іконка, яка відображається зліва.")]
        public Image Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Колір фону кнопки.")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set { _backgroundColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Колір тексту кнопки.")]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; Invalidate(); }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _hovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hovered = false;
            _pressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _pressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _pressed = false;
            Invalidate();
            //OnClick(EventArgs.Empty);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Фон
            Color fill = _backgroundColor;
            if (_pressed)
                fill = ControlPaint.Dark(fill);
            else if (_hovered)
                fill = ControlPaint.Light(fill);

            using (SolidBrush bg = new SolidBrush(fill))
                g.FillRectangle(bg, ClientRectangle);

            // Відступи
            int padding = 0;
            int iconSize = 64;

            if (_icon != null)
            {
                int iconY = (Height - iconSize) / 2;
                g.DrawImage(_icon, padding, iconY, iconSize, iconSize);
            }

            using (SolidBrush textBrush = new SolidBrush(_textColor))
            {
                var textSize = g.MeasureString(Text, Font);

                float textX = (Width - textSize.Width) / 2 + 20;
                float textY = (Height - textSize.Height) / 2;

                g.DrawString(Text, Font, textBrush, textX, textY);
            }

            using (Pen border = new Pen(Color.Gray, 1))
                g.DrawRectangle(border, 0, 0, Width - 1, Height - 1);
        }
    }
}
