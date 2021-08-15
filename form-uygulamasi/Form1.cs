using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ZedGraph;

namespace arduinoBluetooth
{
    public partial class Form1 : Form
    {
        string alinan; //Nabız Sensöründen gelen veriler saklanır
        string ekgOku; //EKG'den gelen veriler saklanır
        bool durum = true; 

        GraphPane nabPane = new GraphPane();
        PointPairList nabLPoint = new PointPairList();
        LineItem nabLineItem;
        double zaman = 0;

        GraphPane o2Pane = new GraphPane();
        PointPairList o2LPoint = new PointPairList();
        LineItem o2LineItem;

        GraphPane sicPane = new GraphPane();
        PointPairList sicLPoint = new PointPairList();
        LineItem sicLineItem;

        GraphPane ekgPane = new GraphPane();
        PointPairList ekgLPoint = new PointPairList();
        LineItem ekgLineItem;
        double zamanEkg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //serialPort1_DataReceived fonk ile iş parçaçıkları çakışma durumunu ortadan kaldırmak için
            this.Width = 1190; //Formun Genişliği 
            this.Height = 510; //Formun Yüksekliği 

            foreach (string portlar in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(portlar); //Bilgisayarın uygun portlarını combobox yazdırır
            }
            groupBox2.Enabled = false; //Ölçüm butonları
            btnKes.Visible = false;

            nabPane = zedGraphControlN.GraphPane;    //Grafik Hazırlanıyor.
            nabPane.Title.Text = "Nabız Grafiği";
            nabPane.XAxis.Title.Text = "";
            nabPane.YAxis.Title.Text = "";
            nabPane.YAxis.Scale.Min = 0;
            nabPane.YAxis.Scale.Max = 140;
            nabLineItem = nabPane.AddCurve(null, nabLPoint, Color.Green, SymbolType.None);
            nabLineItem.Line.Width = 3;

            o2Pane = zedGraphControlO.GraphPane;    //Grafik Hazırlanıyor.
            o2Pane.Title.Text = "SpO2 Grafiği";
            o2Pane.XAxis.Title.Text = "";
            o2Pane.YAxis.Title.Text = "";
            o2Pane.YAxis.Scale.Min = 0;
            o2Pane.YAxis.Scale.Max = 140;
            o2LineItem = o2Pane.AddCurve(null, o2LPoint, Color.Blue, SymbolType.None);
            o2LineItem.Line.Width = 3;

            sicPane = zedGraphControlS.GraphPane;    //Grafik Hazırlanıyor.
            sicPane.Title.Text = "Sıcaklık Grafiği";
            sicPane.XAxis.Title.Text = "";
            sicPane.YAxis.Title.Text = "";
            sicPane.YAxis.Scale.Min = 15;
            sicPane.YAxis.Scale.Max = 45;
            sicLineItem = sicPane.AddCurve(null, sicLPoint, Color.Red, SymbolType.None);
            sicLineItem.Line.Width = 3;

            ekgPane = zedGraphControl1.GraphPane;    //Grafik Hazırlanıyor.
            ekgPane.Title.Text = "EKG Grafiği";
            ekgPane.XAxis.Title.Text = "";
            ekgPane.YAxis.Title.Text = "";
            ekgPane.YAxis.Scale.Min = 0;
            ekgPane.YAxis.Scale.Max = 1000;
            ekgLineItem = ekgPane.AddCurve(null, ekgLPoint, Color.Red, SymbolType.None);
            ekgLineItem.Line.Width = 3;

            zedGraphControl1.Visible = false; //Ekg grafiği
        }

        private void button1_Click(object sender, EventArgs e) //Bağlan butonu
        {
            try
            {
                serialPort1.PortName = comboBox1.Text; // Seçtiğimiz port ve
                serialPort1.BaudRate = 9600;           // 9600 baund hızı ile
                serialPort1.Open();                    // haberleşme başlar
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı Hatası!");
            }

            if (serialPort1.IsOpen)
            {
                groupBox2.Enabled = true; //Ölçüm butonları
                groupBox1.Enabled = false; //Bağlanma alanı
                btnKes.Visible = true;
                label2.Text = "Bluetooth Bağlantısı Sağlandı";
                label2.ForeColor = Color.Blue;
            }
        }

