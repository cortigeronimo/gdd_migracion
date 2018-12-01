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

        public static int CenterWidth(int viewportWidth, int elementWidth) {
            int middle = viewportWidth / 2;
            return middle - elementWidth / 2;
        }

        public static Point CenterPosition(Point point, int elementWidth, int elementHeight) {
            Point newPoint = new Point();
            newPoint.X = point.X - elementWidth / 2;
            newPoint.Y = point.Y - elementHeight / 2;
            return newPoint;
        }

        public static Point CenterWidthAndSetHeight(int viewportWidth, int heightToSet, int elementWidth, int elementHeight)
        {
            Point point = new Point();
            point.X = CenterWidth(viewportWidth, elementWidth);
            point.Y = elementHeight + heightToSet;
            return point;
            
        }
    }
}
