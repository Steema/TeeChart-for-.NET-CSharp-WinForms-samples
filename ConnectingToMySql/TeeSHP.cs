using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using Steema.TeeChart.Styles;

namespace ConnectingToMySql
{
  public struct SHPHeader
    {
        public int FileCode;
        public int Unused1;
        public int Unused2;
        public int Unused3;
        public int Unused4;
        public int Unused5;
        public int FileLength;
        public int Version;
        public int ShapeType;
        public double XMin;
        public double YMin;
        public double XMax;
        public double YMax;
        public double ZMin;
        public double ZMax;
        public double MMin;
        public double MMax;
    }

    public struct SHPRecordHeader
    {
        public int RecordNumber;
        public int RecordLength;
    }

  /// <summary>
  /// Summary description for TeeSHP.
  /// </summary>
  public class TeeSHP
    {
        private const int SHP_NULL = 0;
        private const int SHP_POINT = 1;
        private const int SHP_POLYLINE = 3;
        private const int SHP_POLYGON = 5;
        private const int SHP_MULTIPOINT = 8;
        private const int SHP_POINTZ = 11;
        private const int SHP_POLYLINEZ = 13;
        private const int SHP_POLYGONZ = 15;
        private const int SHP_MULTIPOINTZ = 18;
        private const int SHP_POINTM = 21;
        private const int SHP_POLYLINEM = 23;
        private const int SHP_POLYGONM = 25;
        private const int SHP_MULTIPOINTM = 28;
        private const int SHP_MULTIPATCH = 31;
        private const int SHPMaxRandom = 1000000;
       
        private Random rnd = new Random();
        private int ShapeType;
        private int po;
        private ListBox.ObjectCollection debug;

        public TeeSHP()
        {
        }

        private byte[] IntegerBytes(int Value)
        {
            byte[] result = new byte[4];
            result[0] = (byte)Value;
            result[1] = (byte)(Value >> 8);
            result[2] = (byte)(Value >> 16);
            result[3] = (byte)(Value >> 24);

            return result;
        }

        private void AddDebug(string s)
        {
            if (debug != null) debug.Add(s);
        }

        public void LoadMap(Map series, string fileName)
        {
            LoadMap(series, fileName, null, null, null, null, null);
        }

        public void LoadMap(Map series, string fileName, string filter)
        {
            LoadMap(series, fileName, null, null, null, null, filter);
        }

        /// <summary>
        /// Loads an ESRI(c) SHP file into a Map series.
        /// </summary>
        /// <param name="Series"></param>
        /// <param name="FileName"></param>
        /// <param name="Table"></param>
        /// <param name="FieldName"></param>
        /// <param name="FieldValue"></param>
        /// <param name="Debug"></param>
        public void LoadMap(Map Series, string FileName, DataTable Table, 
            string FieldName, string FieldValue, ListBox.ObjectCollection Debug,
            string filter)
        {
            debug = Debug;
            SHPHeader shpHeader = new SHPHeader();
            SHPRecordHeader shpRecordHeader = new SHPRecordHeader();

      // Verify map file name
      string tmpName = FileName; // replaceFilePath(FileName, ".shp");

            FileStream f = File.OpenRead(tmpName);

            try
            {
                if (debug != null)
                {
                    debug.Clear();
                }

                AddDebug("Real File size: " + f.Length.ToString());

                f.Position = 0;
                ReadSHPHeader(f, ref shpHeader);

                VerifySignature(shpHeader.FileCode, tmpName);

                ShowHeader(shpHeader);

                tmpName = replaceFilePath(FileName, ".shx");
                
                FileStream fx = File.OpenRead(tmpName);
                try
                {
                    fx.Position = 0;
                    ReadSHPHeader(fx, ref shpHeader);

                    VerifySignature(shpHeader.FileCode, tmpName);

                    if (debug != null)
                    {
                        AddDebug(" ");
                        AddDebug("Real File size: " + fx.Length.ToString());
                    }

                    int NumRecords = ShowHeader(shpHeader);

                    Series.Clear();
                    Series.BeginUpdate();
                    Series.Chart.AutoRepaint = false;

                    for (int i = 1; i <= NumRecords; ++i)
                    {
                        ReadRecordHeader(fx, ref shpRecordHeader);

                        if (debug != null)
                        {
                            AddDebug(" ");
                            AddDebug("Record Num: " + Convert.ToString(i) + " Offset: " + Convert.ToString(2 * shpRecordHeader.RecordNumber) +
            " Length: " + Convert.ToString(shpRecordHeader.RecordLength));
                        }

                        f.Position = 2 * shpRecordHeader.RecordNumber;
                        ReadRecordHeader(f, ref shpRecordHeader);

                        if (debug != null)
                        {
                            AddDebug("Record Num: " + Convert.ToString(shpRecordHeader.RecordNumber));
                        }

                        BinaryReader bin = new BinaryReader(f);

                        ShapeType = bin.ReadInt32();
                        LoadShape(bin, Table, Series, FieldName, FieldValue, i - 1);
                    }

                    Series.EndUpdate();
                    Series.Chart.AutoRepaint = true;
                    //Series.Chart.Invalidate();
                }
                finally
                {
                    fx.Close();
                }
            }
            finally
            {
                f.Close();
            }
        }

