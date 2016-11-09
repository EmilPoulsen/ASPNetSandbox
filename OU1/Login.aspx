﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PublicUserMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

    				<section id="mainColumn">
					<h2>Inloggning för Småstads personal</h2>
					<p class="info">En säker tjänst från Småstads IT-avdelning</p>

					<form method="post" action="coordinator/startCoordinator.html">
						<p>
							<input type="hidden" name="isSubmitted" value="true" />
						</p>
						<p>
							<span class="label">Användarnamn:</span><br />
							<input type="text" name="user"/>
						</p>
						<p>
							<span class="label">Lösenord:</span><br />
							<input type="password" name="password" />
						</p>
						<p>
							<input class="button" type="submit" value="Inloggning av samordnare" />
							<br />
							<!--Dessa länkar ska sedan tas bort då det är meningen att vid kontrollen av inloggningsuppgifter så hämtas rätt sida-->
							<a class="button" href="manager/startManager.html">Inloggning av chefer</a><br />
							<a class="button" href="investigator/startInvestigator.html">Inloggning av handläggare</a>
						</p>
					</form>
				</section><!-- End Left -->
			
</asp:Content>

