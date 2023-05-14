<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="quantribaiviet.aspx.cs" Inherits="LTWde6.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Artical" class="tabcontent">
        <button class="thaotacthem"><a href="ckeditor.aspx">Thêm bài viết</a></button>
        <h3>Quản lý bài viết</h3>

      <form id="idquantribv" action="quantri.aspx" method="get">
        <table>
          <thead>
            <tr>
              <th style="width: 5%;">STT</th>
              <th style="width: 10%;">Cộng đồng</th>
              <th style="width: 15%;">Tiêu đề</th>
              <th style="width: 30%;" >Nội dung</th>
              <th style="width: 15%;">Ngày đăng</th>
              <th style="width: 15%;">Tác vụ</th>
            </tr>
          </thead>
             <tbody id="idquantribaiviet" runat="server">
            </tbody>

        </table>
      </form>
      </div>
      <div id="User" class="tabcontent">

      </div>

</asp:Content>
