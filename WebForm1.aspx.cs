using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            myDiv.Style.Add("background-color", "lightblue");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)//Kartların numaralarına göre hangisi olduğunu eşleştirme.
        {
            Mastercard.Visible = true;//başlangıçta tüm resimlerin çıkması için
            Visa.Visible = true;
            Amex.Visible = true;
            BCGlobal.Visible = true;
            Diners.Visible = true;
            Carte.Visible = true;
            Discover.Visible = true;
            Maestro.Visible = true;
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$"))
            {
                Mastercard.Visible = true;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = false;    
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^4[0-9]{12}(?:[0-9]{3})?$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = true;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^3[47][0-9]{13}$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = true;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = false; ;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^(6541|6556)[0-9]{12}$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = true;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^3(?:0[0-5]|[68][0-9])[0-9]{11}$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = true;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^389[0-9]{11}$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = true;
                Discover.Visible = false;
                Maestro.Visible = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^65[4-9][0-9]{13}|64[4-9][0-9]{13}|6011[0-9]{12}|(622(?:12[6-9]|1[3-9][0-9]|[2-8][0-9][0-9]|9[01][0-9]|92[0-5])[0-9]{10})$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = true;
                Maestro.Visible = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text.ToString(), "^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$"))
            {
                Mastercard.Visible = false;
                Visa.Visible = false;
                Amex.Visible = false;
                BCGlobal.Visible = false;
                Diners.Visible = false;
                Carte.Visible = false;
                Discover.Visible = false;
                Maestro.Visible = true;
            }
            
        }

        static bool checkCardNumber(String cardNo)
        {
            int nDigits = cardNo.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)//Lhun algoritmasi kartın doğruluğunu kontrol eder.
            {

                int d = cardNo[i] - '0';

                if (isSecond == true)
                    d = d * 2;
                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }
        //public static bool IsValidDate(int month, int year)//Kartın son kullanım tarihinin geçip geçmediğini kontrol eder.
        //{

        //    if (year >= 2022)
        //    {
        //        if (month<=12 && month >= 1)
        //        {
        //            return true;
        //        }

        //        if (year == 2022)
        //        {
        //            if (month >= 3)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                if (checkCardNumber(TextBox1.Text)) //kullanıcının girdiği bilgilere göre mesaj yazdırma
                {
                    
                        if (Convert.ToInt32(TextBox3.Text) >= 3 && (Convert.ToInt32(TextBox4.Text) == 2022) && Convert.ToInt32(TextBox3.Text) <= 12)
                        {
                            Label1.Text = "Payment occurred!";
                            Label3.Text = "";
                        }
                        else
                        {
                            Label1.Text = "Payment Fail!";
                            Label3.Text = "Your card has expired. Use a valid card.";
                        }
                        if (Convert.ToInt32(TextBox3.Text) >= 1 && (Convert.ToInt32(TextBox4.Text) > 2022) && Convert.ToInt32(TextBox3.Text) <= 12)
                        {
                            Label1.Text = "Payment occurred!";
                            Label3.Text = "";
                        }
                        else 
                        {
                            Label1.Text = "Payment Fail!";
                            Label3.Text = "Your card has expired. Use a valid card.";
                        }
                }
                else
                {
                    Label1.Text = " Card Number is not valid.Please use a valid card";
                }
            }
        }
    }
}