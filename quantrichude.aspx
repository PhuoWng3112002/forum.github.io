<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="quantrichude.aspx.cs" Inherits="LTWde6.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Forum" class="tabcontent">
          <h3> QUẢN LÝ CHỦ ĐỀ</h3>
    
    <form class="quanlicde" id="quanlychude" runat="server" onsubmit ="return checktrongqt()">
        <div class="formquantri">
            <label for="inputAnh1" class="col-sm-2 col-form-label">Ảnh</label>
			
                     <asp:FileUpload ID="inputAnh1" runat="server" name="myImage" CssClass="form-control" />
                      <asp:Button ID="btnUpLoad" runat="server" Text="Upload" OnClick="btnUpload_Click" CssClass="btn btn-basic"/>
                      <asp:Image ID="Image1" runat="server" Width="150px" />	
        </div>
        
        <p style="color:red" id="loiqtimg"></p>
        <div class="form-cde">
        <div class="formquantri">
            <label for="idcde">Nhập ID chủ đề:</label><br />
            <input type="text" id="idcde" name="idcde" value="" />
        </div>
        <p style="color:red" id="loiqtid"></p>
            <br />
        <div class="formquantri">
            <label for="tenchude">Nhập tên chủ đề:</label><br />
            <input type="text" id="chudeqt" name="chudeqt" value="">
        </div>
        <p style="color:red" id="loiqtcde"></p>
            <br />
        <div class="submitqt">
            <button type="submit" value="true" name="btnThem" id="btnThem" class="themqt">THÊM</button>
            <button type="submit" value="true" name="btnUpdate" id="btnUpdate" class="themqt" style="display:none">THÊM</button>

        </div>
        <p style="color:red" id="loiqt" runat="server"></p>
        </div>

    </form>

    <form id="idquantricde">
        <table>
          <thead>
            <tr>
              <th style="width: 10%;">STT</th>
              <th style="width: 35%;">Tên chủ đề</th>
              <th style="width: 35%;">Hình ảnh</th>
              <th style="width: 20%;">Tác vụ</th>
              
            </tr>
          </thead>
            
          <tbody id="idquantrichude" name="idquantrichude" runat="server">
           
          </tbody>

        </table>
      </form>
      </div>
</asp:Content>
