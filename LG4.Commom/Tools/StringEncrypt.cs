using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Commom.Tools {
    public static class StringEncrypt {

        private static string secretkey = "98339913";
        private static string publickey = "27052022";


        #pragma warning disable SYSLIB0021 // O tipo ou membro é obsoleto

        public static string Encrypt(string text) {

            string encryptText = "";

            byte[] secretkeyByte = { };
            secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);

            byte[] publickeybyte = { };
            publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);

            byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(text);


            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()) {

                var ms = new MemoryStream();
                var cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);

                cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                cs.FlushFinalBlock();

                encryptText = Convert.ToBase64String(ms.ToArray());
            }

            return encryptText;

        }

        public static string Decrypt(string textToDecrypt) {

            string Text = "";

            byte[] privatekeyByte = { };
            privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);

            byte[] publickeybyte = { };
            publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);

            byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
            inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));

            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()) {

                var ms = new MemoryStream();
                var cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);

                cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                cs.FlushFinalBlock();
                Encoding encoding = Encoding.UTF8;

                Text = encoding.GetString(ms.ToArray());
            }

            return Text;

        }

        public static string MD5Generate(string valor) {
            MD5 md5Hasher = MD5.Create();

            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++) {

                strBuilder.Append(valorCriptografado[i].ToString("x2"));

            }

            return strBuilder.ToString();

        }

#pragma warning restore SYSLIB0021 // O tipo ou membro é obsoleto

    }
}
