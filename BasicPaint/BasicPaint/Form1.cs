using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPaint
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics gp;
        int NumberOfObject;
        Color PenColor;
        bool CheckPenColor = false;
        Color BrushColor;
        bool CheckBrushColor = false;
        bool IsStart = false;
        List<DrawObject> ListDrawObject = new List<DrawObject>();

        List<PointF> PointListPolygon = new List<PointF>();
        List<DrawObject> ListLinePolygon = new List<DrawObject>();
        PointF StartPoint;
        bool IsPolygon = false;

        bool IsStartChange = false;
        bool IsStartZoom = false;
        int HuongZoom = 0;
        PointF StartPointSpecial;
        bool MultiSelect = false;
        bool ShowDialogFlag = false;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Main_PictureBox.Width, Main_PictureBox.Height);
            gp = Graphics.FromImage(bitmap);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            NumberOfObject = 1;
            Line_Button.Focus();
        }

        private void ColorPen_Panel_Click(object sender, EventArgs e)
        {
            ShowDialogFlag = true;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                CheckPenColor = true;
                PenColor = ColorDialog.Color;
                ColorPen_Panel.BackColor = ColorDialog.Color;
            }
            ShowDialogFlag = false;
        }

        private void ColorBrush_Panel_Click(object sender, EventArgs e)
        {
            ShowDialogFlag = true;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                CheckBrushColor = true;
                BrushColor = ColorDialog.Color;
                ColorBrush_Panel.BackColor = ColorDialog.Color;
            }
            ShowDialogFlag = false;
        }
        private void Select_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 0;
        }

        private void Line_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 1;
        }

        private void Ecclipe_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 2;
        }

        private void SolidEcclipe_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 3;
        }

        private void Rectangle_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 4;
        }

        private void SolidRectangle_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 5;
        }

        private void Circle_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 6;
        }

        private void SolidCircle_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 7;
        }

        private void Polygon_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 8;
        }

        private void SolidPolygon_Button_Click(object sender, EventArgs e)
        {
            NumberOfObject = 9;
        }

        private void DeleteAll_Button_Click(object sender, EventArgs e)
        {
            ListDrawObject.Clear();
        }
        public bool KiemTraDiChuyen(PointF A, PointF B, PointF E)
        {
            float kcx = B.X - A.X;
            float kcy = B.Y - A.Y;
            if (kcx > 0)
            {
                if (kcy > 0)
                {
                    if (E.X < B.X - 2 && E.X > A.X + 2 && E.Y < B.Y - 2 && E.Y > A.Y + 2)
                    {
                        return true;
                    }
                }
                else
                {
                    if (E.X < B.X - 2 && E.X > A.X + 2 && E.Y > B.Y + 2 && E.Y < A.Y - 2)
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (kcy > 0)
                {
                    if (E.X > B.X + 2 && E.X < A.X - 2 && E.Y < B.Y - 2 && E.Y > A.Y + 2)
                    {
                        return true;
                    }
                }
                else
                {
                    if (E.X > B.X + 2 && E.X < A.X - 2 && E.Y > B.Y - 2 && E.Y < A.Y + 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int KiemTraZoom(PointF A, PointF B, PointF E)
        {
            float kcx = B.X - A.X;
            float kcy = B.Y - A.Y;
            if (kcx > 0)
            {
                if (kcy > 0)
                {
                    if (E.Y <= B.Y + 2 && E.Y >= B.Y - 2 && E.X <= B.X + 1 && E.X >= A.X - 1)
                    {
                        HuongZoom = 1;
                        return 1;
                    }
                    else
                    {
                        if (E.Y <= A.Y + 2 && E.Y >= A.Y - 2 && E.X >= A.X - 1 && E.X <= B.X + 1)
                        {
                            HuongZoom = 2;
                            return 2;
                        }
                        else
                        {
                            if (E.X <= A.X + 2 && E.X >= A.X - 2 && E.Y <= B.Y + 1 && E.Y >= A.Y - 1)
                            {
                                HuongZoom = 3;
                                return 3;
                            }
                            else
                            {
                                if (E.X <= B.X + 2 && E.X >= B.X - 2 && E.Y <= B.Y + 1 && E.Y >= A.Y - 1)
                                {
                                    HuongZoom = 4;
                                    return 4;
                                }
                            }
                        }
                    }
                }
                //else
                //{
                //    if (E.X < B.X - 1 && E.X > A.X + 1 && E.Y > B.Y + 1 && E.Y < A.Y - 1)
                //    {
                //        return true;
                //    }
                //}
            }
            //else
            //{
            //    if (kcy > 0)
            //    {
            //        if (E.X > B.X + 1 && E.X < A.X - 1 && E.Y < B.Y - 1 && E.Y > A.Y + 1)
            //        {
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        if (E.X > B.X + 1 && E.X < A.X - 1 && E.Y > B.Y - 1 && E.Y < A.Y + 1)
            //        {
            //            return true;
            //        }
            //    }
            //}
            return 0;
        }
        public void KhoiTaoOb(ref DrawObject MyObject, PointF e)
        {
            MyObject.p1 = e;
            MyObject.p2 = e;
            if (CheckPenColor == true)
            {
                MyObject.MyPenColor = PenColor;
            }
            if (CheckBrushColor == true)
            {
                MyObject.MyBrushColor = BrushColor;
            }
            MyObject.BeChosen = false;
            MyObject.MyPen = new Pen(MyObject.MyPenColor, Convert.ToInt32(Width_NumericUpDown.Value));
            if (Dash_RadioButton.Checked == true)
            {
                MyObject.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            MyObject.MyBrush = new SolidBrush(MyObject.MyBrushColor);

            MyObject.DashRectangle = new cRectangle();
            MyObject.DashRectangle.MyPen = new Pen(Color.Black, 3);
            MyObject.DashRectangle.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (NumberOfObject == 6 || NumberOfObject == 7)
            {
                float a = MyObject.p2.X - MyObject.p1.X;
                float b = MyObject.p2.Y - MyObject.p1.Y;
                double radius = Math.Sqrt((a * a) + (b * b)) / 2;

                MyObject.DashRectangle.p1 = MyObject.p1;
                MyObject.DashRectangle.p2.X = MyObject.p1.X + (float)(2 * radius);
                MyObject.DashRectangle.p2.Y = MyObject.p1.Y + (float)(2 * radius);
            }
            else
            {
                MyObject.DashRectangle.p1 = MyObject.p1;
                MyObject.DashRectangle.p2 = MyObject.p2;
            }
            this.ListDrawObject.Add(MyObject);
        }
        public void InitializeComponentOfPolygon(PointF e)
        {
            if (IsPolygon == false)
            {
                IsPolygon = true;
                StartPoint = e;
                DrawObject MyObject = new cLine();
                MyObject.p1 = e;
                MyObject.p2 = e;
                if (CheckPenColor == true)
                {
                    MyObject.MyPenColor = PenColor;
                }
                MyObject.MyPen = new Pen(MyObject.MyPenColor, Convert.ToUInt32(Width_NumericUpDown.Value));
                if (Dash_RadioButton.Checked == true)
                {
                    MyObject.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }
                this.ListLinePolygon.Add(MyObject);
                PointListPolygon.Add(e);
            }
            else
            {
                ListLinePolygon[ListLinePolygon.Count - 1].p2 = e;
                Main_PictureBox.Refresh();
                DrawObject MyObject = new cLine();
                MyObject.p1 = e;
                MyObject.p2 = e;
                if (CheckPenColor == true)
                {
                    MyObject.MyPenColor = PenColor;
                }
                MyObject.MyPen = new Pen(MyObject.MyPenColor, Convert.ToUInt32(Width_NumericUpDown.Value));
                if (Dash_RadioButton.Checked == true)
                {
                    MyObject.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }
                this.ListLinePolygon.Add(MyObject);
                PointListPolygon.Add(e);
            }
        }
        public void InitializePolygonOb(ref DrawObject MyObject, PointF e)
        {
            this.ListLinePolygon[this.ListLinePolygon.Count - 1].p2 = this.ListLinePolygon[0].p1;
            this.Main_PictureBox.Refresh();

            MyObject.BeChosen = false;
            MyObject.PointArray = PointListPolygon.ToArray();
            if (CheckPenColor == true)
            {
                MyObject.MyPenColor = PenColor;
            }
            if (CheckBrushColor == true)
            {
                MyObject.MyBrushColor = BrushColor;
            }
            MyObject.MyPen = new Pen(MyObject.MyPenColor, Convert.ToUInt32(Width_NumericUpDown.Value));
            if (Dash_RadioButton.Checked == true)
            {
                MyObject.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            MyObject.MyBrush = new SolidBrush(MyObject.MyBrushColor);
            XacDinhLaiViTriPolygon(ref MyObject);
            this.ListDrawObject.Add(MyObject);

            MyObject.DashRectangle = new cRectangle();
            MyObject.DashRectangle.MyPen = new Pen(Color.Black, 3);
            MyObject.DashRectangle.MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            MyObject.DashRectangle.p1 = MyObject.p1;
            MyObject.DashRectangle.p2 = MyObject.p2;

            PointListPolygon.Clear();
            ListLinePolygon.Clear();
            IsPolygon = false;
        }
        public void XacDinhLaiViTri(ref DrawObject Ob, PointF Po)
        {
            float kcx = Po.X - StartPointSpecial.X;
            float kcy = Po.Y - StartPointSpecial.Y;

            if (Ob.PointArray != null)
            {
                for (int i = 0; i < Ob.PointArray.Length; i++)
                {
                    Ob.PointArray[i].X += kcx;
                    Ob.PointArray[i].Y += kcy;
                }
            }
            Ob.p1.X += kcx;
            Ob.p1.Y += kcy;
            Ob.p2.X += kcx;
            Ob.p2.Y += kcy;
            if (MultiSelect == false)
            {
                StartPointSpecial = Po;
            }
        }
        public void Zoom(ref PointF A, PointF Po)
        {
            float kcx = Po.X - StartPointSpecial.X;
            float kcy = Po.Y - StartPointSpecial.Y;
            A.X += kcx;
            A.Y += kcy;
            if (MultiSelect == false)
            {
                StartPointSpecial = Po;
            }
        }
        public void ZoomPolygon(ref DrawObject Ob, PointF Po)
        {
            float kcx = Po.X - StartPointSpecial.X;
            float kcy = Po.Y - StartPointSpecial.Y;
            switch (HuongZoom)
            {
                case 1:
                    {
                        for (int i = 0; i < Ob.PointArray.Length; i++)
                        {
                            if (Ob.PointArray[i].Y != Ob.MostAbove.Y)
                            {
                                Ob.PointArray[i].X += kcx;
                                Ob.PointArray[i].Y += kcy;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < Ob.PointArray.Length; i++)
                        {
                            if (Ob.PointArray[i].Y != Ob.MostBelow.Y)
                            {
                                Ob.PointArray[i].X += kcx;
                                Ob.PointArray[i].Y += kcy;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < Ob.PointArray.Length; i++)
                        {
                            if (Ob.PointArray[i].X != Ob.MostRight.X)
                            {
                                Ob.PointArray[i].X += kcx;
                                Ob.PointArray[i].Y += kcy;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < Ob.PointArray.Length; i++)
                        {
                            if (Ob.PointArray[i].X != Ob.MostLeft.X)
                            {
                                Ob.PointArray[i].X += kcx;
                                Ob.PointArray[i].Y += kcy;
                            }
                        }
                        break;
                    }
            }
            if (MultiSelect == false)
            {
                StartPointSpecial = Po;
            }
        }
        public void XacDinhLaiViTriPolygon(ref DrawObject A)
        {
            PointF MinX = A.PointArray[0];
            PointF MaxX = A.PointArray[0];
            PointF MinY = A.PointArray[0];
            PointF MaxY = A.PointArray[0];
            PointF MaxAbove = A.PointArray[0];
            PointF MaxLeft = A.PointArray[0];
            PointF MaxRight = A.PointArray[0];
            PointF MaxBelow = A.PointArray[0];
            for (int i = 0; i < A.PointArray.Length; i++)
            {
                if (A.PointArray[i].X < MinX.X)
                {
                    MinX = A.PointArray[i];
                }
                if (A.PointArray[i].X > MaxX.X)
                {
                    MaxX = A.PointArray[i];
                }
                if (A.PointArray[i].Y < MinY.Y)
                {
                    MinY = A.PointArray[i];
                }
                if (A.PointArray[i].Y > MaxY.Y)
                {
                    MaxY = A.PointArray[i];
                }
                if (A.PointArray[i].Y < MaxAbove.Y)
                {
                    MaxAbove = A.PointArray[i];
                }
                if (A.PointArray[i].Y > MaxBelow.Y)
                {
                    MaxBelow = A.PointArray[i];
                }
                if (A.PointArray[i].X < MaxLeft.X)
                {
                    MaxLeft = A.PointArray[i];
                }
                if (A.PointArray[i].X > MaxRight.X)
                {
                    MaxRight = A.PointArray[i];
                }
            }
            A.p1.X = MinX.X;
            A.p1.Y = MinY.Y;
            A.p2.X = MaxX.X;
            A.p2.Y = MaxY.Y;

            A.MostAbove = MaxAbove;
            A.MostBelow = MaxBelow;
            A.MostLeft = MaxLeft;
            A.MostRight = MaxRight;
        }
        public void XacDinhLaiViTriPolygonSpecial(ref DrawObject A)
        {
            PointF MinX = A.PointArray[0];
            PointF MaxX = A.PointArray[0];
            PointF MinY = A.PointArray[0];
            PointF MaxY = A.PointArray[0];
            for (int i = 0; i < A.PointArray.Length; i++)
            {
                if (A.PointArray[i].X < MinX.X)
                {
                    MinX = A.PointArray[i];
                }
                if (A.PointArray[i].X > MaxX.X)
                {
                    MaxX = A.PointArray[i];
                }
                if (A.PointArray[i].Y < MinY.Y)
                {
                    MinY = A.PointArray[i];
                }
                if (A.PointArray[i].Y > MaxY.Y)
                {
                    MaxY = A.PointArray[i];
                }
            }
            A.p1.X = MinX.X;
            A.p1.Y = MinY.Y;
            A.p2.X = MaxX.X;
            A.p2.Y = MaxY.Y;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (NumberOfObject == 0)
            {
                if (e.Control)
                {
                    MultiSelect = true;
                }
                if (e.KeyCode == Keys.Delete)
                {
                    bool XoaHet;
                    do
                    {
                        XoaHet = true;
                        for (int i = 0; i < ListDrawObject.Count; i++)
                        {
                            if (ListDrawObject[i].BeChosen == true)
                            {
                                XoaHet = false;
                                ListDrawObject.Remove(ListDrawObject[i]);
                            }
                        }
                    } while (XoaHet != true);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 17)
            {
                MultiSelect = false; 
            }
        }
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ungroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Main_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (NumberOfObject == 0)
                {
                    bool Exist = false;
                    for (int i = 0; i < ListDrawObject.Count; i++)
                    {
                        if (KiemTraDiChuyen(ListDrawObject[i].p1, ListDrawObject[i].p2, e.Location) == true)
                        {
                            if (MultiSelect == false)
                            {
                                for (int j = 0; j < ListDrawObject.Count; j++)
                                {
                                    ListDrawObject[j].BeChosen = false;
                                }
                            }
                            Exist = true;
                            ListDrawObject[i].BeChosen = true;
                            IsStartChange = true;
                            StartPointSpecial = e.Location;
                            break;
                        }
                        else
                        {
                            if (ListDrawObject[i].BeChosen == true && KiemTraZoom(ListDrawObject[i].p1, ListDrawObject[i].p2, e.Location) != 0)
                            {
                                StartPointSpecial = e.Location;
                                Exist = true;
                                IsStartZoom = true;
                            }
                        }
                    }
                    if (Exist == false)
                    {
                        for (int i = 0; i < ListDrawObject.Count; i++)
                        {
                            if (ListDrawObject[i].BeChosen == true)
                            {
                                ListDrawObject[i].BeChosen = false;
                            }
                        }
                        HuongZoom = 0;
                        MultiSelect = false;
                    }
                }
                else
                {
                    this.IsStart = true;
                    switch (NumberOfObject)
                    {
                        case 1:
                            {
                                DrawObject MyObject = new cLine();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }
                        case 2:
                            {
                                DrawObject MyObject = new cEcclipe();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }

                        case 3:
                            {
                                DrawObject MyObject = new cSolidEcclipe();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }

                        case 4:
                            {
                                DrawObject MyObject = new cRectangle();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }
                        case 5:
                            {
                                DrawObject MyObject = new cSolidRectangle();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }
                        case 6:
                            {
                                DrawObject MyObject = new cCircle();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }
                        case 7:
                            {
                                DrawObject MyObject = new cSolidCircle();
                                KhoiTaoOb(ref MyObject, e.Location);
                                break;
                            }
                        case 8:
                            {
                                InitializeComponentOfPolygon(e.Location);
                                break;
                            }
                        case 9:
                            {
                                InitializeComponentOfPolygon(e.Location);
                                break;
                            }
                    }
                }
            }
            else
            {
                if (NumberOfObject == 0)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        for (int i = 0; i < ListDrawObject.Count; i++)
                        {
                            if (KiemTraDiChuyen(ListDrawObject[i].p1, ListDrawObject[i].p2, e.Location) == true)
                            {
                                int Temp = 0;
                                for (int j = 0; j < ListDrawObject.Count; j++)
                                {
                                    if (ListDrawObject[j].BeChosen == true)
                                    {
                                        Temp++;
                                    }
                                }
                                if (Temp > 1)
                                {
                                    groupToolStripMenuItem.Enabled = true;
                                }
                                else
                                {
                                    groupToolStripMenuItem.Enabled = false;
                                }
                                if (ListDrawObject[i].ListGroup != null)
                                {
                                    ungroupToolStripMenuItem.Enabled = true;
                                }
                                else
                                {
                                    ungroupToolStripMenuItem.Enabled = false;
                                }
                                Group_ContextMenuStrip.Show(Cursor.Position);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void Main_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.IsStart == true)
            {
                switch (NumberOfObject)
                {
                    case 1:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }
                    case 2:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }

                    case 3:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }

                    case 4:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }
                    case 5:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }
                    case 6:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }
                    case 7:
                        {
                            this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                            break;
                        }
                }
            }
            if (NumberOfObject == 8 || NumberOfObject == 9)
            {
                if (this.ListLinePolygon.Count >= 1)
                {
                    this.ListLinePolygon[this.ListLinePolygon.Count - 1].p2 = e.Location;
                }
            }
            if (NumberOfObject == 0 && IsStartChange == true)
            {
                for (int i = 0; i < ListDrawObject.Count; i++)
                {
                    if (ListDrawObject[i].BeChosen == true)
                    {
                        DrawObject Temp = ListDrawObject[i];
                        XacDinhLaiViTri(ref Temp, e.Location);
                        Temp.DashRectangle.p1 = Temp.p1;
                        Temp.DashRectangle.p2 = Temp.p2;
                        ListDrawObject[i] = Temp;
                    }
                }
                StartPointSpecial = e.Location;
            }
            else
            {
                if (NumberOfObject == 0 && IsStartZoom == true)
                {
                    for (int i = 0; i < ListDrawObject.Count; i++)
                    {
                        if (ListDrawObject[i].BeChosen == true)
                        {
                            if (ListDrawObject[i].PointArray != null)
                            {
                                DrawObject Temp = ListDrawObject[i];
                                ZoomPolygon(ref Temp, e.Location);
                                XacDinhLaiViTriPolygonSpecial(ref Temp);
                                Temp.DashRectangle.p1 = Temp.p1;
                                Temp.DashRectangle.p2 = Temp.p2;
                                ListDrawObject[i] = Temp;
                            }
                            else
                            {
                                if (HuongZoom == 1)
                                {
                                    Zoom(ref ListDrawObject[i].p2, e.Location);
                                    ListDrawObject[i].DashRectangle.p2 = ListDrawObject[i].p2;
                                }
                                else
                                {
                                    if (HuongZoom == 2)
                                    {
                                        Zoom(ref ListDrawObject[i].p1, e.Location);
                                        ListDrawObject[i].DashRectangle.p1 = ListDrawObject[i].p1;
                                    }
                                    else
                                    {
                                        if (HuongZoom == 3)
                                        {
                                            Zoom(ref ListDrawObject[i].p1, e.Location);
                                            ListDrawObject[i].DashRectangle.p1 = ListDrawObject[i].p1;
                                        }
                                        else
                                        {
                                            if (HuongZoom == 4)
                                            {
                                                Zoom(ref ListDrawObject[i].p2, e.Location);
                                                ListDrawObject[i].DashRectangle.p2 = ListDrawObject[i].p2;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    StartPointSpecial = e.Location;
                }
            }
            this.Main_PictureBox.Refresh();
        }

        private void Main_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsStart == true)
            {
                if (this.IsPolygon == true)
                {
                    if (this.ListLinePolygon.Count > 1)
                    {
                        switch (NumberOfObject)
                        {
                            case 8:
                                {
                                    if (e.Location.X <= StartPoint.X + 5 && e.Location.X >= StartPoint.X - 5 && e.Location.Y <= StartPoint.Y + 5 && e.Location.Y >= StartPoint.Y - 5)
                                    {
                                        DrawObject MyObject = new cPolygon();
                                        InitializePolygonOb(ref MyObject, e.Location);
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    if (e.Location.X <= StartPoint.X + 5 && e.Location.X >= StartPoint.X - 5 && e.Location.Y <= StartPoint.Y + 5 && e.Location.Y >= StartPoint.Y - 5)
                                    {
                                        DrawObject MyObject = new cSolidPolygon();
                                        InitializePolygonOb(ref MyObject, e.Location);
                                    }
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    this.ListDrawObject[this.ListDrawObject.Count - 1].p2 = e.Location;
                }
                this.IsStart = false;
                return;
            }
            if (NumberOfObject == 0 && IsStartChange == true)
            {
                for (int i = 0; i < ListDrawObject.Count; i++)
                {
                    if (ListDrawObject[i].BeChosen == true)
                    {
                        DrawObject Temp = ListDrawObject[i];
                        XacDinhLaiViTri(ref Temp, e.Location);
                        Temp.DashRectangle.p1 = Temp.p1;
                        Temp.DashRectangle.p2 = Temp.p2;
                        ListDrawObject[i] = Temp;
                    }
                }
                StartPointSpecial = e.Location;
                IsStartChange = false;
            }
            else
            {
                if (NumberOfObject == 0 && IsStartZoom == true)
                {
                    for (int i = 0; i < ListDrawObject.Count; i++)
                    {
                        if (ListDrawObject[i].PointArray != null)
                        {
                            DrawObject Temp = ListDrawObject[i];
                            ZoomPolygon(ref Temp, e.Location);
                            XacDinhLaiViTriPolygon(ref Temp);
                            Temp.DashRectangle.p1 = Temp.p1;
                            Temp.DashRectangle.p2 = Temp.p2;
                            ListDrawObject[i] = Temp;
                        }
                        else
                        {
                            if (ListDrawObject[i].BeChosen == true)
                            {
                                if (HuongZoom == 1)
                                {
                                    Zoom(ref ListDrawObject[i].p2, e.Location);
                                    ListDrawObject[i].DashRectangle.p2 = ListDrawObject[i].p2;
                                }
                                else
                                {
                                    if (HuongZoom == 2)
                                    {
                                        Zoom(ref ListDrawObject[i].p1, e.Location);
                                        ListDrawObject[i].DashRectangle.p1 = ListDrawObject[i].p1;
                                    }
                                    else
                                    {
                                        if (HuongZoom == 3)
                                        {
                                            Zoom(ref ListDrawObject[i].p1, e.Location);
                                            ListDrawObject[i].DashRectangle.p1 = ListDrawObject[i].p1;
                                        }
                                        else
                                        {
                                            if (HuongZoom == 4)
                                            {
                                                Zoom(ref ListDrawObject[i].p2, e.Location);
                                                ListDrawObject[i].DashRectangle.p2 = ListDrawObject[i].p2;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    StartPointSpecial = e.Location;
                    IsStartZoom = false;
                }
            }
            this.Main_PictureBox.Refresh();
        }

        private void Main_PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (!ShowDialogFlag)
            {
                gp.Clear(Color.White);
                for (int i = 0; i < this.ListDrawObject.Count; i++)
                {
                    ListDrawObject[i].Draw(gp, ListDrawObject[i].MyPen);
                    ListDrawObject[i].Fill(gp, ListDrawObject[i].MyBrush);
                    if (this.ListDrawObject[i].BeChosen == true)
                    {
                        this.ListDrawObject[i].DashRectangle.Draw(gp, ListDrawObject[i].DashRectangle.MyPen);
                    }
                }
                if (IsPolygon == true)
                {
                    for (int i = 0; i < this.ListLinePolygon.Count; i++)
                    {
                        ListLinePolygon[i].Draw(gp, ListLinePolygon[i].MyPen);
                    }
                }
                Main_PictureBox.Image = bitmap;
            }
        }
        public abstract class DrawObject
        {
            public PointF p1;
            public PointF p2;
            public PointF MostAbove;
            public PointF MostBelow;
            public PointF MostLeft;
            public PointF MostRight;
            public PointF[] PointArray;
            public List<DrawObject> ListGroup;
            public cRectangle DashRectangle;
            public Color MyPenColor = Color.Black;
            public Color MyBrushColor = Color.Black;
            public Pen MyPen;
            public Brush MyBrush;
            public bool BeChosen;
            public abstract void Draw(Graphics gp, Pen MyPen);
            public abstract void Fill(Graphics gp, Brush MyBrush);
        }
        public class cLine : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                gp.DrawLine(MyPen, this.p1, this.p2);
            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {

            }
        }
        public class cRectangle : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                gp.DrawRectangle(MyPen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {

            }
        }
        public class cEcclipe : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                gp.DrawEllipse(MyPen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {

            }
        }

        public class cSolidEcclipe : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {

            }
            public override void Fill(Graphics gp, Brush myBrush)
            {
                gp.FillEllipse(myBrush, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }

        }

        public class cSolidRectangle : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {

            }
            public override void Fill(Graphics gp, Brush myBrush)
            {
                gp.FillRectangle(myBrush, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
            }
        }
        public class cCircle : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                float a = p2.X - p1.X;
                float b = p2.Y - p1.Y;
                double radius = Math.Sqrt((a * a) + (b * b)) / 2;
                gp.DrawEllipse(MyPen, p1.X, p1.Y, (float)(2 * radius), (float)(2 * radius));

            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {

            }
        }
        public class cSolidCircle : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {

            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {
                float a = p2.X - p1.X;
                float b = p2.Y - p1.Y;
                double radius = Math.Sqrt((a * a) + (b * b)) / 2;
                gp.FillEllipse(MyBrush, p1.X, p1.Y, (float)(2 * radius), (float)(2 * radius));
            }
        }
        public class cPolygon : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                gp.DrawPolygon(MyPen, PointArray);
            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {

            }
        }
        public class cSolidPolygon : DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {

            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {
                gp.FillPolygon(MyBrush, this.PointArray);
            }
        }
        public class cGroupObject: DrawObject
        {
            public override void Draw(Graphics gp, Pen MyPen)
            {
                
            }
            public override void Fill(Graphics gp, Brush MyBrush)
            {
               
            }
        }
    }
}
