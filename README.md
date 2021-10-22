# WindowsTexteditor
I detta projekt har ett system för att hantera och modifiera filer skapats, det vill säga en vanlig ordbehandlare. Systemet innehåller ett textfönster där användaren kan skriva
text i, och beroende på användarens behov så ska möjligheten finnas till att spara texten till en befintlig fil eller under ett nytt filnamn. Systemet kan öppna en befintlig
fil genom att presentera data i textboxen, ändra och sparas om på nytt. Därtill kan användaren stänga textfönstret och nollställa textboxen som inträffar när användaren vill skapa ett nytt textfält. Namnet på filen anges i fönstertiteln, och om ingen fil har öppnats samt att en ny text ej har sparats, då ska ”Dok1.txt” anges i fönstertiteln. Med systemet kan användaren tillfrågas om den aktuella texten i fönstret ska sparas när man försöker stänga, öppna eller skapa en ny fil. Det medför de möjliga åtgärderna; ”ja”, ”nej” eller "avbryt", där detta ska endast dyka upp om texten har förändrats. Dessutom består systemet av en informationsrad som ständigt kalkylerar antal ord, rader, bokstäver med mellanslag och bokstäver utan mellanslag som förekommer i textboxen. Det finns även ytterligare funktionaliteter som låter användaren dra in en fil i fönstret, och beroende på vad för kontrolltangent som hålls nedtryckt, kan olika händelse inträffa. 

## Kravspecifikation
Grundfunktionalitet som ska finnas i systemet är:
- Skrivatext i textfönster
- Skapa en ny skrivyta o
  - Ny... 
- Spara texten i fönstret till fil 
  - Spara som...
  - Väljer användaren ”Spara” för ett tidigare osparat dokument ska programmet välja ”Spara som...” automatiskt. 
- Öppna befintlig fil 
  - Modifiera denna fil 
    - Spara (under aktuellt filnamn) 
    - Spara som...(under nytt filnamn)
- Stänga aktuell vy (kan även vara en öppnad fil)
  - Close
- När en fil är öppen ska filens namn anges i fönstertiteln, ex. ”fil.txt”. Är det en ny text som ännu ej sparats ska ”dok1.txt” anges i fönstertiteln 
- Om aktuell text i textfönstret inte är sparad(eller är ändrad sedan den öppnades)och man försökerstänga,öppna eller skapa enny fil ska användaren tillfrågas om han/hon vill spara innan den nya filen/det nya dokumentet öppnas. Möjlighet ska här finnas att svara ”ja”, ”nej” eller ”avbryt”.Är texten oförändrad ska ingenfråga komma upp. Om texten har ändrats ska detta indikeras med en asterisk (*) i fönstertiteln, ex. ”fil.txt*”. 
### Version 2
