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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["NickName"] != "admin@gmail.com" || (bool)Session["login"] == false)
            {
                Response.Redirect("trangchu.aspx");
            }


            if (Request.Form["btnThem"] == "true")
            {
                //Random r = new Random();
                //int id = r.Next(10000, 99999);

                string path = @"G:/LTWde6/LTWde6/xml/chude.xml";
                List<chude> list = new List<chude>();
                if (Request.Form["idcde"] == "")
                {
                    loiqt.InnerHtml = @"ID chu de khong duoc de trong";
                    return;
                }
                if (Request.Form["chudeqt"] == "")
                {
                    loiqt.InnerHtml = @"Ten chu de khong duoc de trong";
                    return;
                }
               
                string tenchude = Request.Form["chudeqt"];
                for (int i=0; i < tenchude.Length; i++)
                {
                    if (tenchude[i] == '!' || tenchude[i] == '@')
                    {

                        loiqt.InnerHtml = @"Ten chu de khong duoc chua ki tu dac biet";
                        return;
                    }
                }


                if (File.Exists(Server.MapPath("xml/chude.xml")))
                {
                    // Đọc file
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<chude>));
                    StreamReader file = new StreamReader(Server.MapPath("xml/chude.xml"));

                    list = (List<chude>)reader.Deserialize(file);
                    list = list.OrderBy(Cde => Cde.id).ToList();


                    file.Close();
                }
                foreach (chude cde in list)
                {
                    if (cde.id.Equals(Request.Form["idcde"]) || cde.tenchude.Equals(Request.Form["chude"]))
                    {
                        string alert = "";
                        alert += "<script>alert('Chủ đề đã tồn tại. Vui lòng thử lại!');</script>";
                        Response.Write(alert);
                        return;
                    }
                }



                XDocument xDocument = XDocument.Load(path);

                XElement xElement = new XElement("chude");
                xElement.SetElementValue("id", Request.Form["idcde"]);
                xElement.SetElementValue("tenchude", Request.Form["chudeqt"]);
                xElement.SetElementValue("img", Image1.ImageUrl);

                xDocument.Element("ArrayOfChude").Add(xElement);
                xDocument.Save(path);


            }
            /*BTN XOA*/
            
            string qtchude = "";
            XmlDocument xdoccde = new XmlDocument();
            xdoccde.Load(Server.MapPath("xml/chude.xml"));
            XmlNodeList listcde = xdoccde.GetElementsByTagName("chude");

XmlDocument cd = new XmlDocument();
                   cd.Load(Server.MapPath("xml/congdong.xml"));
                    XmlNodeList listcd = cd.GetElementsByTagName("congdong");

            if (Request.Form["btnXoa"] != "")
            {
                foreach (XmlNode congdong in listcd)
                {
                    string idcde1 = congdong.ChildNodes[6].InnerText;
                    if (idcde1.Equals(Request.QueryString["btnXoa"]))
                    {
                        loiqt.InnerHtml = @"Chu de ton tai bai viet. Khong the xoa";
                        break;

                       // Response.Write("<script>aleart('')</script>");
                       
                    } 



                    else
                    {
                        //xdoccde.DocumentElement.RemoveChild(congdong);
                        //string path = @"G:/LTWde6/LTWde6/xml/chude.xml";
                        //xdoccde.Save(path);
                        //break;
                    }


                    //luu file




                } 

            }

            if (Request.Form["btnSua"] != "")
            {
                foreach (XmlNode c in listcde)
                {

                    string idchude = c.ChildNodes[0].InnerText;
                    if (idchude.Equals(Request.QueryString["btnSua"]))
                    {

                        string tenchude = c.ChildNodes[1].InnerText;
                        var image = c.ChildNodes[2].InnerText;

                        idchude = Request.Form["idcde"];
                        tenchude = Request.Form["chudeqt"];
                        image = Request.Form["imgcde"];
                        

                        //xdoccde.DocumentElement.ReplaceChild(c,c);
                        ////luu file

                        //string path = @"G:/LTWde6/LTWde6/xml/chude.xml";
                        //xdoccde.Save(path);
                        //break;
                    }
                }

            }



            /// HIEN
            int count = 0;

            foreach (XmlNode cde in listcde)
            {

                string idchude = cde.ChildNodes[0].InnerText;
                string tenchude = cde.ChildNodes[1].InnerText;
                var image = cde.ChildNodes[2].InnerText;

                qtchude += @"
                <tr>
            
                          <td>" + (count=count+1) + @"</td>
                          <td>" + tenchude + @"</td>
                          <td><img src='" + image + @"'style='width:100px;'/></td>
                            <td>
                            <button class='thaotacxoa' value='" + idchude + @"' type='submit' name='btnXoa'>Xóa</button>
                          </td>
                </tr>";

            }
            idquantrichude.InnerHtml = qtchude;

            
        
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