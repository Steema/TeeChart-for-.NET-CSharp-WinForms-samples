using System;
using System.Drawing;

namespace GDI32
{
    #region Enumerations
    public enum RasterOps
    {
        R2_BLACK = 1,
        R2_NOTMERGEPEN,
        R2_MASKNOTPEN,
        R2_NOTCOPYPEN,
        R2_MASKPENNOT,
        R2_NOT,
        R2_XORPEN,
        R2_NOTMASKPEN,
        R2_MASKPEN,
        R2_NOTXORPEN,
        R2_NOP,
        R2_MERGENOTPEN,
        R2_COPYPEN,
        R2_MERGEPENNOT,
        R2_MERGEPEN,
        R2_WHITE,
        R2_LAST
    }

    public enum BrushStyles
    {
        BS_SOLID = 0,            
        BS_NULL = 1,             
        BS_HATCHED = 2,          
        BS_PATTERN = 3,          
        BS_INDEXED = 4,          
        BS_DIBPATTERN = 5,      
        BS_DIBPATTERNPT = 6,     
        BS_PATTERN8X8 = 7,       
        BS_MONOPATTERN = 9
    }


    public enum PenStyles
    {
        PS_SOLID = 0,
        PS_DASH = 1,
        PS_DOT = 2,
        PS_DASHDOT = 3,
        PS_DASHDOTDOT = 4
    }
    #endregion

    class GDI32
    {
        #region InteropCalls
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool Ellipse(IntPtr hdc, int x1, int y1, int x2, int y2);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool Rectangle(IntPtr hdc, int X1, int Y1, int X2, int Y2);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr MoveToEx(IntPtr hdc, int x, int y, IntPtr lpPoint);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool LineTo(IntPtr hdc, int x, int y);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreatePen(PenStyles enPenStyle, int nWidth, int crColor);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreateSolidBrush(BrushStyles enBrushStyle, int crColor);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr GetStockObject(int brStyle);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern int SetROP2(IntPtr hdc, int enDrawMode);
        #endregion

        #region Variables
        protected Color borderColor;
        protected Color fillColor;
        protected int lineWidth;
        protected IntPtr hdc, oldBrush, oldPen, gdiPen, gdiBrush;
        protected BrushStyles brushStyle;
        protected PenStyles penStyle;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor for GDI32 Graphics Library
        /// </summary>
        public GDI32()
        {   // Set up for XOR drawing to begin with
            borderColor = Color.Transparent;
            fillColor = Color.White;
            lineWidth = 1;
            brushStyle = BrushStyles.BS_NULL;
            penStyle = PenStyles.PS_SOLID;
        }

        public GDI32(IntPtr aHdc) : base()
        {   // Set up for XOR drawing to begin with
            hdc = aHdc;
        }

        /// <summary>
        /// The current BrushColor
        /// </summary>
        public Color BrushColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        /// <summary>
        /// The current BrushStyle.  Set to BS_NULL for no brush.
        /// </summary>
        public BrushStyles BrushStyle
        {
            get { return brushStyle; }
            set { brushStyle = value; }
        }

        /// <summary>
        /// The current PenColor.  Set to Color.Transparent for a XOR line.
        /// </summary>
        public Color PenColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        /// <summary>
        /// The current PenStyle.
        /// </summary>
        public PenStyles PenStyle
        {
            get { return penStyle; }
            set { penStyle = value; }
        }

        /// <summary>
        /// The current PenWidth.
        /// </summary>
        public int PenWidth
        {
            get { return lineWidth; }
            set { lineWidth = value; }
        }

        protected int GetRGBFromColor(Color fromColor)
        {
            return fromColor.ToArgb() & 0xFFFFFF;
        }

        /// <summary>
        /// Draws a line with the pen that has been set by the user.  Uses gdi32->MoveToEx and gdi32->LineTo
        /// </summary>
        /// <param name="g">Graphics object.  You can use CreateGraphics().</param>
        /// <param name="p1">Initial point of line.</param>
        /// <param name="p2">Termination point of line.</param>
        public void DrawLine(Graphics g, Point p1, Point p2)
        {
            InitPenAndBrush(g);
            MoveToEx(hdc, p1.X, p1.Y, (IntPtr)null);
            LineTo(hdc, p2.X, p2.Y);
            Dispose(g);
        }

        /// <summary>
        /// Draws a rectangle with the pen and brush that have been set by the user.  Uses gdi32->Rectangle
        /// </summary>
        /// <param name="g">Graphics object.  You can use CreateGraphics().</param>
        /// <param name="p1">First corner of rectangle.</param>
        /// <param name="p2">Second corner of rectangle.</param>
        public void DrawRectangle(Graphics g, Point p1, Point p2)
        {
            InitPenAndBrush(g);
            Rectangle(hdc, p1.X, p1.Y, p2.X, p2.Y);
            Dispose(g);
        }

        /// <summary>
        /// Draws an ellipse with the pen and brush that have been set by the user.  Uses gdi32->Ellipse
        /// </summary>
        /// <param name="g">Graphics object.  You can use CreateGraphics().</param>
        /// <param name="p1">First corner of ellipse (if you imagine its size as a rectangle).</param>
        /// <param name="p2">Second corner of ellipse (if you imagine its size as a rectangle).</param>
        public void DrawEllipse(Graphics g, Point p1, Point p2)
        {
            InitPenAndBrush(g);
            Ellipse(hdc, p1.X, p1.Y, p2.X, p2.Y);
            Dispose(g);
        }

        /// <summary>
        /// Initializes the pen and brush objects.  Stores the old pen and brush so they can be recovered later.
        /// </summary>
        protected void InitPenAndBrush(Graphics g)
        {
            hdc = g.GetHdc();
            gdiPen = CreatePen(penStyle, lineWidth, GetRGBFromColor(PenColor));
            gdiBrush = CreateSolidBrush(brushStyle, GetRGBFromColor(fillColor));
            if (PenColor == Color.Transparent) SetROP2(hdc, (int)RasterOps.R2_XORPEN);
            oldPen = SelectObject(hdc, gdiPen);
            oldBrush = SelectObject(hdc, gdiBrush);
        }

        /// <summary>
        /// Reloads the old pen and brush.
        /// Deletes the pen that was created by InitPenAndBrush(g).
        /// Releases the handle to the device context and then disposes of the Graphics object.
        /// </summary>
        protected void Dispose(Graphics g)
        {
            SelectObject(hdc, oldBrush);
            SelectObject(hdc, oldPen);
            DeleteObject(gdiPen);
            DeleteObject(gdiBrush);
            g.ReleaseHdc(hdc);
            g.Dispose();
        }
        #endregion
    }
}