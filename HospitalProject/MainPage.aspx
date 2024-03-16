<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="HospitalProject.MainPage" %>

<paddings padding="0px" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content/Style.css" />
</head>
<body>
    <form id="form1" runat="server" >
        <div class="background_contain" style="background-image: url('Content/200w.gif'); background-repeat: no-repeat;">
            <h1 style="text-align: center; font-family:'French Script MT';font-size:55px; color: white">CRITI CARE</h1>
            <div style="padding-left: 1200px; padding-top: 0px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="48px" ImageAlign="Top" ImageUrl="~/Content/LoginImg.png" OnClick="ImageButton1_Click" Width="87px" />
            </div>
            <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/ADroatater.xml"></asp:XmlDataSource>
            <div style="padding-left: 595px">
                <asp:Button CssClass="buttonCR" ID="EmergencyForm" runat="server" Text="Emergency Form" Height="56px" Width="311px" BorderColor="Black" BackColor="White" OnClick="EmergencyForm_Click1" />
                <br />
                <br />
                <asp:Button CssClass="buttonCR" ID="Appointment" runat="server" Text="Appointment" Height="56px" Width="311px" BorderColor="Black" BackColor="White" OnClick="Appointment_Click1" />
            </div>
            <div style="padding-left: 0px">
                <asp:AdRotator ID="AdRotator3" runat="server" DataSourceID="XmlDataSource3" />
                <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/ADRotater3.xml"></asp:XmlDataSource>
            </div>
        </div>
    </form>
</body>
</html>

