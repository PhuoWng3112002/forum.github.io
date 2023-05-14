
function xulydulieu() {
    trangthai = true;
    var txtEmail = document.getElementById("txtEmail").value;
    var email_loi = document.getElementById("email_loi");

    var txtPass = document.getElementById("txtPass").value;
    var pass_loi = document.getElementById("pass_loi");


    if (txtEmail == "") {
        email_loi.innerHTML = "Email không được bỏ trống";
        trangthai = false;
    } else {
        trangthai = true;
    }
    if (txtPass == "") {
        pass_loi.innerHTML = "Mật khẩu không được để rỗng";
        trangthai = false;
    } else if (txtPass.length < 8) {
        pass_loi.innerHTML = "Mật khẩu phải dài hơn 8 ký tự";
        trangthai = false;
    } else {
        trangthai = true;
    }

    return trangthai;
}
function xulydulieu_dangky() {

    var formatEmail = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    const email = document.querySelector("#txtEmail").value;
    /********************/
    trangthai = true;
    var txtEmail = document.getElementById("txtEmail").value;
    var email_loi = document.getElementById("email_loi");
    var email_format = document.getElementById("email_format");
    var txtPass = document.getElementById("txtPass").value;
    var pass_loi = document.getElementById("pass_loi");

    var txtRePass = document.getElementById("txtRePass").value;
    var repass_loi = document.getElementById("repass_loi");

    
    if (txtEmail == "") {
        email_loi.innerHTML = "Email không được bỏ trống";
        trangthai = false;
    } 
    
    if (formatEmail.test(email) == false) {
        email_format.innerHTML = "Sai định dạng mail";
        trangthai = false;

    } 


    if (txtPass == "" && txtPass.length < 8) {
        pass_loi.innerHTML = "Mật khẩu không được để trống và phải dài hơn 8 kí tự";
        trangthai = false;
    }
     

    if (txtRePass == "" && txtRePass.length < 8) {
        repass_loi.innerHTML = "Mật khẩu không được để trống và phải dài hơn 8 kí tự";
        trangthai = false;
    }


    if (txtPass != txtRePass) {
        repass_loi.innerHTML = "Mật khẩu không trùng khớp";
        trangthai = false;
    } 

    return trangthai;
}
function showpass() {
    var ckbHienMK = document.getElementById("ckbHienMK");
    var txtPass = document.getElementById("txtPass");

    if (ckbHienMK.checked == false) {
        txtPass.type = "password";
    } else {
        txtPass.type = "text";
    }
}
function showpass_dangky() {
    var ckbHienMK = document.getElementById("ckbHienMK");
    var txtPass = document.getElementById("txtPass");
    var txtRePass = document.getElementById("txtRePass");

    if (ckbHienMK.checked == false) {
        txtPass.type = "password";
        txtRePass.type = "password";
    } else {
        txtPass.type = "text";
        txtRePass.type = "text";
    }
}