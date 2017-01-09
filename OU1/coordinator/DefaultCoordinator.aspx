<%@ Page Title="" Language="C#" MasterPageFile="~/coordinator/CoordinatorMaster.master" AutoEventWireup="true" CodeFile="DefaultCoordinator.aspx.cs" Inherits="coordinator_DefaultCoordinator" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainCoordinator" runat="Server">
        <h2>Ärenden</h2>
        <p class="info">Du är inloggad som samordnare</p>
    <table id="managerForm">
        <tr>
            <td class="label">Välj status:</td>
            <td class="label">Välj avdelning:</td>
            <td>&nbsp;</td>
            <td class="label">Ärendenummer:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="dropDownStatus" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="dropDownDepartment" runat="server"></asp:DropDownList>
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
            <asp:HyperLinkField DataNavigateUrlFields="ID" HeaderText="Ärendenummer" DataNavigateUrlFormatString="CrimeCoordinator.aspx?ID={0}" DataTextField="ID" />
            <asp:BoundField DataField="TypeOfCrime" HeaderText="Miljöbrott" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="Department" HeaderText="Avdelning" />
            <asp:BoundField DataField="Employee" HeaderText="Handläggare" />
        </Columns>
    </asp:GridView>
</asp:Content>

