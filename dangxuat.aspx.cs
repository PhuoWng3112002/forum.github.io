using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTWde6
{
    public partial class dangxuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string starttime = string.Format(Session["date"].ToString());
            //start.InnerHtml = @"Thoi gian bat dau:"+starttime+"";

            //string endtime = DateTime.Now.ToString("HH:mm:ss");
            //end.InnerHtml = @"Thoi gian ket thuc:" + endtime + "";

            //starttime.Replace(":","");
            //endtime.Replace(":","");
            //int a = int.Parse(starttime);
            //int gio1 = a / 10000;
            //int c = a % 10000;
            //int phut1 = c / 100;
            //int giay1 = c % 100;

            //int b = int.Parse(endtime);
            //int gio2 = b / 10000;
            //int d = b % 10000;
            //int phut2 = d / 100;
            //int giay2 = d % 100;

            //int tong1 = gio1 * 60 * 60 + phut1 * 60 + giay1;
            //int tong2 = gio2 * 60 * 60 + phut2 * 60 + giay2;

            //int deltatime = tong2 - tong1;
            //int deltagio = deltatime / 3600;
            //int deltaphut = (deltatime % 3600) / 60;
            //int deltagiay = ((deltatime % 3600) % 60);


            ///*Xu lý giờ*/
            //delta.InnerHtml = @"Thoi gian "+Session["NickName"]+" su dung website la: "+deltagio+" gio "+deltaphut+" phút "+deltagiay+" ";

            
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAdd=System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.GetValue(0).ToString();
            string ipmay;
            string userIp = Request.UserHostAddress;
            //string userIp = Context.Request.UserHostAddress;
            ipmay =Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            //string ipAdd = Context.Request.ServerVariables["HTTP_X_CLUSTER_CLIENT_IP"] ??
                   Request.ServerVariables["REMOTE_ADDR"].Split(',')[0].Trim();



            ip.InnerHtml = @""+ipAdd+"";
            


        }
    }
}