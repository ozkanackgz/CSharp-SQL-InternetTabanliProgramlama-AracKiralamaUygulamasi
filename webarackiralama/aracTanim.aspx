<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aracTanim.aspx.cs" Inherits="webarackiralama.aracTanim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="margin-top:-50px;margin-left:350px;width:800px;">
        <tr>
            <td style="width:100px;">Sınıfı</td>
            <td style="width:300px;">
                <asp:DropDownList ID="cmbSinifi" Width="200" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width:100px;">Günlük Fiyat
            <td style="width:300px;">
                <asp:TextBox runat="server" ID="txtGunlukFiyat" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtGunlukFiyat" ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Marka</td>
            <td>
                <asp:TextBox runat="server" ID="txtMarka"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMarka" ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>Vites Türü</td>
            <td>
                <asp:RadioButtonList ID="rdVites" runat="server">
                    <asp:ListItem Selected="True" Value="0">Manuel</asp:ListItem>
                    <asp:ListItem Value="1">Otomatik</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Model</td>
            <td>
                <asp:TextBox runat="server" ID="txtModel"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtModel" ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>Model Yılı</td>
            <td>
                <asp:TextBox runat="server" ID="txtModelYil" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtModelYil" ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TextBox runat="server" ID="txtAciklama" TextMode="MultiLine" Width="800" Height="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:CheckBox ID="chkUygun" Text="Araç Uygun" runat="server" />
            </td>
            <td colspan="2">
                <asp:Button runat="server" ID="btnKaydet" Text="Kaydet" OnClick="btnKaydet_Click" />
                <asp:Label runat="server" ID="lblMesaj"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
