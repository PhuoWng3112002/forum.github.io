using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using LTWde6.Model;


namespace LTWde6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        

                if (Request.Form["btnSend"] == "true")
                {
                        if ((bool)Session["login"] == false)
                        {
                            Response.Redirect("dangnhap.aspx");
                        }


                //Response.Write("<script>alert("+Request.Form["txtCmt"]+")</script>");
                if (Request.Form["txtCmt"] == "" || Request.Form["txtCmt"] == null)
                    {
                        string alert = "";
                        alert += "<script>alert('Comment không được để trống 2222');</script>";
                        Response.Write(alert);
                        return;
                    }
                    else
                    {

                        Random r = new Random();
                        int id = r.Next(10000, 99999);

                        string path = @"G:/LTWde6/LTWde6/xml/comment.xml";
                        List<Comment> list = new List<Comment>();

                        if (File.Exists(Server.MapPath("xml/comment.xml")))
                        {
                            // Đọc file
                            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Comment>));
                            StreamReader file = new StreamReader(Server.MapPath("xml/comment.xml"));

                            list = (List<Comment>)reader.Deserialize(file);
                            list = list.OrderBy(Cmt => Cmt.CmtId).ToList();


                            file.Close();
                        }



                        XDocument xDocument = XDocument.Load(path);

                        XElement xElement = new XElement("Comment");
                        xElement.SetElementValue("Cmt", Request.Form["txtCmt"]);
                        xElement.SetElementValue("tenuser", Session["NickName"]);
                        xElement.SetElementValue("idbv", Request.QueryString["id"]);
                        xElement.SetElementValue("time",DateTime.Now.ToString("MM/dd/yyyy h:mm tt"));
                        xDocument.Element("ArrayOfComment").Add(xElement);
                        xDocument.Save(path);

                        //Response.Redirect("DanhNhap.aspx");
                    }

                }
            

            string cmt = "";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml/comment.xml"));
            XmlNodeList listcmt = xdoc.GetElementsByTagName("Comment");

            var idchitiet = Request.QueryString["id"];

            foreach (XmlNode cm in listcmt)
            {

                string binhluan = cm.ChildNodes[0].InnerText;
                string accountname = cm.ChildNodes[1].InnerText;
                string idbv = cm.ChildNodes[2].InnerText;
                string thoigian = cm.ChildNodes[3].InnerText;
                if (idbv == idchitiet)
                {

                cmt += @"<div class='box-circle'>
                                               <img class='avt' src='./img/avatar.png' width='35px' alt=''>
                                        </div>
                    <div class='cmt-box'>
                    <a>" + accountname + @"</a><br>
                    <span>" + binhluan + @"

                                                <div class='reply' >
                                                    <p >"+thoigian+@"</p>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <a style = 'color:#003B70;transform: translateY(20%);'> Trả lời</a>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <i style = 'color:#003B70;transform: translateY(20%);' class='fa fa-thumbs-up'>&nbsp;</i>

                                                </div>
                                            </span>
                                        </div>";

                }

            }

            innercmt.InnerHtml = cmt;

            /**/
            string chitietbv = "";
            XmlDocument ctbv = new XmlDocument();
            ctbv.Load(Server.MapPath("xml/baiviet.xml"));
            XmlNodeList listbaiviet = ctbv.GetElementsByTagName("baiviet");

            foreach (XmlNode baiviet in listbaiviet)
            {
                string idbv = baiviet.ChildNodes[0].InnerText;
                string congdong = baiviet.ChildNodes[1].InnerText;
                string idcongdong = baiviet.ChildNodes[2].InnerText;
                
                string user = baiviet.ChildNodes[3].InnerText;
                string time = baiviet.ChildNodes[4].InnerText;
                string tieude = baiviet.ChildNodes[5].InnerText;
                string noidung = baiviet.ChildNodes[6].InnerText;
                if (idchitiet == idbv)
                {

                chitietbv += @" <div class='anh-ten'>
                                            <div class='box-circle'>
                                            <img class='avt' src='./img/avatar.png' width='35px' alt=''/>
                                          </div>
                             
                                          <div class='ten'>
                                            <a class='hoten'>"+user+@"</a>
                                            <br> <p class='gio'>"+time+@"</p>
                             
                                          </div>
                             
                                        </div>
                             
                                        <!-------------->
                                        <div class='write'>
                             
                                         <div class='write-1'>
                                           <h3 class='title-bv'>"+tieude+@"</h3>
                                          "+noidung+@"
                                    </div>
                                        </div>";

                    string quantam = "";

                    XmlDocument quan = new XmlDocument();
                    quan.Load(Server.MapPath("xml/congdong.xml"));
                    XmlNodeList listcd = quan.GetElementsByTagName("congdong");

                    int countqt = 0;
                    foreach (XmlNode cd in listcd)
                    {
                        if (countqt < 5)
                        {
                            countqt++;
                        }
                        else { break; }

                        string id = cd.ChildNodes[0].InnerText;
                        string Url_img = cd.ChildNodes[1].InnerText;
                        string tencongdong = cd.ChildNodes[2].InnerText;
                        string tenchude = cd.ChildNodes[3].InnerText;
                        string sothanhvien = cd.ChildNodes[4].InnerText;
                        string sobaiviet = cd.ChildNodes[5].InnerText;
                        string idchude = cd.ChildNodes[6].InnerText;

                        quantam += @"<div class='right-congdong'>
                        <div class='image'>
                          <img src ='" + Url_img + @"'width='80%'>
                        </div>
                        <div class='tieude'>
                          <h4>" + tencongdong + @"</h4>
                          <p>" + sothanhvien + @" Thành viên   " + sobaiviet + @" Bài viết</p>
                        </div>
                        </div>";
                    }
                    rightcontent.InnerHtml = quantam;
                }


            }

            innerbv.InnerHtml = chitietbv;

            /***************BV pho bien*************/
            XmlDocument pbien = new XmlDocument();
            pbien.Load(Server.MapPath("xml/baiviet.xml"));
            XmlNodeList listpb = pbien.GetElementsByTagName("baiviet");

            string phobien = "";

            int countpb = 0;
            foreach (XmlNode pb in listpb)
            {
                if (countpb < 5)
                {
                    countpb++;
                }
                else { break; }

                string id = pb.ChildNodes[0].InnerText;
                string tenbv = pb.ChildNodes[5].InnerText;

                phobien += @"<a href='chitietbaiviet.aspx?id=" + id + @"' style='text-decoration:none;
    color:#003B70;'><i class='fas fa-circle'></i>&nbsp;&nbsp;&nbsp;&nbsp;" + tenbv + @"</a><br/>";
            }

            listphobien.InnerHtml = phobien;


            /**********************/

           
        }
        
    }
}