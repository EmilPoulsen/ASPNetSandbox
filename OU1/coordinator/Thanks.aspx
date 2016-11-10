<%@ Page Title="" Language="C#" MasterPageFile="~/coordinator/CoordinatorMaster.master" AutoEventWireup="true" CodeFile="Thanks.aspx.cs" Inherits="coordinator_Thanks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainCoordinator" runat="Server">
    <div id="content">
        <h2>Tack för din anmälan</h2>
        <p class="info">Du är inloggad som samordnare</p>

        <p>
            Anmälan har nu skickats in till kommunen och kommer att utredas.
            <br />
            Vill du komplettera din anmälan kontakta oss via mail eller telefon.
            <br />
            Ange då nummer: 2014-45-0201
        </p>

        <p><a class="button" href="DefaultCoordinator.aspx">Avsluta rapporteringen</a></p>

    </div>
    <!-- End Content -->
</asp:Content>

