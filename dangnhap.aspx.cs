using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LTWde6.Model;
using System.Data;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace LTWde6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["login"] == true)
            {
                Response.Redirect("trangchu.aspx");
            }
            string path = "xml/listMember.xml";
            if (Request.Form["btnLogin"] == "true")
            {
                if (Request.Form["txtEmail"] == "" || Request.Form["txtPass"] == "")
                {
                    loi.InnerHtml = @"Tài khoản và mật khẩu không được để trống. Vui lòng nhập lại!";
                    //string alert = "";
                    //alert += "<script>alert('');</script>";
                    //Response.Write(alert);
                    return;
                }
                if (Request.Form["txtPass"].Length < 8)
                {
                    loi.InnerHtml = @"Mật khẩu phải dài hơn 8 ký tự.";
                    //string alert = "";
                    //alert += "<script>alert('');</script>";
                    //Response.Write(alert);
                    return;
                }
                List<Member> list = new List<Member>();

                if (File.Exists(Server.MapPath(path)))
                {
                    // Đọc file
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));
                    StreamReader file = new StreamReader(Server.MapPath(path));
                    list = (List<Member>)reader.Deserialize(file);
                    list = list.OrderBy(Member => Member.Id).ToList();


                    file.Close();
                }

                Member mb = new Member();
                mb.Id = list.Count;
                mb.NickName = Request.Form["txtEmail"];
                mb.Pass = Request.Form["txtPass"];


                bool checktrung = false;
                foreach (Member mem in list)
                {

                    if (mem.NickName.Equals(mb.NickName) && mem.Pass.Equals(mb.Pass))
                    {

                        if (mem.LoginFail >= 10)
                        {
                            loi.InnerHtml = @"Tài khoản của bạn đã nhập sai quá 10 lần. Vui lòng liên hệ quản trị viên!";
                            //string alert = "";
                            //alert += "<script>alert('');</script>";
                            //Response.Write(alert);
                            return;
                        }
                        checktrung = true;
                        mb.Id = mem.Id;
                        break;
                    }
                }
                //Response.Write();

                if (checktrung == false)
                {
                    if (File.Exists(Server.MapPath(path)))
                    {
                        string paths = @"G:/LTWde6/LTWde6/xml/listMember.xml";
                        XDocument testXML = XDocument.Load(paths);
                        XElement cStudent = testXML.Descendants("Member").Where(x => x.Element("NickName").Value == mb.NickName).FirstOrDefault();
                        int a = Int32.Parse(cStudent.Element("LoginFail").Value);
                        cStudent.Element("LoginFail").Value = "" + (a + 1);
                        testXML.Save(paths);

                    }
                    loi.InnerHtml = @"Tài khoản hoặc mật khẩu không đúng!";
                    //string alert = "";
                    //alert += "<script>alert('');</script>";
                    //Response.Write(alert);
                }
                else
                {
                    // Tạo session
                    Session["login"] = true;
                    Session["id"] = mb.Id;
                    Session["NickName"] = mb.NickName;
                    Session["Pass"] = mb.Pass;
                }

                if ((bool)Session["login"] == true)
                {
                    Response.Redirect("trangchu.aspx");
                    
                }
            }

        }
    }
}