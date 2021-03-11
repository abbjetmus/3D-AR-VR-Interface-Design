# Gränssnittsdesign

Välkommen till kursen Gränsnittsdesign där vi kommer få lära oss att bygga användarupplevelser på den allra tekniska framkanten med hjälp av Unity.<br><br>
Kolla på den här videon genom att klicka på bilden.<br>

<https://www.youtube.com/watch?v=CPD_nRLDN7g>

Vi kommer i huvudsak jobba i en spelmotor som heter Unity.
Unity är för närvarande den mest populära spelmotorn som används av utvecklare runt om i världen - och med goda skäl. Den har ett kraftfullt visuellt gränssnitt för att skapa spel, utveckling av plattformar och ett aktivt bidragande community. Unity är en plattformsspelmotor som främst används för att utveckla videospel och simuleringar för PC, konsoler, mobila enheter och webbplatser. Den utvecklades av Unity Technologies och tillkännagavs först endast för OS X, vid Apples världsomfattande utvecklarkonferens år 2005, den har sedan dess utökats till nästan alla tillgängliga plattformar.

Idag kan man använda Unity till att utveckla alla möjliga typer att upplevelser, utöver spel kan man utveckla 3D visualiseringar, AR (Augmented Reality), VR (Virtual Reality) och filmer.<br>

Intressant och bra tråd om hur man blir bra på Unity:<br>
<https://forum.unity.com/threads/tips-for-studying-the-scripting-api.564385/>

