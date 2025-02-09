using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SultansKitchen.Helper
{
    public static class Tools
    {
        public static Image ByteToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public static void SuccessMessage(string text)
        {
            MessageBox.Show(text, System.Reflection.Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ErrorMessage(string text)
        {
            MessageBox.Show(text, System.Reflection.Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void AlertMessage(string text)
        {
            MessageBox.Show(text, System.Reflection.Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }




        public static  string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] TextToByteArray = new UnicodeEncoding().GetBytes(text);
            byte[] HashData = md5.ComputeHash(TextToByteArray);
            return BitConverter.ToString(HashData);
        }
    }
}
    
