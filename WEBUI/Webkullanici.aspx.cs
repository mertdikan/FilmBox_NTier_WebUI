using BLL.Repositories;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBUI
{
    public partial class Webkullanici : System.Web.UI.Page
    {
        UserRepository Urp = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            string kullanci = txtKullaniciAdi.Text;
            string sifre = sifrele(txtSifre.Text);
            Urp.Insert(new UsersDTO { UserName = kullanci, Password = sifre });
            txtKullaniciAdi.Text = txtSifre.Text = string.Empty;
        }
        
        protected void btnGiris_Click(object sender, EventArgs e)
        {

            UsersDTO gelen = Urp.GetByName(txtKullaniciAdi.Text);
            string kullaniciAdi = gelen.UserName;
       
            string sifre = coz(gelen.Password);

            if (txtKullaniciAdi.Text == kullaniciAdi)
            {
                if (sifre == txtSifre.Text)
                {
                    Response.Redirect("WebForm3.aspx");
                }
            }
        }
        public static string sifrele(string sifre)
        {
            string hash = "yahya";
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string coz(string sifrelenmisDeger)
        {
            string hash = "yahya";

            byte[] data = Convert.FromBase64String(sifrelenmisDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.Default.GetString(results);
                }
            }


            //try
            //{
            //    string hash = "yahya";
            //    byte[] data = Convert.FromBase64String(sifrelenmisDeger);
            //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //    {
            //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            //        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //        {

            //            ICryptoTransform transform = tripDes.CreateDecryptor();
            //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //            return UTF8Encoding.UTF8.GetString(results);


            //        }
            //    }
            //}
            //catch
            //{
            //    return sifrelenmisDeger;
            //}
        }
    }
}