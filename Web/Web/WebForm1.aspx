<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="/Content/bootstrap.css" rel="stylesheet"/>
<link href="/Content/Site.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Log in.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Use a local account to log in.</h4>
                    <hr />
                    
                    <div class="form-group">
                        <label for="MainContent_Email" class="col-md-2 control-label">Email</label>
                        <div class="col-md-10">
                            <input name="ctl00$MainContent$Email" type="email" id="MainContent_Email" class="form-control" />
                            <span data-val-controltovalidate="MainContent_Email" data-val-errormessage="The email field is required." id="MainContent_ctl01" class="text-danger" data-val="true" data-val-evaluationfunction="RequiredFieldValidatorEvaluateIsValid" data-val-initialvalue="" style="visibility:hidden;">The email field is required.</span>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="MainContent_Password" class="col-md-2 control-label">Password</label>
                        <div class="col-md-10">
                            <input name="ctl00$MainContent$Password" type="password" id="MainContent_Password" class="form-control" />
                            <span data-val-controltovalidate="MainContent_Password" data-val-errormessage="The password field is required." id="MainContent_ctl03" class="text-danger" data-val="true" data-val-evaluationfunction="RequiredFieldValidatorEvaluateIsValid" data-val-initialvalue="" style="visibility:hidden;">The password field is required.</span>
                        </div>
                    </div>
    </div>/div>/div>/div>
    </form>
</body>
</html>
