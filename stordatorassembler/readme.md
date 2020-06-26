Storbanken har laddat upp två mystiska filer på ftp:n; **program.asm** respektive **memory.dump**. 
Det visar sig att deras stordator har havererat och de behöver hjälp att exekvera programmet.
Oturligt nog är det stordatorassembler som inte är kompatibelt med något. 
Din uppgift blir att skriva en interpretator som kan ladda in minnesdumpen och exekvera programmet.
Resultatet som storbanken vill ha tillbaka är minnet efter exekveringen översatt till en ascii-sträng (där varje minnescell i stordatorn motsvarar ett ascii-värde).

Till din hjälp har du ett fax som beskriver stordatorn och stordatorassemblern. Där anges följande:

* Stordatorn jobbar alltid med 32 bitars heltal (signed).
* Den har tre register R0, R1 samt R2
* Minnesaddresseringen börjar på index 0 för första minnescellen, 1 för andra osv

| Instruktion        | Beskrivning                               |
| ------             | ------                                    |
|  LOAD   R1, 35     | Ladda register R1 med decimalt värde 35   |
|  LOAD   R1, [12]   | Ladda register R1 med värdet på minnesaddress 12   |
|  STORE  R1, [12]   | Lagra värdet i R1 i minnet på minnesaddress 12 |
|  ADD    R0, R1, R2 | Lägg ihop värdet i register R0 med R1 och spara resultatet i register R2, dvs *R2 := R0 + R1* |
|  SUB    R0, R1, R2 | Subtrahera värdet i register R1 från R0 och spara resulatet i register R2, dvs *R2 := R0 - R1* |

