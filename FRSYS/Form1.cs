using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.SystemUI;

namespace FRSYS
{
    public partial class Form1 : Form
    {
        public static int Flag;
        public string strMXDpath;
        public string NfrCount;
        public string PfrCount;
        public string KfrCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void DispLyrName(IFeatureLayer Lyr, IFeature ifeature)
        {
            int k = Lyr.FeatureClass.Fields.FieldCount;
        }


        private void loadMXDFile()
        {
            strMXDpath = Application.StartupPath + "\\Data\\FRMaps.MXD";
            if (axMapControl1.CheckMxFile(strMXDpath))
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerArrowHourglass;
                axMapControl1.LoadMxFile(strMXDpath);
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
                axMapControl1.Extent = axMapControl1.FullExtent;
            }
            else
            {
                MessageBox.Show(strMXDpath + "不是有效的地图文档", "地图文档打开出错");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int frmHight = this.Size.Height;
            int frmWidth = this.Size.Width;

            axTOCControl1.Height = frmHight - axToolbarControl1.Height;
            axMapControl1.Height = frmHight - axToolbarControl1.Height;
            axMapControl1.Width = frmWidth - axToolbarControl1.Width - groupBox3.Width - 30;
            groupBox3.Height = (int)(frmHight - axToolbarControl1.Height * 0.5);
            groupBox3.Left = axMapControl1.Left + axMapControl1.Width + 5;
            groupBox2.Height = groupBox3.Height - groupBox1.Height;
            BtnIDT.Left = groupBox3.Left - BtnIDT.Width - 5;

            axMapControl1.Extent = axMapControl1.FullExtent;

        }

        private IRgbColor GetRGB(int r, int g, int b)
        {
            IRgbColor pRgbColor = new RgbColorClass();
            pRgbColor.Red = r;
            pRgbColor.Green = g;
            pRgbColor.Blue = b;
            return pRgbColor;
        }

        private void addFeature(IPoint point)
        {
            IActiveView pActiveView;
            IMap pMap = axMapControl1.Map;
            pActiveView = pMap as IActiveView;
            IMarkerElement pMarkerElement;
            pMarkerElement = new MarkerElementClass();
            ISimpleMarkerSymbol pSmbol;
            pSmbol = new SimpleMarkerSymbolClass();
            pSmbol.Color = GetRGB(255, 0, 0);
            pSmbol.Size = 10;
            pSmbol.Style = esriSimpleMarkerStyle.esriSMSCircle;
            IElement pElement;
            IGraphicsContainer pGraphicsContainer;
            pGraphicsContainer = pMap as IGraphicsContainer;
            pGraphicsContainer.Reset();

            pElement = pGraphicsContainer.Next();
            while (pElement != null)
            {
                pGraphicsContainer.DeleteElement(pElement);
                pElement = pGraphicsContainer.Next();
            }

            pElement = pMarkerElement as IElement;
            pElement.Geometry = point;
            pMarkerElement.Symbol = pSmbol;
            pGraphicsContainer.AddElement(pMarkerElement as IElement, 0);
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            IPoint pPoint;
            ITopologicalOperator pTopo;
            IGeometry pGeometry;
            IFeature pFeature;
            IFeatureLayer pFeatureLayer;
            IFeatureCursor pCursor;
            ISpatialFilter pFilter;
            double length = 100;
            int LyrCount = axMapControl1.LayerCount;
            string APValue = "";
            string AKValue = "";

            if ((e.button == 1) && Flag == 1)
            {
                pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                addFeature(pPoint);
                pTopo = pPoint as ITopologicalOperator;
                pGeometry = pTopo.Buffer(length);
                pFilter = new SpatialFilterClass();
                pFilter.GeometryField = "shape";
                pFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIndexIntersects;
                pFilter.Geometry = pGeometry;
                for (int i = 0; i < LyrCount; i++)
                {
                    pFeatureLayer = axMapControl1.Map.get_Layer(i) as IFeatureLayer;
                    pCursor = pFeatureLayer.Search(pFilter, false);
                    pFeature = pCursor.NextFeature();
                    if (pFeature != null)
                    {
                        if (pFeatureLayer.Name == "landuse")
                        {
                            if (getFRFieldValue(pFeatureLayer, pFeature, "LUNAME") == "水稻")
                            { continue; }
                            else
                            {
                                dispmsg("点击处不是水稻田，请重新选择！");
                                return;
                            }
                        }
                    }
                    if (pFeatureLayer.Name == "PBaseMap")
                    {
                        APValue = getFRFieldValue(pFeatureLayer, pFeature, "AP");
                        PfrCount = frPcount(double.Parse(getFRFieldValue(pFeatureLayer, pFeature, "AP"))).ToString();
                    }

                    if (pFeatureLayer.Name == "KBaseMap")
                    {
                        AKValue = getFRFieldValue(pFeatureLayer, pFeature, "AK");
                        KfrCount = frKcount(double.Parse(getFRFieldValue(pFeatureLayer, pFeature, "AK"))).ToString();
                    }

                    frRTB.Text = "点击处坐标:\r\n X= " + e.mapX + "\r\n" + " Y= " + e.mapY + "\r\n\r\n" + "土壤速效磷含量：" + APValue + " mg/Kg" + "\r\n"
                        + "土壤速效钾含量：" + AKValue + " mg/Kg" + "\r\n\r\n"
                        + "该处施肥推荐：\r\n"
                        + "纯氮    ：" + NfrCount + " Kg/ha" + "\r\n"
                        + "五氧化二磷：" + PfrCount + " Kg/ha" + "\r\n"
                        + "氧化钾  ：" + KfrCount + " Kg/ha";
                }
            }
        }
    

