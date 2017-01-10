<%@ Page Title="" Language="C#" MasterPageFile="~/manager/ManagerMaster.master" AutoEventWireup="true" CodeFile="DefaultManager.aspx.cs" Inherits="manager_DefaultManager" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ManagerMain" runat="Server">

    <div id="content">
        <h2>Ärenden</h2>
        <p class="info">Du är inloggad som avdelningschef</p>

        <table id="managerForm">
            <tr>
                <td class="label">Välj status:</td>
                <td class="label">Välj handläggare:</td>
                <td>&nbsp;</td>
                <td class="label">Ärendenummer:</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dropDownStatus" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dropDownInvestigator" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <input class="button" type="submit" value="Hämta lista" /></td>
                <td>
                    <input name="casenumber" /></td>
                <td>
                    <input class="button" type="submit" value="Sök" /></td>
            </tr>
        </table>

      <asp:GridView ID="gridViewCrimes" runat="server" AutoGenerateColumns="false" GridLines="None">
        <Columns>
            <asp:BoundField  DataField="DateOfObservation" HeaderText="Ärende anmält"/>
            <asp:HyperLinkField DataNavigateUrlFields="ID" HeaderText="Ärendenummer" DataNavigateUrlFormatString="CrimeManager.aspx?ID={0}" DataTextField="ID" />
            <asp:BoundField DataField="TypeOfCrime" HeaderText="Miljöbrott" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="Department" HeaderText="Avdelning" />
            <asp:BoundField DataField="Employee" HeaderText="Handläggare" />
        </Columns>
    </asp:GridView>
    </div>
    <!-- End Content -->
</asp:Content>

