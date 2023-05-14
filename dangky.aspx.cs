using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTWde6.Model;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace LTWde6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Request.Form["btnRegistration"] == "true")
                {
                    if (Request.Form["txtEmail"] == "" || Request.Form["txtPass"] == "" || Request.Form["txtRePass"] == "")
                    {
                        Span1.InnerHtml = @"Tài khoản và mật khẩu không được để trống. Vui lòng nhập lại!";
                        return;
                    }

                    
                    if (Request.Form["txtPass"].Length < 8)
                    {
                        Span1.InnerHtml = @"Mật khẩu phải dài hơn 8 ký tự.";
                        //string alert = "";
                        //alert += "<script>alert('');</script>";
                        //Response.Write(alert);
                        return;
                    }
                    if (Request.Form["txtPass"] != Request.Form["txtRePass"])
                    {
                        Span1.InnerHtml = @"Mật khẩu không khớp. Vui lòng nhập lại!";
                        //string alert = "";
                        //alert += "<script>alert('');</script>";
                        //Response.Write(alert);
                        return;
                    }

                    Random r = new Random();
                    int id = r.Next(10000, 99999);

                    string path = @"G:/LTWde6/LTWde6/xml/listMember.xml";
                    List<Member> list = new List<Member>();

                    if (File.Exists(Server.MapPath("xml/listMember.xml")))
                    {
                        // Đọc file
                        System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));
                        StreamReader file = new StreamReader(Server.MapPath("xml/listMember.xml"));

                        list = (List<Member>)reader.Deserialize(file);
                        list = list.OrderBy(Member => Member.Id).ToList();


                        file.Close();
                    }
                    foreach (Member mem in list)
                    {
                        if (mem.NickName.Equals(Request.Form["txtEmail"]) || mem.Id.Equals(id))
                        {
                            Span1.InnerHtml = @"Tài khoản đã tồn tại. Vui lòng thử lại!";
                            return;
                        }
                    }


                    XDocument xDocument = XDocument.Load(path);

                    XElement xElement = new XElement("Member");
                    xElement.SetElementValue("NickName", Request.Form["txtEmail"]);
                    xElement.SetElementValue("Id", "" + id);
                    xElement.SetElementValue("Pass", Request.Form["txtPass"]);
                    xElement.SetElementValue("LoginFail", "0");

                    xDocument.Element("ArrayOfMember").Add(xElement);
                    xDocument.Save(path);

                    Response.Redirect("dangnhap.aspx");
                }

            }

        }
    }
}
