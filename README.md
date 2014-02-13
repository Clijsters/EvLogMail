EvLogMail
=========
English Description not available yet.
# Beschreibung
EvLogMail ist ein Windows Dienst, welcher im Hintergrund Informationen über den Status eines Servers (oder Clients) sammelt und automatisiert per Mail versendet.
D.h., den User sofort über das Auftreten von Fehlern benachrichtigt und/oder ihn regelmäßig über den Status informiert.
Anbindungsmöglichkeiten an Dashboards sind auch angedacht.

Der EvLogMail Service wird mit einem komfortablen Frontend (WinForms) konfiguriert.
## Was soll das?

EvLogMail fing vor Ewigkeiten als kleines VBS-Script an - gedacht, um mich über Fehler im Ereignisprotokoll eines Windows Server 2003 zu benachrichtigen.

Hier wächst nun eine grössere und umfangreichere Version des ganzen an, als Windows Service in C#.
(Es gab bisher die ein oder andere, mehr oder weniger gute Implementierung des ganzen in VB.Net)
### Die nächsten Schritte
* Regelmäßiges Abfangen von Ereignismeldungen
* Sammeln von Statusinformationen in konfigurierbaren Zeitabständen
* Automatische Mails in nahezu Echtzeit für wichtige Einträge (Fehler/Warnungen)
* Sofort-Mails für das überschreiten vorher konfigurierter Limits (Auslastung, Laufzeit...)
* Regelmäßige Mails über Serverstatus, Einträge und Anwendungsstatistiken
* Regelmäßiges Versenden der DATEN an eine API (z.B. Dashboards)
* Mehrere Remote-Rechner mittels WMI abfragen

### Überlegungen / Brainstorming
* Erstellung einer eigenen, plattformunabhängigen API
* Möglichkeit der Ablage und Analyse der Daten


## Lizenz
The MIT License (MIT)

> Copyright (c) 2014: Dominique Clijsters
> 
> Permission is hereby granted, free of charge, to any person obtaining
> a copy of this software and associated documentation files (the
> "Software"), to deal in the Software without restriction, including
> without limitation the rights to use, copy, modify, merge, publish,
> distribute, sublicense, and/or sell copies of the Software, and to
> permit persons to whom the Software is furnished to do so, subject to
> the following conditions:
> 
> The above copyright notice and this permission notice shall be
> included in all copies or substantial portions of the Software.
> 
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
> EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
> MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
> NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
> LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
> OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
> WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
