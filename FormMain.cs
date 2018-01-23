using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxAuthenticationManager
{
    public partial class FormMain : Form
    {
        String key_ForSigned_File = "44685448679458135468791156781548";// will used in verifyin certificate on web Product key
        String key_ForUnSigned_File = "11554433998877684336521154288415";// for decrypting the file came from client.

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DES3 decrypto = new DES3();



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String xml = File.ReadAllText(openFileDialog1.FileName).Trim();

                    String decryptedText = decrypto.Decryption(xml, key_ForUnSigned_File);//"11554433998877684336521154288415");

                    StringReader sr = new StringReader(decryptedText);

                    DataSet ds = new DataSet();
                    ds.ReadXml(sr);
                    DataTable dt = ds.Tables[0];


                    textBox_Mac.Text = dt.Rows[0]["MAC"].ToString();
                    dateTimePicker_ClientGen_Date.Value = DateTime.Parse(dt.Rows[0]["systemdate"].ToString());
                    

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);

                }
            }
            else
            {
                MessageBox.Show("File Not Selected.");
            }
        }



        public string GetMacAddress2()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }
            return null;
        }


        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {


                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {

                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            if (textBox_Mac.Text.Trim() != "")
            {
                if (textBox_CompanyNameFor.Text.Trim() != "")
                {
                    saveFileDialog1.FileName = textBox_CompanyNameFor.Text + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Second+"";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        String SavePath=saveFileDialog1.FileName;
                        DES3 dec = new DES3();

                        DataTable dt = new DataTable("Signed");
                        dt.Columns.Add("MAC");
                        dt.Columns.Add("systemdate");
                        dt.Columns.Add("expdate");
                        dt.Columns.Add("signeddate");
                        dt.Columns.Add("signedvalue");
                        DataRow dr = dt.NewRow();
                        dr[0] = dec.Encryption(textBox_Mac.Text, key_ForSigned_File);
                        dr[1] = dec.Encryption(dateTimePicker_ClientGen_Date.Value.ToString(), key_ForSigned_File);
                        if (!checkBox_LifeTime.Checked)
                        {
                            dr[2] = dec.Encryption(dateTimePickerExpiryDate.Value.ToString(), key_ForSigned_File);
                        }
                        else
                        {
                            dr[2] = dec.Encryption("lifetime", key_ForSigned_File);
                        }
                        dr[3] = dec.Encryption(DateTime.Now.ToString(), key_ForSigned_File);
                        dr[4] = dec.Encryption("max signed file", key_ForSigned_File);

                        dt.Rows.Add(dr);

                        StringWriter sw = new StringWriter();
                        dt.WriteXml(sw);

                        String xml = sw.ToString();

                        DES3 Decrypto = new DES3();

                        String restult = Decrypto.Encryption(xml, key_ForSigned_File);

                        File.WriteAllText(SavePath, restult);
                        MessageBox.Show("File Generated Successfuly.");

                    }

                }
                else
                {
                    MessageBox.Show("Please provide Company name");
                }
            }
            else
            {
                MessageBox.Show("Please Load MAC");
            }
        }

        private void buttonDes3Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                DES3 D3 = new DES3();
               string result= D3.Encryption(textBoxEncryptvalue.Text, textBoxDesKey.Text);
               textBoxEncryptResult.Text = result;
                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DES3 D3 = new DES3();
                string result = D3.Decryption(textBoxDecryptValue.Text, textBoxDecryptkey.Text);
                textBoxDecryptResult.Text = result;


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {
                label_count.Text = textBoxDecryptkey.Text.Length.ToString();
            }
            catch (Exception er)
            { }
        }

        private void textBoxDesKey_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelEncryptcount.Text = textBoxDesKey.Text.Length.ToString();
            }
            catch (Exception er)
            { }
        }
    }
}
