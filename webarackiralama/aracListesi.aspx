<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aracListesi.aspx.cs" Inherits="webarackiralama.aracListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gridAraclar" runat="server" CellPadding="4" style="margin-top:-50px;margin-left:350px;" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="gridAraclar_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField ItemStyle-Width="250" ItemStyle-HorizontalAlign="Center" DataField="ARACSINIFI" HeaderText="Araç Sınııfı" >
<ItemStyle HorizontalAlign="Center" Width="250px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" DataField="MARKA" HeaderText="Marka" >
<ItemStyle HorizontalAlign="Center" Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" DataField="MODEL" HeaderText="Model" >
<ItemStyle HorizontalAlign="Center" Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" DataField="VITES_ACIKLAMA" HeaderText="Vites" >
<ItemStyle HorizontalAlign="Center" Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" DataField="UYGUN_ACIKLAMA" HeaderText="Uygunluk" >
<ItemStyle HorizontalAlign="Center" Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" CommandName="g" CommandArgument='<%# Eval("ID") %>' Text="Güncelle" />
                    <asp:Button runat="server" CommandName="s" CommandArgument='<%# Eval("ID") %>' Text="Sil" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <a href="aracTanim.aspx">Araç Tanım</a>
</asp:Content>
      
