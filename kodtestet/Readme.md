# Kodtestet

Du är ganska nöjd med ditt jobb på Mulna men blir ändå nyfiken när du ser att Collector annonserar efter utvecklare. Lite på skoj skickar du in en ansökan och, efter lite snack, uppstår tycke på båda sidor och du får förslaget att göra ett kodtest.

I din mailbox dimper det ner ett enkelt [Snake-spel](./SnakeGame)<sup>1</sup> skrivet i C# tillsammans med några, relativt vaga, frågepunkter.

* Vad tycker du om strukturen i projektet? Finns det för- och nackdelar? Är det lätt eller svårt att hitta relaterad funktionalitet? Vad finns det för alternativ?
* Hur ser koden ut? Är den objektorienterad eller funktionell? Hur är testbarheten? Har du förbättringsförslag?
* Är det en lagom abstraktionsnivå? Hur enkelt är det att läsa programmet? Hur är det att lägga till ny funktionalitet? Hur många filer påverkas av ett tillägg?
* Hur skulle koden se ut med så lite struktur och abstraktioner som möjligt? Vad är kostnaden för abstraktioner?
* Kan man applicera domän driven design och vad skulle det isåfall resultera i?

Refaktorera koden enligt dina synpunkter ovan. Prova gärna flera lösningar.

Testa gärna även att utöka spelet på något sätt. Exempel:

* Gör det möjligt att börja om spelet efter en omgång
* Låt ormen växa när den äter
* Detektera om ormen äter sig själv och avsluta omgången
* Minska "blinket" genom att undvika att rensa hela skärmen
* Byt från Console till en annan rityta
* Skriv tester

I denna uppgift finns inget absolut rätt och fel utan det handlar om att fundera över kod och struktur i allmänhet. 

<sup>1</sup> [Snake](https://sv.wikipedia.org/wiki/Snake)