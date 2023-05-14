using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace LTWde6
{
    public partial class layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string listchude = "";
            string listchude2 = "";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml/chude.xml"));
            XmlNodeList listcde = xdoc.GetElementsByTagName("chude");
         
            foreach (XmlNode cde in listcde)
            {
                string id = cde.ChildNodes[0].InnerText;
                string tenchude = cde.ChildNodes[1].InnerText;
               // string image = cde.ChildNodes[2].InnerText;

                listchude +=            @"<a href='chude.aspx?id="+id+"'>"+tenchude+" </a>";
                listchude2 +=            @"<a href='chude.aspx?id="+id+"'>"+tenchude+" </a>";

            }

            chude.InnerHtml = listchude;
            chude2.InnerHtml = listchude2;
            // Response.Redirect("chude.aspx");


            //if (Phanquyen = admin)
            //{
            //   quantri.innerHtml="<a href="quantri.aspx"></a>"
            //}

            string html = "";
            //html += "<a data-toggle = \"dropdown\" class=\"dropdown-toggle\">" +
            //            "<i class=\"fa fa-user\" ></i><b class=\"caret\"></b>" +
            //        "</a>";

            if ((bool)Session["login"] == true && (string)Session["NickName"] == "admin@gmail.com")
            {
                html += "<div class='dropdown-content'>";
                html += "<b>ID : " + Session["id"] + "</b>";
                html += "<br/>";
                html += "<b>User name : " + Session["NickName"] + "</b>";
                html += "<a href = 'quantrichude.aspx'> Quản lý chủ đề</a>";
                html += "<a href = 'quantricongdong.aspx'> Quản lý cộng đồng</a>";
                html += "<a href = 'quantribaiviet.aspx'> Quản lý bài viết</a>";
                html += "<form class=\"formlogout\"><button type=\"submit\" class=\"btn-danger\" value=\"true\" name=\"btnLogout\" id=\"btnLogout\" runat=\"server\">" +
                                "<i class=\"fa fa-power-off\" aria-hidden=\"true\"></i> Thoát" +
                            "</button></form>";
                html += "</div>";
                account.InnerHtml = html;
            }
            else if ((bool)Session["login"] == true)
            {
                html += "<div class='dropdown-content'>";
                html += "<b>ID : " + Session["id"] + "</b>";
                html += "<br/>";
                html += "<b>User name : " + Session["NickName"] + "</b>";
                html += "<br/>";
                html += "<form class=\"formlogout\"><button type=\"submit\" class=\"btn-danger\" value=\"true\" name=\"btnLogout\" id=\"btnLogout\" runat=\"server\">" +
                                "<i class=\"fa fa-power-off\" aria-hidden=\"true\"></i> Thoát" +
                            "</button></form>";
                html += "</div>";
                account.InnerHtml = html;
               
            }
            else
            {
                html += "<div class='dropdown-content'>";
                html += "<a href = 'dangnhap.aspx'> Đăng nhập</a>";
                html += "<a href = 'dangky.aspx'> Đăng ký</a>";
                html += "</div>";

                account.InnerHtml = html;
            }

            if (Request.QueryString["btnLogout"] == "true")
            {
                Session.Abandon();
                Response.Redirect("dangxuat.aspx");
            }

            /**/
            //onl.InnerHtml=@"<center>So nguoi onl hien tai:"+Application.Get("dem").ToString()+"";
            
            //Response.Write(Session["date2"]);

        }
        /*.ToString("HH:mm:ss")*/

    }


}
    
