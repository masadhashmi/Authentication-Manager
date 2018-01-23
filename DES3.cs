using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaxAuthenticationManager
{
    public class DES3
    {
        

        

        public DES3()
        {

        }
        public String Encryption(string PlainText, string key)
        {
            TripleDES des = CreateDES(key);
            des.Mode = CipherMode.CBC;
            ICryptoTransform ct = des.CreateEncryptor();
            byte[] input = Encoding.Unicode.GetBytes(PlainText);
            return BitConverter.ToString(ct.TransformFinalBlock(input, 0, input.Length)).Replace("-", "");

            //return Convert.ToBase64String(ct.TransformFinalBlock(input, 0, input.Length));
        }
        public string Decryption(string CypherText, string key)
        {

            byte[] b = StringToByteArray(CypherText); //BitConverter.GetBytes(CypherText);//Convert.FromBase64String(CypherText);
            TripleDES des = CreateDES(key);
            des.Mode = CipherMode.CBC;
            ICryptoTransform ct = des.CreateDecryptor();
            byte[] output = ct.TransformFinalBlock(b, 0, b.Length);
            return Encoding.Unicode.GetString(output);
        }
        public TripleDES CreateDES(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];

            return des;
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public String GetHash(String Val)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            return Encoding.ASCII.GetString(md5.ComputeHash(Encoding.ASCII.GetBytes(Val)));
        }

    }
}