<%@ Page Title="" Language="C#" MasterPageFile="~/investigator/InvestigatorMaster.master" AutoEventWireup="true" CodeFile="CrimeInvestigator.aspx.cs" Inherits="investigator_CrimeInvestigator" %>

<asp:Content ID="Content2" ContentPlaceHolderID="InvestigatorMaster" Runat="Server">
    <div id="content">
        <h2>Detaljer för ärende:
            <asp:Literal ID="literalCaseId" runat="server"></asp:Literal>
        </h2>
        <p class="info">Du är inloggad som handläggare</p>
        <asp:FormView ID="formViewSpecificCrime" runat="server">
            <ItemTemplate>
                <section id="leftColumn">
                    <h3>Anmälan</h3>
                    <p>
                        <asp:Literal ID="Literal1" runat="server"> <b>Typ Av brott: </b> <br /></asp:Literal>
                        <%# Eval("TypeOfCrime") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal2" runat="server"><b>Brottsplats:</b> <br /></asp:Literal>
                        <%# Eval("Place") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal3" runat="server"><b>Brottsdatum: </b> <br /></asp:Literal>
                        <%# Eval("DateOfObservation") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal4" runat="server"><b>Anmälare: </b> <br /></asp:Literal>
                        <%# Eval("InformerName") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal5" runat="server"><b>Telefon: </b> <br /></asp:Literal>
                        <%# Eval("InformerPhone") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal6" runat="server"><b>Observationer:</b> <br /></asp:Literal>
                        <%# Eval("Observation") %>
                    </p>
                </section>
                <section id="rightColumn">
                    <h3>Utredning</h3>
                    <p>
                        <asp:Literal ID="Literal7" runat="server"> <b>Status: </b> <br /></asp:Literal>
                        <%# Eval("TypeOfCrime") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal8" runat="server"><b>Ansvarig avdelning:</b> <br /></asp:Literal>
                        <%# Eval("Department") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal9" runat="server"><b>Handläggare:</b> <br /></asp:Literal>
                        <%# Eval("Employee") %>
                    </p>
                    <p>
                        <span class="label">Provtagning: </span>
                        <br />
                        Provtagning.pdf
                    </p>
                    <p>
                        <asp:Literal ID="Literal11" runat="server"><b>Ytterligare information:</b> <br /></asp:Literal>
                        <%# Eval("Info") %>
                    </p>
                    <p>
                        <asp:Literal ID="Literal12" runat="server"><b>Händelser: </b> <br /></asp:Literal>
                        <%# Eval("Action") %>
                    </p>
                    <p>
                        <span class="label">Bilder: </span>
                        <br />
                        <img src="../images/imagetest.jpg" alt="klicka på bilden" />
                    </p>
                </section>
            </ItemTemplate>
        </asp:FormView>
				<section id="bottomColumn">
					<h3>Redigera ärende</h3>
					<p class="label">Händelser:</p>
					<textarea name="events" rows="5" cols="60"></textarea>
					<p class="label">Mer information:</p>
					<textarea name="information" rows="5" cols="60"></textarea>
					
					<p class="label">Prover:</p>
					<input type="file" name="loadImage" />
					
					<p class="label">Ladda upp bilder:</p>
					<input type="file" name="loadImage" />
					
					<p class="label">Ändring av status:</p>
					<select name="status">
						<option selected="selected">Välj</option>
						<option value="stat1">Inrapporterad</option>
						<option value="stat2">Ingen Åtgärd</option>
						<option value="stat3">Påbörjad</option>
						<option value="stat4">Klar</option>
					</select>

					<p>
						<input class="button" type="submit" value="Spara ändringarna" />
					</p>
				</section>
			</div><!-- End Content -->
</asp:Content>

