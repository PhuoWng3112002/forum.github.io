<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckeditor.aspx.cs" Inherits="Asmallpart.ckeditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="icon" type="img/png" href="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1qFygjsIS4ZRHzt2Lo4knR3-pHylbahXVSA&usqp=CAU" />

    <title>Tạo bài viết</title>
    <script src="CKeditor/styles.js"></script>
    <script src="CKeditor/adapters/jquery.js"></script>
    <script src="CKeditor/ckeditor.js"></script>
    <style>
        .congdongtd{
            display:flex; 
            flex-direction:row;
            width:100%;
            justify-content:space-between;

        }
        #titleTextBox{
            width: 71%;
            margin: 0 auto;
            height: 30px;
            border-radius: 5px;
            margin-right: 0;
        }
        #nameTextBox{
            border:1px solid;
            margin: 0 auto;
            width: 70%;
            height: 30px;
            border-radius: 5px;
            margin-right: 0;

        }
        .congdongcd input, .congdongcde input{
            width:70%;
            height:30px;
            border-radius:5px;
            float:right;
        }
        #errorDiv{
            color:#ff0000;

        }
        .btnck{
            background-color:#003B70;
            color:aliceblue;
            padding:5px;
            
            border-radius:5px;
        }
        .btnck a{
            text-decoration:none;
            color:aliceblue;
        }
        .auto-style4{
            margin-top:10px;
            margin-bottom:10px;
            display:flex;
            justify-content:flex-end;
        }
    </style>
</head>
<body>
    <h2 style="color:#003B70; font-weight:600; margin-top:50px;">Tạo bài viết</h2>
      <p class="before-taobv">Thông tin của bạn sẽ được bảo mật tuyệt đối</p>
    <br />
    <br />
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div id="content">
                <div id="errorDiv" runat="server" class="validationDiv"></div>

                <div id="studentFormDiv" class="studentForm" runat="server">
                    <table>
                        <tbody>                            
                            <tr>   
                                <td class="congdongtd">
                                    <label>Chọn cộng đồng</label>
                                    <select id="titleTextBox" runat="server">
                                        <option >Quốc tế</option>
                                        <option>Công nghệ cập nhật dữ liệu</option>
                                        <option >Tổ ấm</option>
                                        <option >Giới sao</option>
                                        <option >Bóng đá</option>
                                        <option >Tâm lý cd</option>
                                    </select>
                                    
                                    <span id="titleSpan"></span>
                                </td>
                            </tr>
                            <tr>
                                <td class="congdongtd">
                                    <label>Tiêu đề</label>
                                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                                    <span id="nameSpan"></span>
                                </td>
                            </tr>
                            <tr>
                                <td class="congdongcd">
                                    <label>ID cộng đồng</label>
                                    <asp:TextBox ID="idcdTextBox" runat="server"></asp:TextBox>
                                    <span id="idcdSpan"></span>
                                </td>
                            </tr>
                            <tr>
                                <td class="congdongcde">
                                    <label>ID chủ đề</label>
                                    <asp:TextBox ID="idcdeTextBox" runat="server"></asp:TextBox>
                                    <span id="idcdeSpan"></span>
                                </td>
                            </tr>
                            <tr>
                                <td class="" >
                                    <label>Nội dung bài viết</label>
                                    <asp:TextBox ID="descriptionTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    <script type="text/javascript" lang="javascript">
                                        CKEDITOR.replace('<%=descriptionTextBox.ClientID%>');
                                    </script>
                                    <span id="descriptionSpan"></span>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">
                                    <asp:Button ID="submitButton" class="btnck" runat="server" Text="Xem trước bài viết" OnClick="submitButton_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="reset"  class="btnck" runat="server" Text="Reset »" OnClick="reset_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                                    <button type="submit"  class="btnck" value="true" id="btnTao" name="btnTao">Đăng bài viết</button>&nbsp;&nbsp;&nbsp;&nbsp;
                                    <button id="trove"  class="btnck" name="trove" runat="server"></button>

                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <div id="studentDataDiv" runat="server" class="studentForm">
                </div>
                <asp:Button ID="editButton" class="btnck" runat="server" Text="Trở về" OnClick="editButton_Click" Visible="false"/>

            </div>
        </div>
    </form>
    <script src="CKeditor/adapters/jquery.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#<%= submitButton.ClientID %>").click(function () {
                CKEDITOR.instances["<%= descriptionTextBox.ClientID %>"].updateElement();
                return Validate();
            });

            function Validate() {
                var errorMessage = "";

                //Name
                if ($("#<%= nameTextBox.ClientID %>").val() == "")
                    errorMessage += "Tiêu đề không được để trống<br/>";

                if ($("#<%= idcdTextBox.ClientID %>").val() == "")
                    errorMessage += "ID cộng đồng không được để trống<br/>";

                if ($("#<%= idcdeTextBox.ClientID %>").val() == "")
                    errorMessage += "ID chủ đề không được để trống<br/>";
                
                //End

                //Description
                if ($("#<%= descriptionTextBox.ClientID %>").val() == "")
                    errorMessage += "Nội dung không được để trống";
                //End

                if (errorMessage.length == 0)
                    return true;
                else {
                    $("#<%= errorDiv.ClientID %>").html(errorMessage);
                    return false;
                }
            }
        });
    </script>
</body>
</html>
