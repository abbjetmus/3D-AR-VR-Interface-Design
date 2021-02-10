## RigidBody
Allt i fysikvärlden som ska flytta kommer att behöva en Rigidbody. A Rigidbody tar hand om alla slags saker som hastighet och tyngdkraft, men för närvarande räcker det med att komma ihåg att allt fysiskt som rör sig genom spelvärlden behöver en Rigidbody.

## Prefabs
En **Prefab** är en ritning eller en mall för ett specifikt gameObject.
Vad händer om vi skulle kunna definiera en enda fiende och få något att generera kopior av den fienden, eftersom de är desamma? Prefabs är det som löser exakt det.

En prefab är en definition av ett gameObject som vi vill generera, och det producerar en exakt kopia av det definierade gameObject, när du behöver det, var du än behöver det. Detta visar sig vara oerhört användbart när du behöver generera gameObjects i farten, som kulor, utomjordingar, mynt etc, eftersom Unity gör det mesta av arbetet här, vilket gör gameObjects direkt tillgängliga för oss.


Kommer du ihåg hur du lade Mr. Star till scenen redan när du började? Du drog spriten från assets till hierarchy.

Att skapa en prefab är det motsatta av den processen. Du drar ett befintligt spelobjekt från hierarchy till assets. Unity genererar sedan en prefab av gameObject i den mapp du tog den till. Så eftersom vi vill skapa en mall för rutan drar vi bara rutan sprite från hierachy till vår Prefabs-mapp.

## Parent and Child GameObjects
Ett barn gameobjekt kan ha sin position i förhållande till sin förälder, inte spelvärlden. Det betyder att om du ställer in positionen på (0, 0, 0), kommer ett barnspelobjekt att placeras i det döda centrumet för det överordnade spelet Objekt, inte på skärmen.


## Setup()

## Update()

## CollisionEnter2D()
Det är en metod som avfyras (kallas) av Unity när den upptäcker en kollision mellan objektet som detta skript är fäst vid och något annat gameObject.
