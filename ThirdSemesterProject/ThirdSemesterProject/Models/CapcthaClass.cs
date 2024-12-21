using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdSemesterProject.Models
{
    public class CapcthaClass : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            Bitmap bitmap = new Bitmap(200 , 50);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

            graphics.FillRectangle(solidBrush , 0 ,0 , 200 , 50);

            string sText = StringGenerator();
            context.HttpContext.Session["captchaString"] = sText;

            SolidBrush solidBrush1 = new SolidBrush(Color.Bisque);

            Font font = new Font("Forte", 40);
            PointF point = new PointF(0f , 0f);

            graphics.DrawString(sText, font, solidBrush1, point);

            HttpResponseBase Response = context.HttpContext.Response;
            Response.ContentType = "image/jpeg";

            bitmap.Save(Response.OutputStream , ImageFormat.Jpeg);
        }

        private string StringGenerator()
        {
            string randomText = Guid.NewGuid().ToString();
            string randomString = "";

            for(int i = 0; i <= 5; i++)
            {
                randomString += randomText.ToCharArray()[i];
            }
            return randomString;
        }
    }
}