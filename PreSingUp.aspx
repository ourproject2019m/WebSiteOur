<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageForHomeP.master" AutoEventWireup="true" CodeFile="PreSingUp.aspx.cs" Inherits="PreSingUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="text-center">
            <h1 class="text-muted align text-center">בחר סוג משתמש</h1><br />                                           
        </div>
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-4">
        <a href="SingUp.aspx?type=b">
            <img src="img/babysitter.png" class="rounded mx-auto d-block" width="250" height="250" />
        </a>
            </div>
                <div class="col-md-4">
        <a href="SingUp.aspx?type=p">
            <img src="img/family.png" class="rounded mx-auto d-block"  width="250" height="250"/>
        </a>
            </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>

