<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="trangcongdong.aspx.cs" Inherits="LTWde6.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="public/trangcongdong.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
          <div class="main-content">
            <div class="row">
                <div class="cong-dongbv">

                    <div class="bai-viet">
                
                      <div class="noidung-chinh">
                        <div class="imagebv">
                            <img src="img/doisong.jpg" />
                        </div>
                        <div class="noi-dung">
                          <a>Khoa học vũ trụ</a>

                           <p>0 Thành viên   &nbsp;&nbsp;&nbsp;&nbsp;  1 Bài viết</p>
                          <input class="tham-gia" type="submit" value="Tham Gia">
                        </div>
                      </div>
                    </div>
                  </div>
              <div class="leftcolumn">
                <div class="2tab">
                        <%--<button class="btntab" onclick="openPage('Baiviet', this)"id="defaultOpen">Bài viết</button>
                        <button class="btntab" onclick="openPage('Gioithieu', this)" >Giới thiệu</button>--%>


                        <div id="Baiviet" class="noidungtab">
                            <div class="share-bn">

                                <div class="total">
                                  <div class="box-circle">
                                    <img class="avt" src="./img/avatar.png" alt="" >
                                  </div>
                                  <div class="box-tool">
                                    <a href="ckeditor.aspx"><input class="stt" type="text" placeholder="&nbsp;Cảm ơn bạn đã đến với cộng đồng. Hãy chia sẻ điều gì đó..."></a> 
                                  </div>
                                  <div class="dang-bai">
                                     <a href="ckeditor.aspx"><input class="post" type="submit" value="Đăng bài"></a>
                                  </div>
                                </div>
                              </div>
                              <!-- Giải phân cách -->
                              <form class="filter" >
                                <select class="op" name="filter" id="filter">
                                  <option value="tuongtacmoinhat">Tương tác mới nhất</option>
                                  <option value="baivietganday">Bài viết gần đây</option>
                                </select>
                                
                              </form>
                             
                                <!-- Giải phân cách -->
                            <div class="general" id="listbaiviet" runat="server">

                            </div>
                    </div>
                        <%--<div id="Gioithieu" class="noidungtab">
                            <p>Trang được lập ra để cùng chia sẻ những kiến thức bổ ích. Mọi người cùng học hỏi, cùng phát triển.</p>

                        </div>--%>
            </div>


              </div>
              <div class="rightcolumn">
                <div class="right1">
                  <div class="right-title"><p>_____Quan tâm nhiều nhất_____</p></div>
                  <div id="rightcontent" class="listcd" runat="server"></div>
                  </div>
                  <div class="right2">
                    <div class="right-title"><p>_____Bài viết phổ biến_____<p></div>
                    <div class="right-congdong">
                        <div class="phobien" id="listphobien" runat="server">
                            <p><i class="fas fa-circle"></i>&nbsp;&nbsp;&nbsp;&nbsp;Cổ phiếu nhóm FLC bị bán tháo</p>
                        </div>
                    </div> 
                  </div>
              </div>    
          </div>
  </div>
  </div>

</asp:Content>
