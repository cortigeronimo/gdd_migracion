using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PalcoNet.Utils
{
    public class ElementManager
    {

        public static Point CenterWidth(int viewportWidth, int elementWidth, int elementHeight) {
            Point ubication = new Point();
            int middle = viewportWidth / 2;
            ubication.X = middle - elementWidth / 2;
            ubication.Y = middle - elementHeight / 2;
            return ubication;
        }

        public static Point CenterPosition(Point point, int elementWidth, int elementHeight) {
            Point newPoint = new Point();
            newPoint.X = point.X - elementWidth / 2;
            newPoint.Y = point.Y - elementHeight / 2;
            return newPoint;
        }
    }
}
