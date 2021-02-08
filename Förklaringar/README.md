## Prefabs
En **Prefab** är en ritning eller en mall för ett specifikt gameObject.
Vad händer om vi skulle kunna definiera en enda fiende och få något att generera kopior av den fienden, eftersom de är desamma? Prefabs är det som löser exakt det.

En prefab är en definition av ett gameObject som vi vill generera, och det producerar en exakt kopia av det definierade gameObject, när du behöver det, var du än behöver det. Detta visar sig vara oerhört användbart när du behöver generera gameObjects i farten, som kulor, utomjordingar, mynt etc, eftersom Unity gör det mesta av arbetet här, vilket gör gameObjects direkt tillgängliga för oss.


Kommer du ihåg hur du lade Mr. Star till scenen redan när du började? Du drog spriten från assets till hierarchy.

Att skapa en prefab är det motsatta av den processen. Du drar ett befintligt spelobjekt från hierarchy till assets. Unity genererar sedan en prefab av gameObject i den mapp du tog den till. Så eftersom vi vill skapa en mall för rutan drar vi bara rutan sprite från hierachy till vår Prefabs-mapp.