        private void LoadShape(BinaryReader f, DataTable Table, Map Series, string fieldName, string fieldValue, int count)
        {
            Polygon tmpShape;
            const int MaxNumParts = 10000;
            double[] Box = new double[4];
            int NumParts, NumPoints;
            int[] Parts = new int[MaxNumParts - 1];
            int p;
            string tmpText = "";
            double tmpZ = 0;

            switch (ShapeType)
            {
                case SHP_POLYLINE:
                case SHP_POLYGON:
                    Box[0] = f.ReadDouble();
                    Box[1] = f.ReadDouble();
                    Box[2] = f.ReadDouble();
                    Box[3] = f.ReadDouble();
                    NumParts = f.ReadInt32();
                    NumPoints = f.ReadInt32();

                    if (debug != null)
                        AddDebug("NumParts: " + Convert.ToString(NumParts) + " NumPoints: " + Convert.ToString(NumPoints));

                    if (NumParts > MaxNumParts) throw new Exception("Maximum number of parts exceeded: " + NumParts.ToString());

                    for (p = 0; p < NumParts; ++p)
                    {
                        Parts[p] = f.ReadInt32();
                        if (debug != null)
                            AddDebug(Convert.ToString(Parts[p]));
                    }

                    if (Table != null)
                    {
                        DataRow row = Table.Rows[count];
                        tmpText = Convert.ToString(row[fieldName]);

                        if (fieldValue != "")
                            tmpZ = Convert.ToDouble(row[fieldValue]);
                        else
                            tmpZ = rnd.NextDouble() * SHPMaxRandom;
                    }
                    else
                    {
                        tmpText = "";
                        tmpZ = rnd.NextDouble() * SHPMaxRandom;
                    }

                    po = 0;

                    for (p = 1; p <= NumParts; ++p)
                    {
                      Series.Add(0, 0, "");

                      int i = Series.Count - 1;

                      tmpShape = Series.Shapes[i];

                        if (p == NumParts) ReadPoints(f, ref tmpShape, NumPoints);
                        else ReadPoints(f, ref tmpShape, Parts[p]);

                        Series.Shapes[i].Closed = ShapeType == SHP_POLYGON;
                        Series.Shapes[i].Z = tmpZ;
                        Series.Shapes[i].Text = tmpText;

                    }
                    break;

                default:
                    throw new Exception("Invalid ShapeType " + ShapeType.ToString());
            }
        }

        private void ReadPoints(BinaryReader f, ref Polygon Shape, int UpTo)
        {
            Shape.Points.BeginUpdate();
            for (int t = 0; t < UpTo - po; ++t)
            {
                Shape.Add(f.ReadDouble(), f.ReadDouble());
            }

            po = UpTo;

            Shape.Points.EndUpdate();
        }

        private int ShowHeader(SHPHeader ASHPHeader)
        {
            byte[] B = IntegerBytes(ASHPHeader.FileLength);
            int result = B[3] + (B[2] * 256) + (B[1] * 256 * 256) + (B[0] * 256 * 256 * 256);

            if (debug != null)
            {
                AddDebug("FileCode: " + ASHPHeader.FileCode.ToString());
                AddDebug("Filelength: " + ASHPHeader.FileLength.ToString());
                AddDebug("FileSize: " + Convert.ToString(2 * result));
            }

            result = (result * 2 - 100) / 8;

            if (debug != null)
            {
                AddDebug("NumRecords: " + result.ToString());
                AddDebug("Version: " + Convert.ToString(ASHPHeader.Version));
                AddDebug("ShapeType: " + Convert.ToString(ASHPHeader.ShapeType));
                AddDebug("XMin: " + Convert.ToString(ASHPHeader.XMin));
                AddDebug("YMin: " + Convert.ToString(ASHPHeader.YMin));
                AddDebug("XMax: " + Convert.ToString(ASHPHeader.XMax));
                AddDebug("YMax: " + Convert.ToString(ASHPHeader.YMax));
                AddDebug("ZMin: " + Convert.ToString(ASHPHeader.ZMin));
                AddDebug("ZMax: " + Convert.ToString(ASHPHeader.ZMax));
                AddDebug("MMin: " + Convert.ToString(ASHPHeader.MMin));
                AddDebug("MMax: " + Convert.ToString(ASHPHeader.MMax));
            }

            return result;
        }

