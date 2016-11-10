﻿<%@ Page Title="" Language="C#" MasterPageFile="~/manager/ManagerMaster.master" AutoEventWireup="true" CodeFile="CrimeManager.aspx.cs" Inherits="manager_CrimeManager" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ManagerMain" runat="Server">
    <div id="content">
        <h2>Detaljer för ärende: 2014-45-0201</h2>
        <p class="info">Du är inloggad som avdelningschef</p>

        <section id="leftColumn">
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
        </section>

        <section id="bottomColumn">
            <h3>Redigera ärende</h3>
            <p>
                Ange handläggare: 
						<select name="investigator">
                            <option selected="selected">Välj</option>
                            <option value="inv1">Ada Bengtsson</option>
                            <option value="inv2">Bengt Cederström</option>
                            <option value="inv3">Cecilia Danielsson</option>
                            <option value="inv4">David Ekström</option>
                            <option value="inv5">Erik Falkenberg</option>
                        </select>
            </p>
            <p>
                <input type="checkbox" name="noAction" value="noAction" />
                Ingen åtgärd:
                <input type="text" name="reason" value="Ange motivering" /></p>
            <p>
                <input class="button" type="submit" value="Spara" /></p>
        </section>
    </div>
    <!-- End Content -->
</asp:Content>

