<%@ Page Title="" Language="C#" MasterPageFile="~/investigator/InvestigatorMaster.master" AutoEventWireup="true" CodeFile="DefaultInvestigator.aspx.cs" Inherits="investigator_DefaultInvestigator" %>


<asp:Content ID="Content2" ContentPlaceHolderID="InvestigatorMaster" Runat="Server">
				<h2>Ärenden</h2>
				<p class="info">Du är inloggad som handläggare</p>
				<table id="managerForm">
					<tr>
						<td class="label">Välj status:</td>
						<td>&nbsp;</td>
						<td class="label">Ärendenummer:</td>
						<td>&nbsp;</td>
					</tr>
					<tr>
						<td>
                            <asp:DropDownList ID="dropDownStatus" runat="server"></asp:DropDownList>
							<%--<select name="status">
								<option selected="selected">Välj alla</option>
								<option value="stat0">Inrapporterad</option>
								<option value="stat1">Ingen åtgärd</option>
								<option value="stat2">Påbörjad</option>
								<option value="stat3">Klar</option>
							</select>--%>
						</td>
						<td><input class="button" type="submit" value="Hämta lista" /></td>
						<td><input name="casenumber" /></td>
						<td><input class="button" type="submit" value="Sök" /></td>
					</tr>
				</table>						
        <asp:GridView ID="gridViewCrimes" runat="server" AutoGenerateColumns="false" GridLines="None">
        <Columns>
            <asp:BoundField  DataField="DateOfObservation" HeaderText="Ärende anmält"/>
            <asp:HyperLinkField DataNavigateUrlFields="ID" HeaderText="Ärendenummer" DataNavigateUrlFormatString="CrimeInvestigator.aspx?ID={0}" DataTextField="ID" />
            <asp:BoundField DataField="TypeOfCrime" HeaderText="Miljöbrott" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="Department" HeaderText="Avdelning" />
            <asp:BoundField DataField="Employee" HeaderText="Handläggare" />
        </Columns>
    </asp:GridView>
				<!--Nedan ser man en lista på ärenden-->
				<%--<table>
					<tr>
						<th>Ärende anmält</th>
						<th>Ärendenummer</th>
						<th>Miljöbrott</th>
						<th>Status</th>
						<th>Avdelning</th>
						<th>Handläggare</th>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0201</a></td>
						<td>Oljeutsläpp</td>
						<td>Ej startad</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ingen utredare satt</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0202</a></td>
						<td>Oljeutsläpp</td>
						<td>Pågående</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ada Bengtsson</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0203</a></td>
						<td>Oljeutsläpp</td>
						<td>Ej startad</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ingen utredare satt</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0204</a></td>
						<td>Oljeutsläpp</td>
						<td>Ej startad</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ingen utredare satt</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0205</a></td>
						<td>Oljeutsläpp</td>
						<td>Pågående</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Bengt Cederström</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0206</a></td>
						<td>Oljeutsläpp</td>
						<td>Ej startad</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ingen utredare satt</td>
					</tr>
					<tr>
						<td>2014-05-01</td>
						<td><a href="CrimeInvestigator.aspx">2014-45-0206</a></td>
						<td>Oljeutsläpp</td>
						<td>Ej startad</td>
						<td>Tekniska avloppshanteringen</td>
						<td>Ingen utredare satt</td>
					</tr>
				</table>--%>

</asp:Content>