        private void BtnIDT_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(frBYield.Text.Trim()) >= 3000 && Int32.Parse(frTYield.Text.Trim()) <= 5700)
            {
                Flag = 1;
                NfrCount = frNcount(Int32.Parse(frTYield.Text.Trim()), Int32.Parse(frBYield.Text.Trim())).ToString();
                axMapControl1.CurrentTool = null;
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerArrowQuestion;
            }
            else{
                dispmsg("基础产量应大于等于3000Kg/ha,目标产量应小于等于5700Kg/ha，请重新设置");
                return;
        }
    }

        private double frNcount(double tYield, double bYield)
        {
            double frN = 0;
            frN = 0.02 * (248.6 - 0.34 * bYield / 15) / 0.3 * 15;
            return frN;
        }

        private double frPcount(double pointAP)
        {
            double frP = 0;
            if (pointAP >= 30) { frP = 0; }
            else if (pointAP < 30 && pointAP >= 20) { frP = 18; }
            else if (pointAP < 20 && pointAP >= 10) { frP = 27; }
            else if (pointAP < 10 && pointAP >= 5) { frP = 36; }
            else if (pointAP < 5) { frP = 45; }
            return frP;
        }

        private double frKcount(double pointAK)
        {
            double frK = 0;
            if (pointAK >= 150) { frK = 0; }
            else if (pointAK < 150 && pointAK >= 100) { frK = 45; }
            else if (pointAK < 100 && pointAK >= 60) { frK = 45; }
            else if (pointAK < 60 && pointAK >= 30) { frK = 135; }
            else if (pointAK < 30) { frK = 180; }
            return frK;
        }

        private string getFRFieldValue(IFeatureLayer Lyr, IFeature ifeature, string frFldName)
        {
            string frFieldValue = "";
            int k = Lyr.FeatureClass.Fields.FieldCount;
            for (int i = 0; i < k; i++)
            {
                if (Lyr.FeatureClass.Fields.get_Field(i).Name == frFldName)
                {
                    frFieldValue = ifeature.get_Value(i).ToString();
                    return frFieldValue;
                }
                else
                {
                    frFieldValue = "";
                }
            }
            return frFieldValue;
        }

        private void axToolbarControl1_OnItemClick(object sender, IToolbarControlEvents_OnItemClickEvent e)
        {
            Flag = 0;
            axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadMXDFile();
        }

        private void dispmsg(String msgStr)
        {
            MessageBox.Show(msgStr);
        }

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

       
    }
}