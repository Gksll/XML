using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    public partial class Form1 : Form
    {
        XDocument xDoc = new XDocument();

        string directory_path = System.Windows.Forms.Application.StartupPath + "//XML_Islemleri//XML";
        string file_path = System.Windows.Forms.Application.StartupPath + "//XML_Islemleri//XML//Personeller.xml";
        int xml_ID = 0;
        int id;
        public Form1()
        {
            InitializeComponent();
        }
        void DataGridView_Doldur(string path)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path);
            try
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (IndexOutOfRangeException)
            {
                lbl_bildirim.Text = "XML Dosyası boş olduğundan gösterilecek veri bulunamadı.";
            }
        }
        void Load_Or_Create_XML()
        {
            // eğer bu klasör yoksa klasörü açacak
            if (Directory.Exists(directory_path) == false)
            {
                Directory.CreateDirectory(directory_path);
            }

            // eğer bu xml dosya yoksa temel bir xml dosyası oluşturacağız.
            if (File.Exists(file_path) == false)
            {
                // verdiğimiz xml dosya yolunda xml dosya oluşturuluyor.
                FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate);

                // temel bir xml dosyası hazırlıyoruz.
                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<Personeller> "
                    + Environment.NewLine + "</Personeller>";
                fs.Flush();
                fs.Close();

                // oluşturulan xml dosyasının okunabilmesi için gerekli olan şeyleri içerisine yazdık.
                File.AppendAllText(file_path, YazilacakIcerik);

                // xml dosyasını yükledik
                xDoc = XDocument.Load(file_path);
                lbl_bildirim.Text = "XML Dosya Oluşturuldu ve Yüklendi.";
            }
            else
            {
                // zaten bir xml dosyası vardır ve onu yükledik.
                xDoc = XDocument.Load(file_path);
                lbl_bildirim.Text = "XML Dosya Yüklendi.";
            }

            // xml dosyamızdaki verileri datagirdview de  gösterdik.
            DataGridView_Doldur(file_path);
        }

        void XML_URLden_Oku()
        {
            string URLString = System.Windows.Forms.Application.StartupPath + "\\_023_XML_Islemleri\\XML\\Personeller.xml";
            XmlTextReader reader = new XmlTextReader(URLString);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:                        
                        Console.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute())                            
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        Console.Write(">"); Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:                       
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:                  
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }

            xDoc = XDocument.Load(URLString);
            DataGridView_Doldur(URLString);


        }
        private void btn_xml_dosya_olustur_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void OpenDialog()
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open XML file";
            fileOpen.Filter = "XML Files (*.xml)| *.xml";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                file_path = fileOpen.FileName;
                DataGridView_Doldur(file_path);
            }
            fileOpen.Dispose();
        }

        void XML_Veri_Ekle()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.
            XElement rootElement = xDoc.Root;

            //Yeni bir element oluşturuyoruz.
            XElement newElement = new XElement("Personel");

            //Elementimize attribute yani Id ataması yapıyoruz.
            XAttribute idAttribute = new XAttribute("id", txt_id.Text); // <Personel id="1">

            // verilerimiz
            XElement adiElement = new XElement("ad", txt_ad.Text);  // <ad>Cenk</ad>
            XElement soyadiElement = new XElement("soyad", txt_soyad.Text); // <soyad>Yiğit</soyad>
            // verilerimiz

            //Verilerimizi Personel elementimizin içine sıralı bir şekilde ekliyoruz.
            newElement.Add(idAttribute, adiElement, soyadiElement);

            //Oluşturduğumuz yeni elementi root tagının içine ekliyoruz.
            rootElement.Add(newElement);

            //Yaptığımız işlemi kayıt ediyoruz.
            xDoc.Save(file_path);

            DataGridView_Doldur(file_path);
        }
        void XML_Veri_Guncelle()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            foreach (XElement Personeller in rootElement.Elements())
            //Root Tagımız içindeki rehber Elementlerinde dönmeye başlıyoruz.
            {
                if (Personeller.Attribute("id").Value == id.ToString())
                //attributes id si 1 olan veri yakalıyoruz Xml Dosyamızda Fatih Olan kişi.
                {
                    Personeller.Element("ad").Value = txt_ad.Text;
                    Personeller.Element("soyad").Value = txt_soyad.Text;
                    //attributes id si 1 olan anıl adlı kişiyi selim yap.
                    break;
                    //Dongüden çık.
                }
            }
            xDoc.Save(file_path);
            //Yaptığımız işlemi kayıt ediyoruz.

            DataGridView_Doldur(file_path);
        }
        void XML_Veri_Sil()
        {
            // XML dosyamızı yükledik
            xDoc = XDocument.Load(file_path);

            XElement rootElement = xDoc.Root;
            //Oluşturduğumuz Root elementine XML dökümanında ki root elementini seçmesini sağlıyoruz.

            foreach (XElement Personeller in rootElement.Elements())
            //Root Tagımız içindeki rehber Elementlerinde dönmeye başlıyoruz...
            {
                if (Personeller.Attribute("id").Value == id.ToString())
                //attributes id si 2 olan elementi yakalıyoruz Xml Dosyamızda Seyfi Olan kişi...
                {
                    Personeller.Remove();
                    //attributes id si 2 olan elementi Remove metodu ile siliyoruz.
                }
            }
            xDoc.Save(file_path);
            //Yaptığımız işlemi kayıt ediyoruz.

            DataGridView_Doldur(file_path);
        }
        void Temizle()
        {
            xml_ID = 0;
            txt_id.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
        }

       

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_xml_kaydet_Click(object sender, EventArgs e)
        {


            XML_Veri_Ekle();
            Temizle();
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                id = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[2].Value);
            }
        }

        private void TSMIDelete_Click(object sender, EventArgs e)
        {
            XML_Veri_Sil();
            Temizle();
        }

        private void TSMIGuncelle_Click(object sender, EventArgs e)
        {
            XML_Veri_Guncelle();
            Temizle();
        }
    }
}