        private void btnKes_Click(object sender, EventArgs e) //Bağlantı Kesme butonu
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Write("1");
                serialPort1.Close();
                groupBox1.Enabled = true;
                label2.Text = "Bluetooth Bağlantısı Kesildi!";
                label2.ForeColor = Color.Black;
                btnKes.Visible = false;
                MessageBox.Show("Bağlantı Kesildi!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Write("1");
                serialPort1.Close();
            }
        } 

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (durum==true)
            {
                try
                {
                    alinan = serialPort1.ReadLine();
                    string[] ayrilcak = alinan.Split('*'); //Nabız 0, Spo2 1, Sıcaklık 2

                    zaman += 1;
                    nabLPoint.Add(new PointPair(zaman, Convert.ToInt16(ayrilcak[0].ToString())));
                    label3.Text = "Nabız: "+ayrilcak[0].ToString()+ " bpm";
                    nabPane.XAxis.Scale.Min = zaman - 3;
                    nabPane.XAxis.Scale.Max = zaman;
                    nabPane.AxisChange();
                    zedGraphControlN.Refresh();

                    o2LPoint.Add(new PointPair(zaman, Convert.ToInt16(ayrilcak[1].ToString())));
                    label4.Text ="SpO2: "+ ayrilcak[1].ToString()+ " %";
                    o2Pane.XAxis.Scale.Min = zaman - 3;
                    o2Pane.XAxis.Scale.Max = zaman;
                    o2Pane.AxisChange();
                    zedGraphControlO.Refresh();

                    sicLPoint.Add(new PointPair(zaman, Convert.ToInt16(ayrilcak[2].ToString())));
                    label5.Text ="Sıcaklık: "+ ayrilcak[2].ToString()+ " C";
                    sicPane.XAxis.Scale.Min = zaman - 3;
                    sicPane.XAxis.Scale.Max = zaman;
                    sicPane.AxisChange();
                    zedGraphControlS.Refresh();
                    
                    serialPort1.DiscardInBuffer();
                }
                catch (Exception)
                {
                    MessageBox.Show("Veri Alımı Başarısız!\nTekrar Deneyiniz.");
                }
            }
            else
            {
                try
                {
                    ekgOku = serialPort1.ReadLine();
                    if (ekgOku != null)
                    {                 
                        zamanEkg += 0.05;
                        ekgLPoint.Add(new PointPair(zamanEkg, Convert.ToInt16(ekgOku.ToString())));
                        ekgPane.XAxis.Scale.Min = zamanEkg - 3;
                        ekgPane.XAxis.Scale.Max = zamanEkg;
                        ekgPane.AxisChange();
                        zedGraphControl1.Refresh();
                        serialPort1.DiscardInBuffer();
                    }  
                }
                catch (Exception)
                {
                    //MessageBox.Show("EKG okuma hatası!");
                }
            }
        }

        private void btnEkg_Click(object sender, EventArgs e) //EKG Ölçümüne geç
        {
            if(serialPort1.IsOpen)
            {
                this.Width = 640; //Formun Genişliği 
                this.Height = 705; //Formun Yüksekliği 
                groupBox3.Visible = false; //Nabız grafikleri
                groupBox4.Visible = false; //Nabız verileri
                zedGraphControl1.Visible = true; //Ekg grafiği
                serialPort1.DiscardInBuffer();
                serialPort1.Write("2");
                durum = false;
                label2.Text = "EKG Ölçülüyor.";
                label2.ForeColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Nabız ölçümüne geç
        {
            if (serialPort1.IsOpen)
            {
                this.Width = 1190; //Formun Genişliği 
                this.Height = 510; //Formun Yüksekliği 
                groupBox3.Visible = true; //Nabız grafikleri
                groupBox4.Visible = true; //Nabız verileri
                zedGraphControl1.Visible = false; //Ekg grafiği
                serialPort1.DiscardInBuffer();
                serialPort1.Write("1");
                durum = true;
                label2.Text = "Nabız,SpO2,Sıcaklık Ölçülüyor.";
                label2.ForeColor = Color.Blue;
            }
        }

        private void projemizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu projede Arduino kullanılarak medikal sensörlerden çeşitli veriler elde edilir. Bu veriler kişinin kalp atış hızı, vücut sıcaklığı gibi özellikleri hakkındadır. Bu veriler bluetooth aracılığı ile proje için hazırlanan C# form uygulamasına gönderilir.");
        }

        private void ekibimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teşekkürler!");
        }
    }
}
