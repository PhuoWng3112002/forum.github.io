using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.IO;

namespace Asmallpart
{
    public partial class ckeditor : System.Web.UI.Page
    {
        struct MyStruct
        {
            public string name;
            public string titlebaiviet;
            public string description;
            public string idcd;
            public string idcde;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            /******************************CKEDITOR***************************************/
            if ((bool)Session["login"] == false)
            {
                Response.Redirect("dangnhap.aspx");

            }
            if ((bool)Session["login"] == false)
            {
                Response.Redirect("ckeditor.aspx");

            }
            if (Request.Form["btnTao"] == "true")
            {
                          
                /******************************************************/
                Random r = new Random();
                int id = r.Next(10000, 99999);
                string path = @"G:/LTWde6/LTWde6/xml/baiviet.xml";

                if (File.Exists(Server.MapPath("xml/baiviet.xml")))
                {
                    // Đọc file

                    StreamReader file = new StreamReader(Server.MapPath("xml/baiviet.xml"));


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

                var thoigian = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

                XDocument xDocument = XDocument.Load(path);

                XElement xElement = new XElement("baiviet");
                xElement.SetElementValue("idbv", id);
                xElement.SetElementValue("congdong", ((MyStruct)Session["MySession"]).titlebaiviet);
                xElement.SetElementValue("idcongdong", ((MyStruct)Session["MySession"]).idcd);
                xElement.SetElementValue("user", Session["NickName"]);
                xElement.SetElementValue("time", thoigian);
                xElement.SetElementValue("tieude", ((MyStruct)Session["MySession"]).name);
                xElement.SetElementValue("noidung", ((MyStruct)Session["MySession"]).description);
                xElement.SetElementValue("idcde", ((MyStruct)Session["MySession"]).idcde);

                xDocument.Element("ArrayOfArtical").Add(xElement);
                xDocument.Save(path);

            }
            string btntrove = "";
            XmlDocument xdoccde = new XmlDocument();
            xdoccde.Load(Server.MapPath("xml/baiviet.xml"));
            XmlNodeList list = xdoccde.GetElementsByTagName("baiviet");

            int count = 0;
            foreach (XmlNode cde in list)
            {
                if (count < 1)
                {
                    count++;
                }
                else
                {
                    break;
                }
                if ((string)Session["NickName"] == "admin@gmail.com")
                {
                    btntrove += @"<a href='quantribaiviet.aspx'>Trở về</a>";
                }
                else
                {
                    btntrove += @"<a href='chude.aspx?id="+idcdeTextBox.Text+ @"'>Trở về</a>";
                }
            }
            trove.InnerHtml = btntrove;

            /****************************************/

        }

    
        

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                MyStruct myStruct;
                myStruct.name = nameTextBox.Text;
                myStruct.idcd = idcdTextBox.Text;
                myStruct.idcde = idcdeTextBox.Text;
                myStruct.titlebaiviet = titleTextBox.Value.ToString();
                myStruct.description = descriptionTextBox.Text;
                Session["MySession"] = myStruct;
                BindDataTable();
            }
        }

        Boolean Validation()
        {
            var errorMessage = "";

            //Name
            if (nameTextBox.Text == "")
                errorMessage += "Tiêu đề không được để trống <br/>";
            //End
            if (idcdTextBox.Text == "")
                errorMessage += "ID cộng đồng không được để trống <br/>";
            if (idcdeTextBox.Text == "")
                errorMessage += "ID chủ đề không được để trống <br/>";

            //Description
            if (descriptionTextBox.Text == "")
                errorMessage += "Nội dung không được để trống";
            //End

            if (errorMessage.Length == 0)
                return true;
            else
            {
                errorDiv.InnerHtml = errorMessage;
                return false;
            }
        }

        void BindDataTable()
        {
            string table = "<table>";
            table += "<tr><td class=\"red\">Title: </td></tr><tr><td>" + ((MyStruct)Session["MySession"]).titlebaiviet + "</td></tr>";
            table += "<tr><td class=\"red\">Name: </td></tr><tr><td>" + ((MyStruct)Session["MySession"]).name + "</td></tr>";
            table += "<tr><td class=\"red\">Description: </td></tr><tr><td>" + ((MyStruct)Session["MySession"]).description + "</td></tr>";
            table += "</table>";
            studentDataDiv.InnerHtml = table;

            studentFormDiv.Visible = false;
            editButton.Visible = studentDataDiv.Visible = true;
        }

        protected void editButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Value = ((MyStruct)Session["MySession"]).titlebaiviet;
            nameTextBox.Text = ((MyStruct)Session["MySession"]).name;
            idcdTextBox.Text = ((MyStruct)Session["MySession"]).idcd;
            idcdeTextBox.Text = ((MyStruct)Session["MySession"]).idcde;
            descriptionTextBox.Text = ((MyStruct)Session["MySession"]).description;

            studentFormDiv.Visible = true;
            editButton.Visible = studentDataDiv.Visible = false;
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            Response.Redirect("ckeditor.aspx");
        }
    }
}