        private void VerifySignature(int Value, string FileName)
        {
            byte[] B = IntegerBytes(Value);
            if ((B[0] != 0) || (B[1] != 0) || (B[2] != 0x27) || ((B[3] != 0x0A) && (B[3] != 0x0D)))
                throw new Exception("Invalid file: " + FileName);
        }

        private void AddDouble(ref SHPHeader ASHPHeader, int Order, double MyDouble)
        {
            switch (Order)
            {
                case 0:
                    ASHPHeader.XMin = MyDouble;
                    break;
                case 1:
                    ASHPHeader.YMin = MyDouble;
                    break;
                case 2:
                    ASHPHeader.XMax = MyDouble;
                    break;
                case 3:
                    ASHPHeader.YMax = MyDouble;
                    break;
                case 4:
                    ASHPHeader.ZMin = MyDouble;
                    break;
                case 5:
                    ASHPHeader.ZMax = MyDouble;
                    break;
                case 6:
                    ASHPHeader.MMin = MyDouble;
                    break;
                case 7:
                    ASHPHeader.MMax = MyDouble;
                    break;
            }
        }


        private void AddInteger(ref SHPHeader ASHPHeader, int Order, int MyInt32)
        {
            switch (Order)
            {
                case 0:
                    ASHPHeader.FileCode = MyInt32;
                    break;
                case 1:
                    ASHPHeader.Unused1 = MyInt32;
                    break;
                case 2:
                    ASHPHeader.Unused2 = MyInt32;
                    break;
                case 3:
                    ASHPHeader.Unused3 = MyInt32;
                    break;
                case 4:
                    ASHPHeader.Unused4 = MyInt32;
                    break;
                case 5:
                    ASHPHeader.Unused5 = MyInt32;
                    break;
                case 6:
                    ASHPHeader.FileLength = MyInt32;
                    break;
                case 7:
                    ASHPHeader.Version = MyInt32;
                    break;
                case 8:
                    ASHPHeader.ShapeType = MyInt32;
                    break;
            }
        }


        private void AddInteger(ref SHPRecordHeader ASHPRecordHeader, int Order, int MyInt32)
        {
            switch (Order)
            {
                case 0:
                    ASHPRecordHeader.RecordNumber = MyInt32;
                    break;
                case 1:
                    ASHPRecordHeader.RecordLength = MyInt32;
                    break;
            }
        }


        private void ReadSHPHeader(Stream f, ref SHPHeader ASHPHeader)
        {
            BinaryReader bin = new BinaryReader(f);

            int myInt32;
            double myDouble;

            for (int i = 0; i < 9; ++i)
            {
                myInt32 = bin.ReadInt32();
                AddInteger(ref ASHPHeader, i, myInt32);
            }

            for (int i = 0; i < 8; ++i)
            {
                myDouble = bin.ReadDouble();
                AddDouble(ref ASHPHeader, i, myDouble);
            }
        }


        private void ReadRecordHeader(Stream f, ref SHPRecordHeader ASHPRecordHeader)
        {
            BinaryReader bin = new BinaryReader(f);

            int myInt32;

            for (int i = 0; i < 2; ++i)
            {
                myInt32 = bin.ReadInt32();
                AddInteger(ref ASHPRecordHeader, i, myInt32);
            }

            ASHPRecordHeader.RecordNumber = Reverse(ASHPRecordHeader.RecordNumber);
            ASHPRecordHeader.RecordLength = Reverse(ASHPRecordHeader.RecordLength);

        }

        private int Reverse(int Value)
        {
            byte[] B = IntegerBytes(Value);
            int result = (B[0] * 256 * 256 * 256) + (B[1] * 256 * 256) + (B[2] * 256) + B[3];
            return result;
        }

        private string replaceFilePath(string fileName, string extension)
        {
            bool exists = File.Exists(fileName);

            int i = fileName.LastIndexOf(".");

            if (i == -1)
                fileName += extension;
            else
                fileName = fileName.Substring(0, i) + extension;

            if (exists)
                return fileName;
            else
                return Application.StartupPath + @"\..\..\" + fileName;
        }
    }
}
