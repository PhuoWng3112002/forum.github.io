using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using LTWde6.Model;
using System.Data;

namespace LTWde6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            string searchFind = Request.QueryString["search"] == null ? "" : Request.QueryString["search"];

            /***************************************************************/
            string data = "";
            string quantam = "";

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath("xml/congdong.xml"));
            XmlNodeList listcd = xdoc.GetElementsByTagName("congdong");
            int stt = 0;
            int count = 0;
           
            
            

            foreach (XmlNode cd in listcd)
            {
               
                if (count < 15 && cd.ChildNodes[2].InnerText.ToLower().IndexOf(searchFind.ToLower()) != -1)
                {
                    count++;
                }
                else { break; }

                string id = cd.ChildNodes[0].InnerText;
                string Url_img = cd.ChildNodes[1].InnerText;
                string tencongdong = cd.ChildNodes[2].InnerText;
                string tenchude = cd.ChildNodes[3].InnerText;
                string sothanhvien = cd.ChildNodes[4].InnerText;
                string sobaiviet = cd.ChildNodes[5].InnerText;
                string idchude = cd.ChildNodes[6].InnerText;
    

                data += @"<div class='congdong'>
                            <div class='card'>
                            <div class='STT'>"+(stt=stt+1)+@"</div>
                            <div class='image' >
                                <a href='chude.aspx?id="+idchude+@"'><img src = '"+Url_img+ @"' width='50%'></a>
                            </div>
                            <div class='tieude'>
                                <a class='tencd' href='trangcongdong.aspx?id=" + id + @"'>" + tencongdong+@"</a>
                                <div class='chude'>" + tenchude + @"</div>
                                <p>" +sothanhvien +@" Thành viên   "+sobaiviet + @" Bài viết</p>
                            </div>
                            <div class='quantam'>
                                <button type='submit' class='thamgia' name='btnAdd' ><a href='trangcongdong.aspx?id=" + id + @"' class='buy-btn'value='them'>Quan tâm</a></button>
                            </div>
                          </div>
                         </div>";

           
            }
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

            listcongdong.InnerHtml = data;
            rightcontent.InnerHtml = quantam;
            /*******************************BÀI VIẾT PHỔ BIẾN*************************************/

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

                phobien += @"<a href='chitietbaiviet.aspx?id="+id+ @"' style='text-decoration:none;
    color:#003B70;'><i class='fas fa-circle'></i>&nbsp;&nbsp;&nbsp;&nbsp;" + tenbv+@"</a><br/>";
            }

            listphobien.InnerHtml = phobien;

        }

        
    }
}

