using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarity
{
    internal class RoundShaper
    {
        private int radius = 30;
        public void RoundButton(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
