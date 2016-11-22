<%@ Page Title="" Language="C#" MasterPageFile="~/coordinator/CoordinatorMaster.master" AutoEventWireup="true" CodeFile="CrimeCoordinator.aspx.cs" Inherits="coordinator_CrimeCoordinator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainCoordinator" runat="Server">
        <h2>Detaljer för ärende:
            <asp:Literal ID="literalCaseId" runat="server"></asp:Literal>
        </h2>
        <p class="info">Du är inloggad som samordnare</p>
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


        <%--        <section id="leftColumn">
            <h3>Anmälan</h3>
            <p>
                <span class="label">Typ av brott: </span>
                <br />
                Nedskräpning
            </p>
            <p>
                <span class="label">Brottsplats: </span>
                <br />
                Skogslunden vid Jensens gård
            </p>
            <p>
                <span class="label">Brottsdatum: </span>
                <br />
                2014-04-24
            </p>
            <p>
                <span class="label">Anmälare: </span>
                <br />
                Maja Färjedal
            </p>
            <p>
                <span class="label">Telefon: </span>
                <br />
                432-554 55 22
            </p>
            <p>
                <span class="label">Observationer:</span><br />
                Jag upptäckte soporna på en promenad den 24 april
            </p>
        </section>

        <section id="rightColumn">
            <h3>Utredning</h3>
            <p>
                <span class="label">Status:</span><br />
                Pågående 
            </p>
            <p>
                <span class="label">Ansvarig avdelning: </span>
                <br />
                Tekniska avloppshanteringen
            </p>
            <p>
                <span class="label">Handläggare: </span>
                <br />
                Ada Bengtsson
            </p>
            <p>
                <span class="label">Provtagning: </span>
                <br />
                Provtagning.pdf
            </p>
            <p>
                <span class="label">Ytterligare information: </span>
                <br />
                Bland soporna hittades ett brev adresserat till Gösta Olsson
            </p>
            <p>
                <span class="label">Händelser: </span>
                <br />
                Brev skickat till Gösta Olsson om soporna och anmälan som är gjord till polisen 2014-05-20
            </p>
            <p>
                <span class="label">Bilder: </span>
                <br />
                <img src="../images/imagetest.jpg" alt="klicka på bilden" />
            </p>
        </section>--%>



        <section id="bottomColumn">
            <h3>Redigera ärende</h3>
            <p>
                Ange enhet: 
						<select name="department">
                            <option selected="selected">Välj</option>
                            <option value="unit0">Småstads Kommun</option>
                            <option value="unit1">Tekniska Avloppshantering</option>
                            <option value="unit2">Klimat och Energi</option>
                            <option value="unit3">Miljö och Hälsoskydd</option>
                            <option value="unit4">Natur och Skogsvård</option>
                            <option value="unit5">Renhållning och Avfall</option>
                        </select>
            </p>
            <p>
                <input class="button" type="submit" value="Spara" />
            </p>
        </section>

</asp:Content>

