using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Data;
using System.Xml.Linq;
using LTWde6.Model;

namespace LTWde6
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["NickName"] != "admin@gmail.com" || (bool)Session["login"] == false)
            {
                Response.Redirect("trangchu.aspx");
            }
            //string qtchude = "";
            XmlDocument xdoccde = new XmlDocument();
            xdoccde.Load(Server.MapPath("xml/congdong.xml"));
            XmlNodeList listcde = xdoccde.GetElementsByTagName("congdong");


            if (Request.Form["btnXoa"] != "")
            {
                foreach (XmlNode c in listcde)
                {
                    string idcd = c.ChildNodes[0].InnerText;
                    if (idcd.Equals(Request.QueryString["btnXoa"]))
                    {
                        xdoccde.DocumentElement.RemoveChild(c);
                        //luu file

                        string path = @"G:/LTWde6/LTWde6/xml/congdong.xml";
                        xdoccde.Save(path);
                        break;
                    }
                }

            }

            if (Request.Form["btnThem"] == "true")
            {
               

                //Random r = new Random();
                //int id = r.Next(10000, 99999);

                string path = @"G:/LTWde6/LTWde6/xml/congdong.xml";
                List<chude> list = new List<chude>();

                if (File.Exists(Server.MapPath("xml/congdong.xml")))
                {
                    // Đọc file
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Comment>));
                    StreamReader file = new StreamReader(Server.MapPath("xml/congdong.xml"));

                    // list = (List<chude>)reader.Deserialize(file);
                    //list = list.OrderBy(Cde => Cde.IdChude).ToList();


                    file.Close();
                }
                    //foreach (chude cde in list)
                    //{
                    //    if (cde.IdChude.Equals(Request.Form["idcde"]) || cde.TenChude.Equals(Request.Form["chude"]))
                    //    {
                    //        string alert = "";
                    //        alert += "<script>alert('Chủ đề đã tồn tại. Vui lòng thử lại!');</script>";
                    //        Response.Write(alert);
                    //        return;
                    //    }
                    //}
                    //HttpPostedFile postfile = Request.Files["imgcde"];
                   
                        //string fileName = "img/"+postfile.FileName;
                        //string filePath = MapPath(fileName);
                    //postfile.SaveAs(filePath);
                    XDocument xDocument = XDocument.Load(path);

                XElement xElement = new XElement("congdong");
                xElement.SetElementValue("idcongdong", Request.Form["idcd"]);
                xElement.SetElementValue("image", Image1.ImageUrl);
                xElement.SetElementValue("tencongdong", Request.Form["tencd"]);
                xElement.SetElementValue("chude", Request.Form["tenchude"]);
                xElement.SetElementValue("sothanhvien",0);
                xElement.SetElementValue("sobaiviet",0);
                xElement.SetElementValue("idchude", Request.Form["idchude"]);

                xDocument.Element("listcongdong").Add(xElement);
                xDocument.Save(path);


            }

            string qtcdong = "";
            XmlDocument xdoccd = new XmlDocument();
            xdoccd.Load(Server.MapPath("xml/congdong.xml"));
            XmlNodeList listcd = xdoccd.GetElementsByTagName("congdong");

            int stt = 0;
            foreach (XmlNode cd in listcd)
            {

                string idcongdong = cd.ChildNodes[0].InnerText;
                string Url_img = cd.ChildNodes[1].InnerText;
                string tencongdong = cd.ChildNodes[2].InnerText;
                string tenchude = cd.ChildNodes[3].InnerText;
                string sothanhvien = cd.ChildNodes[4].InnerText;
                string sobaiviet = cd.ChildNodes[5].InnerText;
                string idchude = cd.ChildNodes[6].InnerText;


                qtcdong += @"<tr>
                                <td>" + (stt = stt + 1) + @"</td>
                                <td>" + idcongdong + @"</td>
                                <td><img src='" + Url_img + @"'style='width:100px;'/></td>
                                <td>" + tencongdong + @"</td>
                                <td>" + tenchude + @"</td>
                                <td><button class='thaotacxoa' value='"+idcongdong+ @"' type='submit' name='btnXoa'>Xóa</button></td>
                              </tr>";


            }

            idquantricongdong.InnerHtml = qtcdong;

           
        }

        public void btnUpload_Click(object o, EventArgs e)
        {
            if (Page.IsValid && inputAnh1.HasFile)
            {
                if (CheckFileType(inputAnh1.FileName))
                {
                    string fileName = "img/" + inputAnh1.FileName;
                    string filePath = MapPath(fileName);
                    inputAnh1.SaveAs(filePath);
                    Image1.ImageUrl = fileName;
                }
                else
                {
                    string alert = "";
                    alert += "<script>alert('Chỉ nhận file ảnh!!!');</script>";
                    Response.Write(alert);
                }
            }
        }



        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }
    }
}