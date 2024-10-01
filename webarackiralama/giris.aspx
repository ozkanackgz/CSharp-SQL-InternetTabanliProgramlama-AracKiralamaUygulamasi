<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="webarackiralama.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>    
            <table style="width:400px;">
                <tr>
                    <td style="width:30%;">Kullanıcı Adı:</td>
                    <td>
                        <asp:TextBox ID="txtKullaniciAdi" runat="server" MaxLength="40"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rq1" runat="server" ControlToValidate="txtKullaniciAdi" Display="Dynamic" ErrorMessage="* Boş geçilemez" Font-Bold="True" Font-Italic="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Şifre :</td>
                    <td>
                        <asp:TextBox ID="txtSifre" runat="server" MaxLength="40" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSifre" Display="Dynamic" ErrorMessage="* Boş geçilemez" Font-Bold="True" Font-Italic="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSistemeGiris" runat="server" Text="Sisteme Giriş" OnClick="btnSistemeGiris_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
