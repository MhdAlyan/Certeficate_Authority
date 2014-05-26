using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CerteficateAuthority
{   

    [Serializable] 
    public class X509Certificate
    {
        private int _version;

        private string _IssurerName;

        private string _SubjectName;

        private byte []  _SerialNumber;

        private DateTime _StartDateValidate;

        private DateTime _EndDateValidate;

        private string _publicKey;

        private string _SignatureAlgorithm;

        private byte[] _CA_Signature;



        #region Properties

        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public string IssurerName
        {
            get { return _IssurerName; }
            set { _IssurerName = value; }
        }

        public string SubjectName
        {
            get { return _SubjectName; }
            set { _SubjectName = value; }
        }

        public byte []  SerialNumber
        {
            get { return _SerialNumber; }
            set { _SerialNumber = value; }
        }

        public DateTime StartDateValidate
        {
            get { return _StartDateValidate; }
            set { _StartDateValidate = value; }
        }

        public DateTime EndDateValidate
        {
            get { return _EndDateValidate; }
            set { _EndDateValidate = value; }
        }

        public string PublicKey
        {
            get { return _publicKey; }
            set { _publicKey = value; }
        }  

        public byte[] CA_Signature
        {
            get { return _CA_Signature; }
            set { _CA_Signature = value; }
        }

        public string SignatureAlgorithm
        {
            get { return _SignatureAlgorithm; }
            set { _SignatureAlgorithm = value; }
        }

        #endregion Properties


        public X509Certificate()
        {
        }


        public  byte [] ToByteArray()
        {
            

            byte[] IssurerName_bytes = UTF8Encoding.UTF8.GetBytes(_IssurerName); // BitConverter.GetBytes(_SubjectName) ;

            byte[] SubjectName_bytes = UTF8Encoding.UTF8.GetBytes(_SubjectName);

            byte[] publicKey_bytes = UTF8Encoding.UTF8.GetBytes(_publicKey);

            byte[] StartDate_bytes = UTF8Encoding.UTF8.GetBytes(_StartDateValidate.ToString());


            byte[] EndDate_bytes = UTF8Encoding.UTF8.GetBytes(_EndDateValidate.ToString());

            byte[] version_bytes = BitConverter.GetBytes(_version);

            byte[] _SignatureAlgorithm_bytes = UTF8Encoding.UTF8.GetBytes(_SignatureAlgorithm.ToString());

            int size = IssurerName_bytes.Length + SubjectName_bytes.Length + publicKey_bytes.Length + StartDate_bytes.Length
                + EndDate_bytes.Length + version_bytes.Length + _SignatureAlgorithm_bytes.Length;

            byte[] dest = new byte[size];


            Array.Copy(IssurerName_bytes, dest, IssurerName_bytes.Length); //1


            Array.Copy(SubjectName_bytes, dest, SubjectName_bytes.Length); //2

            // SN

            Array.Copy(publicKey_bytes, dest, publicKey_bytes.Length);//3


            Array.Copy(_SerialNumber, dest, _SerialNumber.Length);//4


            Array.Copy(StartDate_bytes, dest, StartDate_bytes.Length);//5

            Array.Copy(EndDate_bytes, dest, EndDate_bytes.Length);//6 


            Array.Copy(version_bytes, dest, version_bytes.Length);//7

           
            return dest;
        }




    }
}
