using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BilderApp1
{
    class ViewModel1 : List<Model1>
    {
       private Model1[] karte = new Model1[35];    
       public ViewModel1() : base()
        {
            Update();       
        }
        private  void Update()
        {  
//1. Klausur         
karte[0] = new Model1("1", "Führen Sie die horizontalen Bilanzkennzahlen inkl. Formel auf", "AD I=EK/AV*100," + Environment.NewLine + " Richtwert 70 - 100%," + Environment.NewLine + " goldene Bilanzregel," + Environment.NewLine + " ADII=(EK*LFK)/AV*100, Richtwert: 100 %," + Environment.NewLine + " LI =flüssige Mittel/KFK*100 Richtwert: 30 %," + Environment.NewLine + " LII= LI+ Forderungen/KFK*100 Richtwert: 100%," + Environment.NewLine + " LIII= UV/KFK*100 Richtwert: 120%," + Environment.NewLine + " working capital/Betriebskapital=UV-KFK" +  Environment.NewLine+ 
           " Positives WC, dann deckt UV die KFK ab, WC kann durch JIT reduziert werden, negativer Wert=Verstoß gegen goldene Bilanzregel, da AV von KFK finanziert");
karte[1] = new Model1("2", "Führen Sie die vertikalen Bilanzkennzahlen inkl. Formel auf", "Vermögensstruktur: AI=AV/GK*100," + Environment.NewLine + "je geringer, je flexibler, je höher, je sicherer, " + Environment.NewLine + "Umlaufintensität=UV/GV*100" + Environment.NewLine + " Kapitalstruktur:EK-Quote=EK/GK*100,mind. 30% " + Environment.NewLine + "FK-Quote=FK/GK*100, 70 %," + Environment.NewLine + " VG=FK/EK*100, max 200 %");
karte[2] = new Model1("3", "Führen Sie die Erfolgskennzahlen inkl. Formel auf", "Absolute:Umsatz, JÜ, EBIT(Betriebsergebnis)," + Environment.NewLine + " relative:Wirtschaftlichkeit: Leistung/Kosten: Richtwert >1, " + Environment.NewLine + "Rentabiltätsanalyse:  U-R/EK-R: JÜ*100/Umsatz oder EK  ," + Environment.NewLine + " GK-R: GK=(JÜ*FK-Zins)/GK*100," + Environment.NewLine + " Ebit-Marge=Ebit/Umsatz*100, KU=U/K, die Höhe des KU hat Auswirkungen auf R, je höher desto weniger K-Einsatz für U ");
karte[3] = new Model1("4", "Erklären Sie den Leverage-Effekt", "Hebeleffekt des FK auf EK-R," + Environment.NewLine + " Voraussetzung GKR liegt über FK-Zins, durch Ersatz von EK durch FK wird die EK-R erhöht." + Environment.NewLine+ 
                "Problem: Steigende Kreditsumme= steigende Zinsen, Kreditaufnahme beschränkt");
karte[4] = new Model1("5", "Beschreiben Sie das Kennzahlensystem von DuPont", "Gesamtrentabilität wird untersucht durch zwei Bäume:" + Environment.NewLine + " Kapitalumschlag und Umsatzrentabilität ");
karte[5] = new Model1("6", "Stellen Sie den Aufbau eines Berichts zur Beschreibung der finanziellen Situation dar", "Einleitung: Kennzahlenanalyse basierend auf...,  Unternehmensangaben, Branche, Zeitraum(Wer, Was, Wann, Wo)," +
                "Dashboard, vom Allgmeinen zum Speziellen, z.B. Bilanzsumme zu einzelnen Pos. oder von RKI zu RKII(Was, Wie, Warum), Schluss: Folgen z. B. auf die Entwicklung des ROI");
karte[6] = new Model1("7", "Nennen Sie drei Arten der Abschreibung", "lineare, degressive und Leistungsabschreibung");
karte[7] = new Model1("8", "Welche Konten werden bei Privatentnahmen von Gegenständen eines Komplemtärs angesprochen ", "Privat an EvGuSl, Ust");
karte[8] = new Model1("9", "Was versteht man unter Aktivierung oder Passivierung", " Bilanzierung eines Postens auf der Aktivseite der Bilanz oder Passivseite" + Environment.NewLine + "Z. B.: die Umsatzsteuerzahllast oder den Vorsteuerüberhang im Dezember");
karte[9] = new Model1("10", "Unterscheiden Sie das Gesamtkosten- und das Umsatzkostenverfahren", "Bei dem Gesamtkostenverfahren (Produktionserfolgsrechnung) werden alle Aufwendungen einer Periode allen Erträgen (auch aktivierte Eigenleistungen, sonstige betriebliche Erträge) inkl. der Bestandsminderung und Bestandsmehrungen gegenüber gestellt." + Environment.NewLine +"Ergebnis: Jahresüberschuss/-verlust" + Environment.NewLine + "Bei dem Umsatzkostenverfahren (Umsatzerfolgsrechnung) werden von den Erträgen einer Periode die Aufwendungen abgezogen. Erhöhungen des Bestands an fertigen und unfertigen Erzeugnissen sowie selbst erstellte Sachanlagen werden nicht als Erträge und die dafür angefallenen Aufwendungen nicht als Aufwendungen erfasst. Verminderungen des Bestands an fertigen und unfertigen Erzeugnissen werden als Aufwendungen für abgesetzte Erzeugnisse ausgewiesen.  " + Environment.NewLine + "Ergebnis: Jahresüberschuss/-verlust"  + Environment.NewLine + "Darstellung in Konten- oder Staffelform");
karte[10] = new Model1("11", "Erklären Sie, warum die Minderbestände an FE auf der Sollseite des GuV auszuweisen sind?", "Minderbestände führen zu Umsätzen in der aktuellen Periode, während die Kosten in der vorherigen Periode entstanden sind." + Environment.NewLine + " Deshalb müssen die Minderungen auf der Sollseite des GuVs erfasst werden");
karte[11] = new Model1("12", "Beschreiben Sie die Auswirkung von BV auf den Erfolg?", "Der Erfolg des Unternehmenes bleibt gleich, egal, ob das Umsatz- oder das Gesamtkostenverfahren angewandt wird. Beim Gesamtkostenverfahren werden die Bestandsmehrungen/-minderungen erfasst und ebenso die entsprechenden Aufwendungen bzw. Erträge." + Environment.NewLine + "Beim Umsatzkostenverfahren werden nur die Umsätze und die entsprechende Kosten der Periode (ggf. Bestandsminderungen. Bestandsmehrungen werden nicht erfasst. ");
//2. KLausur
karte[12] = new Model1("13", "Was unterscheidet bestands- und aufwandsorientierte Erfassung der Beschaffung", " In Unternehmen mit klassischer Lagerhaltung werden die Zu- und Abgänge auf dem Bestandskonten erfasst (Bestandsorientiert)." + Environment.NewLine + " In Unternehmen die Jit arbeiten, erfolgt die Buchung der Zu- und Abgänge auf den Aufwandskonten.");
karte[13] = new Model1("14", "Auf welche Konten werden Zollverbindlichkeiten verbucht?", "Bezugskosten als Unterkonto des jeweiligen Bestands- oder Aufwandskontos");
karte[14] = new Model1("15", "Wo erfolgt die Besteuerung bei Handelsgeschäften im Gemeinschaftsgebiet oder im Drittland ", "Im Bestimmungsland, Bestimmungslandprinzip, Privatkauf: Herkunftslandprinzip," + Environment.NewLine + " Ausnahme PKW-Kauf hier gilt auch das Bestimmungslandprinzip");
 karte[15] = new Model1("16", "Was unterscheidet das Brutto- und Nettoverfahren bei der Buchung eines Zahlungseingangs mit Skontoabzug?", "Beim Bruttoverfahren wird die Erlösberichtigung ohne Korrektur der Ust verbucht, diese wird separat korrigiert." + Environment.NewLine + " Beim Nettoverfahren wird die Erlösberichtigung sofort um die Ust korrigiert");
karte[16] = new Model1("17", "Nennen Sie die Säulen der Sozialversicherung", "Arbeitslosen-, Renten-, Kranken-, Pflege- und Unfallversicherung");
karte[17] = new Model1("18", "Erläutern Sie, was antizipative und transitorische Posten sind.", " Antizipativ: Sonstige Forderungen, Sonstige Verbindlichkeiten" + Environment.NewLine + " Der Erfolg wird im alten Jahr vorweggerechnet, ohne das ein Zahlungsvorgang erfolgte." + Environment.NewLine + " Zahlung nachträglich im neuen Jahr" + Environment.NewLine + " Transitorisch: Aktive Rechnungsabgrenzung (ARA), Passive Rechnungsabgrenzung(PRA)." + Environment.NewLine + " Ein Transport von Erfolg / Aufwand aus dem alten ins neue Jahr. Erfolg geht periodisch voraus und wird ins neue Jahr transportiert." + Environment.NewLine + "Zahlung im voraus im alten Jahr." + Environment.NewLine );
karte[18] = new Model1("19", "Wie entstehen die Preise", "Vollkostenrechnung, Konkurrenzvergleich, Teilkostenrechnung (DB), Nachfragebeobachtung");
karte[19] = new Model1("20", "Nennen Sie die Prinzipien, denen die FiBu und die Kostenrechnung folgen.", " Steuerminimierung , Substanzerhalt ");
karte[20] = new Model1("21", "Erklären Sie Grund-, Anders-, Zusatzkosten", "Grundkosten sind aufwandsgleich, Anderskosten fließen in anderer Höhe in die Kosten ein (Abschreibung)," + Environment.NewLine + " Zusatzkosten sind nicht in der FiBu/GuV zu finden, z. B. Unternehmerlohn ");
karte[21] = new Model1("22", "Beschreiben Sie den Aufbau einer Ergebnistabelle", "RKI=Guv(Zahlen der FiBu)," + Environment.NewLine + " RKII neutrales Ergebnis(ordentlich, periode, betrieblich)," + Environment.NewLine + " dann kalk. Abgrenzung (Anders+ Zusatz), " + Environment.NewLine + "danach Betriebsergebnis (Kosten und Leistungen)");
karte[22] = new Model1("23", "Erläutern Sie das Konzept des betriebsnotwendigen Kapitals", "Das BK wird zur Berechnung der kalkulatorischen Zinsen ermittelt. Hierfür wird im ersten Schritt das betriebsnotwendige Vermögen ermittelt( kalk. Restwerte, Wiederbeschaffungskosten, stillgelegte Anlagen, betrieblich notwendige Vermögensgegenstände)" +
                ", von diesem Vermögen wird das Abzugskapital subtrahiert(nicht skontierbare VLL, Anzahlungen, Rückstellungen");  
karte[23]=new Model1("24","Nennen Sie die Arten der Innen- und Außenfinanzierung.","Innen: Selbstfin. durch Gewinn, Rückstellung,Abschreibung, Vermögensumschichtung" + Environment.NewLine + "Beteiligungsfin., Kreditfin.");
karte[24]=new Model1("25","Erklären Sie Mezzanine Finanzierung","mezzo=halb, halb EK + halb FK: Z.B.: Stille Beteiligung, Crowdfunding(Gruppenfinanzierung)...");
karte[25]=new Model1("26","Was ist Gewinnthesaurierung?","thesauros=Schatzhaus, Gewinneinbehaltung");            
//3. Klausur 
karte[26] = new Model1("27", "Erklären Sie die Zielsetzung beim  Einsatz des BAB", "Verteilung der Gemeinkosten auf die Kostenstellen zur Ermittlung der Zuschlagssätze für die Kalkulation, bzw. Überprüfung/Anpassung der Sätze.");
 karte[27] = new Model1("28", "Nach welchem Prinzip werden die Zuschlagsgrundlagen beim BAB ausgewählt?","Nach dem Prinzip der Verursachung. Bsp.: Das Material verursacht die Gemeinkosten in der Kostenstelle Material." );  
karte[28] = new Model1("29", "Was sind Normalzuschlagssätze?", "Dies sind Durchschnittswerte der letzte Perioden, sie dienen als Kalkulationsgrundlage, mit den Istzuschlägssätzen werden diese auf Über- oder Unterdeckung geprüft.");
karte[29] = new Model1("30","Erklären Sie die Entstehung eines mehrstufigen BAB", "Die Gemeinkosten werden aus der Betriebsergebnisrechnung übernommen und mittels der Verteilungsgrundlagen(Entnahmescheine, Schlüssel, Schätzung...) auf die Kostenstellen verteilt. Die Allgemeinen Kostenstellen werden danach auf die Hauptkostenstellen verteilt. Die Hilfskostenstellen werden der jeweiligen Hauptkostenstellen zu gerechnet. Durch diese Maßnahme entstehen die Stufen im BAB. Die Kostenstellen werden addiert und mittels der Zuschlagsgrundlagen (Einzelkosten/HDU) ermittelt." + Environment.NewLine);
karte[30] = new Model1("31", "Erläutern Sie die Ermittlung der HdU", "Herstellkosten der Fertigung + Bestandsminderung/-Bestandsmehrung");            
karte[31] = new Model1("32", "Begründen Sie, warum Minderbestände bei der Ermittlung der HDU den HDF hinzu gerechnet werden", "Minderbestände wurde in der Vorperiode produziert und kostenrechnerisch erfasst und müssen deshalb hinzugerechnet werden" + Environment.NewLine + 
                "Mehrbestände werden in dieser Periode produziert und kostenrechnerisch erfasst, diese werde abgezogen, da sie nicht verkauft werden, es geht ja um die Herstellkosten des Umsatzes!");        
karte[32] = new Model1("33", "Listen Sie unterschiedliche Fertigungsverfahren auf und ordnen Sie diesen das entsprechende Kalkulationsverfahren zu",
                "Einzelfertigung=summarische Zuschlagskalkulation," + Environment.NewLine + " Massenfertigung=Divisionskalkulation (Selbstkosten=Gesamtkosten/Prod.menge" + Environment.NewLine + " oder mehrfache Divisionskalk. Herstellkosten/Prod.menge + Vertriebskosten/Absatzmenge," + Environment.NewLine + " Serienfertigung=Zuschlagskalk.(BAB)," + Environment.NewLine + " Sortenfertigung=Äquivalenzziffernkalk: " +
                "(Umrechnungszahl=Menge mal Äquivalenzziffer, Faktor=Selbstkosten durch Summe U, Menge mal Faktor=Selbstkosten/Sorte)");
karte[33] = new Model1("34", "Skizzieren Sie die Verläufe der Kurven der DB-R", "Die FK-Kurve verläuft parallel zur x-Achse auf der Höhe der Fixkosten," + Environment.NewLine + " die variable Kosten starten im Nullpunkt und steigen bei diesem Modell linear." + Environment.NewLine + " Die Gesamtkostenkurve startet bei den Fixkosten und steigt ab dort linear um die variablen Kosten. " +
                "Die Umsatzkurve sollte steiler steigen als die Kurve der variable Kosten, Start ebenfalls im Nullpunkt. Die Schnittstelle zwischen der Umsatzkurve und der GK-Kurve ist der Break even Point, Gewinnschwelle= (Absatz*Preis)-((Absatz*variable Kosten)- FK). ");
karte[34] = new Model1("35", "Erklären Sie den Begriff des relativen DB", "Er wird ermittelt durch die Division des absoluten DB(U-VK) durch die Produktionszeit pro Einheit. Er wird genutzt zur Ermittlung des optimalen Produktionsprogrammes bei begrenzten Kapazitäten. ");
        
           
            for (int i=0; i<35; i++)
            {
                Add(karte[i]);
            }
        }


    }
}
