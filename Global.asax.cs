using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using LTWde6.Model;
using System.IO;

namespace LTWde6
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["listMember"] = dsMember();

            Application.Add("dem", 0);

        }
        protected List<Member> dsMember()
        {
            string path = "xml/listMember.xml";
            List<Member> list = new List<Member>();
            if (File.Exists(path))
            {
                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                list = (List<Member>)reader.Deserialize(file);
                list = list.OrderBy(Member => Member.Id).ToList();
                file.Close();
            }
            return list;
        }
        protected void Session_Start(object sender, EventArgs e)

        {
            Session["login"] = false;
            Session["id"] = "";
            Session["NickName"] = "";
            Session["Pass"] = "";

            Session["acc"] = new acc();
            Session["solan"] = 0;

            /*quantri*/
            //Session["quantri"]=

            int so = int.Parse(Application.Get("dem").ToString());
            so++;
            Application.Set("dem", so);

            Session["date"] = DateTime.Now.ToString("HH:mm:ss");


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            int so = int.Parse(Application.Get("dem").ToString());
            so--;
            Application.Set("dem", so);

            Session["date2"] = DateTime.Now.ToString();


        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application.Remove("dem");
        }
    }
}