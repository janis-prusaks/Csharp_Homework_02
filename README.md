# Csharp_Homework_02
RigaCodingSchool C# majasdarbs - spēle Lingo.
Programmas kodā saglabāt string mainīgajā minamo vārdu ar garumu 5, kā jau īstajā LINGO.
Pēc tam iedot lietotājam informāciju par uzdevumu un likt lietotājam minēt tik ilgi, kamēr viņš uzraksta “apnika”.
Uzdevuma vienkāršības nolūkos iesaku izmantot un ievadīt tikai mazos burtus un neizmantot latviešu speciālos burtus (kā čģūīķ utt.)
Sākuma izvadīt vārda pirmo burtu un atlikušos simbolus zvaigznītes. Piemēram, ja būtu minamais vārds “piens”, tad lietotājam sākumā izvada “p****”. 
Lietotājs visu laiku min un pirms katra minējuma viņam tiek izvadīts esošais progress. Savukārt, ja kaut vienu burtu uzmin ĪSTAJĀ pozīcijā,
tad turpināt drukāt ārā visus jau zināmos burtus.
Piemēram, ja lietotājs min vārdu “pirms”, tad turpināt drukāt ārā “pi**s” un tā, kamēr uzminēti visi burti. Uzminētos burtus izdrukāt zaļajā krāsā. 
Uzvaras gadījumā uzrakstīt apsveicošu paziņojumu. Spēle beidzas tad, kad lietotājs uzvar vai kad lietotājs ir uzrakstījis “apnika”.
Lietotājs drīkst ievadīt tikai vārdus ar 5 burtiem vai vārdu “apnika” citādāk jāpaziņo, ka kļūda un jāliek vadīt atkārtoti.

Pēc nodošanas nav labots, šeit pasniedzēja komentārs:
"Labi pastrādāts, vienīgi trūkst risinājums sekojošai funkcionalitātei: "ja kaut vienu burtu uzmin ĪSTAJĀ pozīcijā, tad turpināt drukāt ārā visus jau zināmos burtus.
Piemēram, ja lietotājs min vārdu “pirms”, tad turpināt drukāt ārā “pi**s” un tā, kamēr uzminēti visi burti. Uzminētos burtus izdrukāt zaļajā krāsā. "

Ko tādu varētu risināt, izmantojot masīvus/sarakstus, kur saglabāt uzminētos burtus. 
Šobrīd sanāk, piemēram, ja mināmais vārds ir "ziema" un lietotājs ievada "zieds", tad programma izvada "zie**",
bet ja pēc tam ievada "zvans", tad programma atkal izvada "z****" - vajadzētu turpināt rādīt jau uzminētos burtus "zie**".
