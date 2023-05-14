<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="quantricongdong.aspx.cs" Inherits="LTWde6.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Common" class="tabcontent">
          
    <h3> QUẢN LÝ CỘNG ĐỒNG</h3>
    <form class="quanlicd" id="Form2" runat="server" onsubmit ="return checktrongcd()">
        <div class="form-cd">
            <div class="formquantri">
                    <label for="imgcd">Ảnh:</label>
                         <asp:FileUpload ID="inputAnh1" runat="server" name="myImage" CssClass="form-control" />
                          <asp:Button ID="btnUpLoad" runat="server" Text="Upload" OnClick="btnUpload_Click" CssClass="btn btn-basic"/>
                          <asp:Image ID="Image1" runat="server" Width="150px" />        

            </div>
            <p style="color:red" id="loicdimg"></p>
                <br />
            <div class="formquantri">
                <label for="idcd">Nhập ID cộng đồng:</label>
                <input type="text" id="idcd" name="idcd" value="">
        </div>
        <p style="color:red" id="loicdid"></p>
            <br />
            <%--Giải pc--%>
            <%--Giải pc--%>
            <div class="formquantri">
                <label for="tencd">Nhập tên cộng đồng:</label>
                <input type="text" id="tencd" name="tencd" value="">
        </div>
        <p style="color:red" id="loicdcd"></p>
            <br />
            <%--Giải pc--%>
            <div class="formquantri">
            <label for="tenchude">Nhập tên chủ đề:</label>
            <input type="text" id="tenchude" name="tenchude" value="">

        </div>
        <p style="color:red" id="loicdcde"></p>
            <br />
        <div class="formquantri">
            <label for="idchude">Nhập ID chủ đề:</label>
            <input type="text" id="idchude" name="idchude" value="">
        </div>
                
        <p style="color:red" id="loicdidcde"></p>
            <br />
      </div>
        <div class="submitqt">
            <button type="submit" value="true" name="btnThem" id="btnThem" class="themqt" runat="server">THÊM</button>
        </div>

    </form>

           <form id="idquantricd">
        <table>
          <thead>
            <tr>
              <th style="width: 5%;">STT</th>
              <th style="width: 10%;">ID cộng đồng</th>
              <th style="width: 10%;">Ảnh</th>
              <th style="width: 20%;">Cộng đồng</th>
              <th style="width: 20%;" >Chủ đề</th>
              <th style="width: 15%;">Tác vụ</th>
            </tr>
          </thead>
          <tbody id="idquantricongdong" runat="server">
            
          </tbody>

        </table>
      </form>
      </div>
</asp:Content>
