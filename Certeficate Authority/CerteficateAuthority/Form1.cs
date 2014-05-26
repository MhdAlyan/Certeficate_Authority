using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

using System.Runtime.Serialization.Formatters.Binary;

namespace CerteficateAuthority
{
    public partial class Form1 : Form
    {
        //Variable 
        private string PK_Path;


        X509Certificate certificate;

        public Form1()
        {
            InitializeComponent();


            certificate = new X509Certificate();
        }


        private void B_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            DialogResult dr = open.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    PK_Path=open.FileName;

                    StreamReader reader = new StreamReader(PK_Path);

                    string pk = reader.ReadToEnd();

                    certificate.PublicKey =pk;

                    reader.Close();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }

        }


        // Save Certificate To file 
        private void B_GetCertificate_Click(object sender, EventArgs e)
        {

            certificate.Version = 3;

            certificate.IssurerName = TB_IssuerName.Text;

            certificate.SubjectName = TB_SubjectName.Text;

            certificate.SerialNumber = GetSerial(); // ok 


            certificate.StartDateValidate = dateTimePicker2.Value;

            certificate.EndDateValidate = dateTimePicker1.Value;

            certificate.SignatureAlgorithm = CB_SigntureAlgorthem.Text;

            // if (certificate.PublicKey != "")

                GetSignature();


            //MessageBox.Show(arr.Length.ToString());



           SaveFileDialog save = new SaveFileDialog();

           DialogResult dr = save.ShowDialog();


           BinaryFormatter bf = new BinaryFormatter();

           FileStream fs = null;


           if (dr == DialogResult.OK)
           {

               fs = new FileStream(save.FileName, FileMode.Create);

               bf.Serialize(fs, certificate);

               fs.Close();
           }
           else
           {
               MessageBox.Show("Error");
           }

        }

        private void GetSignature()
        {

             byte[] arr = certificate.ToByteArray();

              StreamReader reader = new StreamReader(@"D:\Keys\CA_pv_key");

              string private_key = reader.ReadToEnd();

               using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
               {
                    rsa.FromXmlString(private_key);

                    if (CB_SigntureAlgorthem.Text == "RSA&SH1")
                        certificate.CA_Signature = rsa.SignData(arr, new SHA1CryptoServiceProvider());
                    else if (CB_SigntureAlgorthem.Text == "RSA&MD5")
                        certificate.CA_Signature = rsa.SignData(arr, new MD5CryptoServiceProvider());
               }
                 
        }


        private byte [] GetSerial()
        {
            Random rand=new Random(DateTime.Now.Second);
            
            byte[] serial = UnicodeEncoding.UTF8.GetBytes(DateTime.Now.ToString()+ rand.Next().ToString());

            return serial;
        }



        private void newCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TB_SubjectName.Clear();

            certificate = new X509Certificate();


        }


        //Geerate Public/Private Key
        private void button1_Click(object sender, EventArgs e)
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();


            SaveFileDialog save = new SaveFileDialog();

            save.Title = "Enter the name of file for PublicKey";

            DialogResult dr = save.ShowDialog();

           

            if (dr == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);

                writer.Write(rsa.ToXmlString(false));

                writer.Flush();

                writer.Close();

            }

            save.Title = "Enter the name of file for PrivateKey";

            dr = save.ShowDialog();

            if (dr == DialogResult.OK)
            {
                StreamWriter writer1 = new StreamWriter(save.FileName);

                writer1.Write(rsa.ToXmlString(true));

                writer1.Flush();

                writer1.Close();
            }

        }


        // Verification 
        private void Verifieing_Certifiacte_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fs = null;

            OpenFileDialog open = new OpenFileDialog();

            DialogResult dr = open.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(open.FileName, FileMode.Open);

                    X509Certificate cert=(X509Certificate)bf.Deserialize(fs);


                    fs.Close();


                    StreamReader reader = new StreamReader(@"D:\Keys\CA_pu_key");

                    string CA_public_key = reader.ReadToEnd();


                    reader.Close();

                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                    {
                        rsa.FromXmlString(CA_public_key);

                        string client_PK = cert.PublicKey; // Get PK form x509Certificate

                        bool ok=false;
                        if (cert.SignatureAlgorithm == "RSA&SH1")
                            ok=rsa.VerifyData(cert.ToByteArray(), new SHA1CryptoServiceProvider(), cert.CA_Signature);
                        else if (cert.SignatureAlgorithm == "RSA&MD5")
                            ok = rsa.VerifyData(cert.ToByteArray(), new MD5CryptoServiceProvider(), cert.CA_Signature);


                        if (ok)
                        {
                            //if (cert.EndDateValidate.CompareTo(DateTime.Now))
                                ;



                        }



                        if (!ok)
                            MessageBox.Show("verification failed");
                        else
                            MessageBox.Show("verification successful ");


                        //Encrypt Message

                       /* byte[] message = UTF8Encoding.UTF8.GetBytes("Hello World");

                        rsa.FromXmlString(cert.PublicKey);

                        byte [] en_message=rsa.Encrypt(message,false);


                        open.Title = "Enter the Path of Private Key";

                        dr = open.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                            StreamReader r = new StreamReader(open.FileName);

                            rsa.FromXmlString(r.ReadToEnd());

                            r.Close();

                           MessageBox.Show(UTF8Encoding.UTF8.GetString(rsa.Decrypt(en_message, false)));

                        }
                        * 
                        * */

                       

                    }

                   
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }









        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void saveCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TB_IssuerName_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
