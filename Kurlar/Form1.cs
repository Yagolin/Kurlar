using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Kurlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-95J6AM5;Initial Catalog=Exchange_Rate;Integrated Security=True");
        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string site = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml_doc = new XmlDocument();
            xml_doc.Load(site);

            DateTime dateTime = Convert.ToDateTime(xml_doc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            label8.Text = String.Format("Tarih {0}",dateTime.ToShortDateString());




            textBox1.Text = string.Format("USD/TRY");

            string dolar_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Unit").InnerXml;
            textBox2.Text = string.Format("{0}",dolar_unit);

            string dolar_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/Isim").InnerXml;
            textBox3.Text = string.Format("{0}", dolar_name);

            string dolar_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            textBox4.Text = string.Format("{0}", dolar_forexBuy);

            string dolar_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            textBox5.Text = string.Format("{0}", dolar_forexSell);

            string dolar_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            textBox6.Text = string.Format("{0}", dolar_banknoteBuy);

            string dolar_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            textBox7.Text = string.Format("{0}", dolar_banknoteSell);




            textBox8.Text = string.Format("EUR/TRY");

            string euro_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Unit").InnerXml;
            textBox9.Text = string.Format("{0}", euro_unit);

            string euro_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/Isim").InnerXml;
            textBox10.Text = string.Format("{0}", euro_name);

            string euro_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            textBox11.Text = string.Format("{0}", euro_forexBuy);

            string euro_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            textBox12.Text = string.Format("{0}", euro_forexSell);

            string euro_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
            textBox13.Text = string.Format("{0}", euro_banknoteBuy);

            string euro_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            textBox14.Text = string.Format("{0}", euro_banknoteSell);




            textBox15.Text = string.Format("GBP/TRY");

            string pound_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Unit").InnerXml;
            textBox16.Text = string.Format("{0}", pound_unit);

            string pound_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/Isim").InnerXml;
            textBox17.Text = string.Format("{0}", pound_name);

            string pound_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            textBox18.Text = string.Format("{0}", pound_forexBuy);

            string pound_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            textBox19.Text = string.Format("{0}", pound_forexSell);

            string pound_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteBuying").InnerXml;
            textBox20.Text = string.Format("{0}", pound_banknoteBuy);

            string pound_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            textBox21.Text = string.Format("{0}", pound_banknoteSell);




            textBox22.Text = string.Format("CAD/TRY");

            string cadolar_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/Unit").InnerXml;
            textBox23.Text = string.Format("{0}", cadolar_unit);

            string cadolar_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/Isim").InnerXml;
            textBox24.Text = string.Format("{0}", cadolar_name);

            string cadolar_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexBuying").InnerXml;
            textBox25.Text = string.Format("{0}", cadolar_forexBuy);

            string cadolar_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
            textBox26.Text = string.Format("{0}", cadolar_forexSell);

            string cadolar_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteBuying").InnerXml;
            textBox27.Text = string.Format("{0}", cadolar_banknoteBuy);

            string cadolar_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/BanknoteSelling").InnerXml;
            textBox28.Text = string.Format("{0}", cadolar_banknoteSell);




            textBox29.Text = string.Format("KWD/TRY");

            string dinar_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/Unit").InnerXml;
            textBox30.Text = string.Format("{0}", dinar_unit);

            string dinar_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/Isim").InnerXml;
            textBox31.Text = string.Format("{0}", dinar_name);

            string dinar_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexBuying").InnerXml;
            textBox32.Text = string.Format("{0}", dinar_forexBuy);

            string dinar_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexSelling").InnerXml;
            textBox33.Text = string.Format("{0}", dinar_forexSell);

            string dinar_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteBuying").InnerXml;
            textBox34.Text = string.Format("{0}", dinar_banknoteBuy);

            string dinar_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/BanknoteSelling").InnerXml;
            textBox35.Text = string.Format("{0}", dinar_banknoteSell);




            textBox36.Text = string.Format("JPY/TRY");

            string yen_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/Unit").InnerXml;
            textBox37.Text = string.Format("{0}", yen_unit);

            string yen_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/Isim").InnerXml;
            textBox38.Text = string.Format("{0}", yen_name);

            string yen_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexBuying").InnerXml;
            textBox39.Text = string.Format("{0}", yen_forexBuy);

            string yen_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            textBox40.Text = string.Format("{0}", yen_forexSell);

            string yen_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/BanknoteBuying").InnerXml;
            textBox41.Text = string.Format("{0}", yen_banknoteBuy);

            string yen_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/BanknoteSelling").InnerXml;
            textBox42.Text = string.Format("{0}", yen_banknoteSell);




            textBox43.Text = string.Format("RUB/TRY");

            string rouble_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/Unit").InnerXml;
            textBox44.Text = string.Format("{0}", rouble_unit);

            string rouble_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/Isim").InnerXml;
            textBox45.Text = string.Format("{0}", rouble_name);

            string rouble_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexBuying").InnerXml;
            textBox46.Text = string.Format("{0}", rouble_forexBuy);

            string rouble_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexSelling").InnerXml;
            textBox47.Text = string.Format("{0}", rouble_forexSell);

            string rouble_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/BanknoteBuying").InnerXml;
            textBox48.Text = string.Format("{0}", rouble_banknoteBuy);

            string rouble_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/BanknoteSelling").InnerXml;
            textBox49.Text = string.Format("{0}", rouble_banknoteSell);




            textBox50.Text = string.Format("AZN/TRY");

            string manat_unit = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/Unit").InnerXml;
            textBox51.Text = string.Format("{0}", manat_unit);

            string manat_name = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/Isim").InnerXml;
            textBox52.Text = string.Format("{0}", manat_name);

            string manat_forexBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexBuying").InnerXml;
            textBox53.Text = string.Format("{0}", manat_forexBuy);

            string manat_forexSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexSelling").InnerXml;
            textBox54.Text = string.Format("{0}", manat_forexSell);

            string manat_banknoteBuy = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/BanknoteBuying").InnerXml;
            textBox55.Text = string.Format("{0}", manat_banknoteBuy);

            string manat_banknoteSell = xml_doc.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/BanknoteSelling").InnerXml;
            textBox56.Text = string.Format("{0}", manat_banknoteSell);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();


            if (flag == 0)
            {
                SqlCommand command_1 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_1.Parameters.AddWithValue("@p1", textBox1.Text);
                command_1.Parameters.AddWithValue("@p2", textBox2.Text);
                command_1.Parameters.AddWithValue("@p3", textBox3.Text);
                command_1.Parameters.AddWithValue("@p4", textBox4.Text);
                command_1.Parameters.AddWithValue("@p5", textBox5.Text);
                command_1.Parameters.AddWithValue("@p6", textBox6.Text);
                command_1.Parameters.AddWithValue("@p7", textBox7.Text);
                command_1.ExecuteNonQuery();

                SqlCommand command_2 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_2.Parameters.AddWithValue("@p1", textBox8.Text);
                command_2.Parameters.AddWithValue("@p2", textBox9.Text);
                command_2.Parameters.AddWithValue("@p3", textBox10.Text);
                command_2.Parameters.AddWithValue("@p4", textBox11.Text);
                command_2.Parameters.AddWithValue("@p5", textBox12.Text);
                command_2.Parameters.AddWithValue("@p6", textBox13.Text);
                command_2.Parameters.AddWithValue("@p7", textBox14.Text);
                command_2.ExecuteNonQuery();

                SqlCommand command_3 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_3.Parameters.AddWithValue("@p1", textBox15.Text);
                command_3.Parameters.AddWithValue("@p2", textBox16.Text);
                command_3.Parameters.AddWithValue("@p3", textBox17.Text);
                command_3.Parameters.AddWithValue("@p4", textBox18.Text);
                command_3.Parameters.AddWithValue("@p5", textBox19.Text);
                command_3.Parameters.AddWithValue("@p6", textBox20.Text);
                command_3.Parameters.AddWithValue("@p7", textBox21.Text);
                command_3.ExecuteNonQuery();

                SqlCommand command_4 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_4.Parameters.AddWithValue("@p1", textBox22.Text);
                command_4.Parameters.AddWithValue("@p2", textBox23.Text);
                command_4.Parameters.AddWithValue("@p3", textBox24.Text);
                command_4.Parameters.AddWithValue("@p4", textBox25.Text);
                command_4.Parameters.AddWithValue("@p5", textBox26.Text);
                command_4.Parameters.AddWithValue("@p6", textBox27.Text);
                command_4.Parameters.AddWithValue("@p7", textBox28.Text);
                command_4.ExecuteNonQuery();

                SqlCommand command_5 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_5.Parameters.AddWithValue("@p1", textBox29.Text);
                command_5.Parameters.AddWithValue("@p2", textBox30.Text);
                command_5.Parameters.AddWithValue("@p3", textBox31.Text);
                command_5.Parameters.AddWithValue("@p4", textBox32.Text);
                command_5.Parameters.AddWithValue("@p5", textBox33.Text);
                command_5.Parameters.AddWithValue("@p6", textBox34.Text);
                command_5.Parameters.AddWithValue("@p7", textBox35.Text);
                command_5.ExecuteNonQuery();

                SqlCommand command_6 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_6.Parameters.AddWithValue("@p1", textBox36.Text);
                command_6.Parameters.AddWithValue("@p2", textBox37.Text);
                command_6.Parameters.AddWithValue("@p3", textBox38.Text);
                command_6.Parameters.AddWithValue("@p4", textBox39.Text);
                command_6.Parameters.AddWithValue("@p5", textBox40.Text);
                command_6.Parameters.AddWithValue("@p6", textBox41.Text);
                command_6.Parameters.AddWithValue("@p7", textBox42.Text);
                command_6.ExecuteNonQuery();

                SqlCommand command_7 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_7.Parameters.AddWithValue("@p1", textBox43.Text);
                command_7.Parameters.AddWithValue("@p2", textBox44.Text);
                command_7.Parameters.AddWithValue("@p3", textBox45.Text);
                command_7.Parameters.AddWithValue("@p4", textBox46.Text);
                command_7.Parameters.AddWithValue("@p5", textBox47.Text);
                command_7.Parameters.AddWithValue("@p6", textBox48.Text);
                command_7.Parameters.AddWithValue("@p7", textBox49.Text);
                command_7.ExecuteNonQuery();

                SqlCommand command_8 = new SqlCommand("insert into [Döviz Kurları] ([Döviz Kodu], Birim, [Döviz Cinsi], [Döviz Alış], [Döviz Satış], [Efektif Alış], [Efektif Satış]) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", connection);
                command_8.Parameters.AddWithValue("@p1", textBox50.Text);
                command_8.Parameters.AddWithValue("@p2", textBox51.Text);
                command_8.Parameters.AddWithValue("@p3", textBox52.Text);
                command_8.Parameters.AddWithValue("@p4", textBox53.Text);
                command_8.Parameters.AddWithValue("@p5", textBox54.Text);
                command_8.Parameters.AddWithValue("@p6", textBox55.Text);
                command_8.Parameters.AddWithValue("@p7", textBox56.Text);
                command_8.ExecuteNonQuery();

                flag = 1;
            }

            else
            {
                SqlCommand update_1 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7",connection);
                update_1.Parameters.AddWithValue("p1", textBox2.Text);
                update_1.Parameters.AddWithValue("p2", textBox3.Text);
                update_1.Parameters.AddWithValue("p3", textBox4.Text);
                update_1.Parameters.AddWithValue("p4", textBox5.Text);
                update_1.Parameters.AddWithValue("p5", textBox6.Text);
                update_1.Parameters.AddWithValue("p6", textBox7.Text);
                update_1.Parameters.AddWithValue("p7", textBox1.Text);
                update_1.ExecuteNonQuery();

                SqlCommand update_2 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_2.Parameters.AddWithValue("p1", textBox9.Text);
                update_2.Parameters.AddWithValue("p2", textBox10.Text);
                update_2.Parameters.AddWithValue("p3", textBox11.Text);
                update_2.Parameters.AddWithValue("p4", textBox12.Text);
                update_2.Parameters.AddWithValue("p5", textBox13.Text);
                update_2.Parameters.AddWithValue("p6", textBox14.Text);
                update_2.Parameters.AddWithValue("p7", textBox8.Text);
                update_2.ExecuteNonQuery();

                SqlCommand update_3 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_3.Parameters.AddWithValue("p1", textBox16.Text);
                update_3.Parameters.AddWithValue("p2", textBox17.Text);
                update_3.Parameters.AddWithValue("p3", textBox18.Text);
                update_3.Parameters.AddWithValue("p4", textBox19.Text);
                update_3.Parameters.AddWithValue("p5", textBox20.Text);
                update_3.Parameters.AddWithValue("p6", textBox21.Text);
                update_3.Parameters.AddWithValue("p7", textBox15.Text);
                update_3.ExecuteNonQuery();

                SqlCommand update_4 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_4.Parameters.AddWithValue("p1", textBox23.Text);
                update_4.Parameters.AddWithValue("p2", textBox24.Text);
                update_4.Parameters.AddWithValue("p3", textBox25.Text);
                update_4.Parameters.AddWithValue("p4", textBox26.Text);
                update_4.Parameters.AddWithValue("p5", textBox27.Text);
                update_4.Parameters.AddWithValue("p6", textBox28.Text);
                update_4.Parameters.AddWithValue("p7", textBox22.Text);
                update_4.ExecuteNonQuery();

                SqlCommand update_5 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_5.Parameters.AddWithValue("p1", textBox30.Text);
                update_5.Parameters.AddWithValue("p2", textBox31.Text);
                update_5.Parameters.AddWithValue("p3", textBox32.Text);
                update_5.Parameters.AddWithValue("p4", textBox33.Text);
                update_5.Parameters.AddWithValue("p5", textBox34.Text);
                update_5.Parameters.AddWithValue("p6", textBox35.Text);
                update_5.Parameters.AddWithValue("p7", textBox29.Text);
                update_5.ExecuteNonQuery();

                SqlCommand update_6 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_6.Parameters.AddWithValue("p1", textBox37.Text);
                update_6.Parameters.AddWithValue("p2", textBox38.Text);
                update_6.Parameters.AddWithValue("p3", textBox39.Text);
                update_6.Parameters.AddWithValue("p4", textBox40.Text);
                update_6.Parameters.AddWithValue("p5", textBox41.Text);
                update_6.Parameters.AddWithValue("p6", textBox42.Text);
                update_6.Parameters.AddWithValue("p7", textBox36.Text);
                update_6.ExecuteNonQuery();

                SqlCommand update_7 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_7.Parameters.AddWithValue("p1", textBox44.Text);
                update_7.Parameters.AddWithValue("p2", textBox45.Text);
                update_7.Parameters.AddWithValue("p3", textBox46.Text);
                update_7.Parameters.AddWithValue("p4", textBox47.Text);
                update_7.Parameters.AddWithValue("p5", textBox48.Text);
                update_7.Parameters.AddWithValue("p6", textBox49.Text);
                update_7.Parameters.AddWithValue("p7", textBox43.Text);
                update_7.ExecuteNonQuery();

                SqlCommand update_8 = new SqlCommand("Update [Döviz Kurları] Set Birim=@p1, [Döviz Cinsi]=@p2, [Döviz Alış]=@p3, [Döviz Satış]=@p4, [Efektif Alış]=@p5, [Efektif Satış]=@p6 where [Döviz Kodu]=@p7", connection);
                update_8.Parameters.AddWithValue("p1", textBox51.Text);
                update_8.Parameters.AddWithValue("p2", textBox52.Text);
                update_8.Parameters.AddWithValue("p3", textBox53.Text);
                update_8.Parameters.AddWithValue("p4", textBox54.Text);
                update_8.Parameters.AddWithValue("p5", textBox55.Text);
                update_8.Parameters.AddWithValue("p6", textBox56.Text);
                update_8.Parameters.AddWithValue("p7", textBox50.Text);
                update_8.ExecuteNonQuery();

            }
           

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand delete_1 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_1.Parameters.AddWithValue("@p1", textBox1.Text);
            delete_1.ExecuteNonQuery();

            SqlCommand delete_2 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_2.Parameters.AddWithValue("@p1", textBox8.Text);
            delete_2.ExecuteNonQuery();

            SqlCommand delete_3 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_3.Parameters.AddWithValue("@p1", textBox15.Text);
            delete_3.ExecuteNonQuery();

            SqlCommand delete_4 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_4.Parameters.AddWithValue("@p1", textBox22.Text);
            delete_4.ExecuteNonQuery();

            SqlCommand delete_5 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_5.Parameters.AddWithValue("@p1", textBox29.Text);
            delete_5.ExecuteNonQuery();

            SqlCommand delete_6 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_6.Parameters.AddWithValue("@p1", textBox36.Text);
            delete_6.ExecuteNonQuery();

            SqlCommand delete_7 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_7.Parameters.AddWithValue("@p1", textBox43.Text);
            delete_7.ExecuteNonQuery();

            SqlCommand delete_8 = new SqlCommand("Delete From [Döviz Kurları] Where [Döviz Kodu]=@p1", connection);
            delete_8.Parameters.AddWithValue("@p1", textBox50.Text);
            delete_8.ExecuteNonQuery();

            connection.Close();

            this.döviz_KurlarıTableAdapter.Fill(this.exchange_RateDataSet.Döviz_Kurları);

            foreach (Control txt in groupBox2.Controls)
            {
                if(txt is TextBox)
                {
                    txt.Text = "";
                }
            }

            flag = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.döviz_KurlarıTableAdapter.Fill(this.exchange_RateDataSet.Döviz_Kurları);
            
            foreach (Control txt in groupBox2.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'exchange_RateDataSet.Döviz_Kurları' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.döviz_KurlarıTableAdapter.Fill(this.exchange_RateDataSet.Döviz_Kurları);

        }
    }
}