# Kursinnehåll
1. [Introduktion till 3D, AR, VR och Unity (Vecka 2)](#unity-introduction)
2. [Sätta upp och gå igenom utvecklingsmiljöer (Vecka 4)](#development-environments)
3. [Introduktion till programmeringsspråket C# (Vecka 2-4)](#c-sharp-introduction)
4. [Object Orienterad Programmering med C# (Vecka 2-4)](#oop)
5. [Grunderna i Unity (Vecka 5-8)](#unity-basics)
6. [Projekt: Bygga ett valfritt 2D eller 3D Spel i Unity (Vecka 5-8)](#common-courses)
7. [Val av specialiseringsområde 3D Spel, AR eller VR](#unity-specialization)
8. [Slutprojekt inom specialområde](#final-project)


## 1.Introduktion till 3D, AR, VR och Unity <a name="unity-introduction"></a>
### 3D
**3D**, en förkortning för tredimensionell, är det rumsperspektiv där längd, bredd och djup uppfattas. Med tredimensionell, menas att ett objekt eller en matematisk figur har tre dimensioner, som är ett område i höjd, bredd och djup. Därmed har tredimensionella kroppar en volym.<br>

3D visualisering är en mängd olika tekniker som gör att bilder och filmer ser mer verklighetstrogna ut, på datorn, i bio eller på TV. Känd som "stereoskopisk bildbehandling" och "3D-stereo", känner människor ett större djup än de gör med 2D och känner att de kan nå ut och röra vid föremålen.

### AR - Augmented Reality
**Förstärkt verklighet** *(engelska: augmented reality, AR)*.<br>

Förstärkt verklighet är en direktsänd betraktelse av en fysisk, verklighetstrogen miljö vars element förstärks (eller kompletteras) med datorgenererade sinnesintryck som ljud, video, grafik eller GPS-data. Det är relaterat till ett begrepp som kallas mediated reality (medierad verklighet), där en bild av verkligheten ändras (kanske till och med minskar i stället för förstärks) av en dator. Tekniken fungerar genom att öka uppfattningen om den nuvarande verkligheten (till skillnad från virtuell verklighet som ersätter den verkliga världen med en simulerad).<br>

Förstärkt verklighet sker konventionellt i realtid och i semantiska sammanhang med miljöfaktorer, såsom sportresultat på TV under en match. Med hjälp av avancerad AR-teknik (t.ex. genom att tillsätta datorseende och objektigenkänning) blir informationen om den omgivande verkligheten för användaren både interaktiv och digitalt manipulerbar. Information om miljön och dess objekt överläggs på den verkliga världen. Denna information kan vara virtuell eller verklig, t.ex. genom att se andra verkliga känd eller uppmätt information såsom elektromagnetiska radiovågor som är överlagrade i exakt position med där de faktiskt är i rymden.<br>

Man kan uppleva förstärkt verklighet genom olika enheter som exempelvis smartphones, head-mounted display eller kontaktlinser.<br>

Microsoft HoloLens är ett exempel på en förstärkt verklighet-enhet.<br>
Ett antal spel till smartphones använder förstärkt verklighet, bland annat Pokémon Go och Ingress.

### VR - Virtual Reality
Virtuell verklighet *(engelska: Virtual reality – VR; även datorsimulerad verklighet eller immersive multimedia)* är datateknik som simulerar verkliga eller inbillade miljöer och vår närvaro och interaktion i dem.<br>

Till exempel kan man uppleva VR med VR-glasögon som i realtid visar bilder av en datorbaserad modell av miljön. VR-glasögonen känner av åt vilket håll man riktar blicken, och visar då bilder av modellen i motsvarande riktning. Det innebär att man kan betrakta modellen från olika håll genom att t ex vrida eller luta på huvudet.<br>

Illusionen av verklighet i VR frammanas dels av den kroppsliga interaktionen med en virtuell modell, och dels av att ljus, ljud, rörelser med mera som simuleras av modellen känns igen från verkliga miljöer. De sensoriska upplevelserna (det vill säga för syn, känsel, hörsel och lukt) är i vissa fall tillräckliga för användning inom undervisning och träning av bland andra soldater, piloter och kirurger.

## 2. Sätta upp och gå igenom utvecklingsmiljöer <a name="development-environments"></a>

1. Ladda ner UnityHub på den här länken: <https://store.unity.com/download-nuo><br>
Klicka på knappen *Start here*.<br>
Du laddar då ner Unity Hub vilket är Unitys program- och projekthanterare. Det är via den vi installerar Unity editorn enligt steg 2.

2. Följ den här länken för att installera Unity korrekt via Unity Hub:<br> 
<https://learn.unity.com/tutorial/install-unity-and-the-hub?uv=2019.4&pathwayId=5f7bcab4edbc2a0023e9c38f&missionId=5f77cc6bedbc2a4a1dbddc46&projectId=5fa1b1a1edbc2a001f612a3d#>
![UnityHub](/Images/UnityHub.png)

3. Installera Visual Studio Community, ladda ner Visual Studio Community från den här länken:
<https://visualstudio.microsoft.com/vs/community/><br>

4. Installera följande delar från Visual Studio Installer, Unity utan UnityHub bocken:<br>
![Dot Net](/Images/Visual-Studio-Unity.PNG)

## 3. Introduktion till programmeringsspråket C# <a name="c-sharp-introduction"></a>
Unity använder sig utav programmeringsspråket C#.<br>
C# uttalas "C-Sharp".<br>
Det är ett objektorienterat programmeringsspråk skapat av Microsoft som körs på .NET Framework.<br>
C# har rötter från C-familjen, och språket ligger nära andra populära språk som C ++ och Java.<br>
Den första versionen släpptes år 2002. Den senaste versionen, C# 8 , släpptes i september 2019.<br>

C# används för:

* **Mobila applikationer**
* **Skrivbordsapplikationer**
* **Webbapplikationer**
* **webbservice**
* **Webbplatser**
* **Spel**
* **AR - VR**
* **Databasapplikationer**
* **Och mycket, mycket mer!**
<br>
Därför behöver vi lära oss C#.
De resurser vi kommer använda är denna för språket:<br>

<https://www.w3schools.com/cs/default.asp>

Och denna för övningsuppgifter:<br>
<https://www.exercisescsharp.com/>

Eftersom vi inte har fått upp våra utvecklingsmiljöer så kommer vi öva i en editor på nätet:<br>
<https://dotnetfiddle.net/>

## 4. Object Orienterad Programmering med C# <a name="oop"></a>
Objektorienterad programmering betonar följande begrepp:

* **Klass**<br> 
Programmet byggs upp av delar, klasser, efter de begrepp som hanteras. Varje klass är en abstraktion av ett sådant begrepp, och innehåller både information och funktionalitet. Programmet kan ses som en uppsättning samverkande och interagerande objekt som vart och ett är av en viss typ/sort, de tillhör en viss klass.<br><br>
* **Inkapsling**<br> 
Ett objekts exakta beteende och funktion är dold för omvärlden. Varje klass är en abstraktion och visar ett gränssnitt mot omvärlden som specificerar hur andra klasser får interagera med den. Detta garanterar att alla förändringar av ett objekt sker genom programkod som tillhör objektets klass. Ett visst objekt kan inte påverka ett annat objekt på annat sätt än genom detta objekts gränssnitt.<br><br>

* **Arv**<br>
Klasserna och begreppen är inte oberoende av varandra, utan kan i många fall ses som en kedja av sammanhängande begrepp, där vissa begrepp är allmänna och generella, medan andra är specialfall av de allmänna begreppen. Till exempel kan ett programsystem inom bankvärlden hantera det allmänna begreppet/klassen konto, men även specialfall som inlåningskonto, lönekonto, konto med kreditmöjlighet o.s.v. På så sätt tillhör ett visst objekt inte bara en klass utan en hierarki av klasser med ökande abstraktionsgrad. Funktionalitet som är gemensam för alla specialfallen, programmeras i den gemensamma "överklassen" och endast det som särskiljer specialfallet programmeras i den specialiserade "underklassen". En underklass ärver egenskaper och funktionalitet av den överklass den tillhör.<br><br>

* **Polymorfism**<br>
I en grupp av underklasser finns funktionalitet som har yttre likheter mellan klasserna, men som måste programmeras på olika sätt beroende på vilken av underklasserna det gäller. Gränssnittet blir gemensamt för alla underklasserna, och definieras i överklassen, men den verkställande programkoden finns i respektive underklass. Ett visst objekt som använder andra objekt behöver ofta inte bry sig om vilket specialfall av objekt det är fråga om utan använder endast det gemensamma gränssnittet definierat av överklassen, och är okänsligt för mängden av specialfall som råkar finnas.

## 5. Grunderna i Unity (Vecka 5-8) <a name="development-environments"></a>
Ni ska gå igenom hela den här tutorial serien fram till vecka 9.<br>
<https://www.studytonight.com/3d-game-engineering-with-unity/introduction-to-unity#>

Tills dess vill jag att ni väljer ut vilket 2D spel ni vill bygga.
## 6. Projekt: Bygga ett valfritt 2D Spel i Unity (Vecka 5-8) <a name="common-courses"></a>
Ni ska bygga det spelet som ni har valt till projektet. Deadline vecka 8 torsdag kväll 25/2.
<br>
Bra sida med tutorials av 2D spel: <https://noobtuts.com/unity>
<br>

Exempel spel:<br>
* Flappy Bird
* Space Shooter
* Super Mario
* Tetris
* ...

## 7. Val av specialiseringsområde 3D Spel, AR eller VR <a name="unity-specialization"></a>
Nästa steg i kursen är att ta det vi har lärt oss när vi utvecklat 2D-Spel och bygga vidare för att utveckla mer avancerade applikationer iform av 3D-Spel, Augmented Reality och Virtuell Reality. Ni har valfriheten att själva välja vilket område ni vill lära er mer om, och här nedan finns resurserna som ni har tillgodo.

**Börja med att läsa den här artikeln:**<br>
<https://blogs.unity3d.com/2020/05/01/learn-to-create-ar-and-vr-apps-with-unity/><br>
**Bra Sida för AR, VR, XR och Unity**<br>
<https://vrgamedevelopment.pro/><br>

<https://craftgames.co/unity-3d-fps-movement/#Setting_up_FPS_character>

### Vill du lära dig VR
Du **ska/måste** gå igenom den här kursen för att lära dig allmänt om VR och hur man bygger VR appar:<br>
<https://www.edx.org/course/creating-virtual-reality-vr-apps-2><br>

Kan du inte få nog av VR så kan man genomgå även någon av dess:<br>
 
1. Vill du utveckla för Oculus Rift:<br>
<https://learn.unity.com/course/oculus-vr><br>

2. Vill du utveckla för bilindustri:<br>
<https://learn.unity.com/course/design-visualization-for-automotive>

3. Vill du utveckla arkitekturer för byggnader:
<https://learn.unity.com/course/unity-photorealistic-architecture-pre-visualization><br>

4. Vill du utveckla mot bygg och konstruktionsbranchen:<br>
<https://learn.unity.com/course/build-a-full-construction-site-tour><br>
<br>

**Komma igång snabbt med VR**<br>
<https://developers.google.com/vr/develop/unity/get-started-android><br>

### Vill du lära dig AR
Du **ska/måste** gå igenom den här kursen för att lära dig allmänt om AR och hur man bygger AR appar:<br>
<https://www.coursera.org/learn/ar?ranMID=40328&ranEAID=vedj0cWlu2Y&ranSiteID=vedj0cWlu2Y-ayukwDyaixBNg_DaWHsobQ&siteID=vedj0cWlu2Y-ayukwDyaixBNg_DaWHsobQ&utm_content=10&utm_medium=partners&utm_source=linkshare&utm_campaign=vedj0cWlu2Y>
<br><br>
Vill du testa bygga ett AR projekt direkt testa följ den här tutorialen:<br>
<https://vrgamedevelopment.pro/how-to-create-an-augmented-reality-app-in-unity/>

### Vill du lära dig 3D-Spel
Du **ska/måste** gå igenom den här kursen för att lära dig allmänt om 3D-Spel:<br>
<https://learn.unity.com/course/beginning-3d-game-development><br>

Kolla sedan på resurserna på den här sidan:<br>
<https://conceptartempire.com/unity-3d-tutorials>

<br>
<https://learn.unity.com/tutorial/let-s-try-shooting-with-raycasts><br>
<https://craftgames.co/unity-3d-fps-movement/#Setting_up_FPS_character><br>
<><br>

## 8. Projekt: Slutprojekt bygga valfri applikation inom specialområde <a name="final-project"></a>
Efter att ni har valt specialiceringsområde och genomgått en av kurserna ovan.
Så ska ni bygga ett slutprojekt. 
Vi kommer dela in er i grupper med 3 elever i varje grupp, där alla i gruppen valt samma specialiseringsområde.
Därefter kommer ni få brainstorma vad ni vill bygga som slutprojekt och implementera det.

