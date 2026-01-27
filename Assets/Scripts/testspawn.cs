using System.Collections;
using UnityEngine;

public class spawn_referenceCode : MonoBehaviour
{
    public int spawnedEnemies;
    //Refernsskript

    //DEL 1: Variabler
    #region 
    //Vi vill skapa ett skript som spawnar fiender. 

    //Först behöver vi en referens till det spelobjekt som vi vill spawna.
    public GameObject enemyPrefab;

    //Sedan behöver vi fler variabler. T.ex. hur många ska kunna spawna? Här kan vi använda en int för att räkna med.
    public int numberOfEnemiesToSpawn;

    //Vi kanske behöver en timer också för att se hur snabbt våra fiender ska spawna. Här använder vi float istället för int
    //eftersom vi vill räkna med decimaltal. 
    public float timeBetweenSpawns;

    //Det kan också vara bra att ha en referens till spelaren. Detta eftersom vi kanske kommer behöva veta saker om spelaren,
    //som t.ex. deras position.
    public GameObject player;

    #endregion

    //DEL 2: Vår IEnumerator. 
    #region
    //Vi skapar vår IEnumerator
    private IEnumerator SpawnManager()
    {
        //Här kan vi också skapa en lokal variabel (som bara existerar innanför vår SpawnManager) som 
        //sköter vart våra fiendeobjekt ska spawnas någonstans.
        Vector2 spawnPosition = Vector2.zero;

        //Vi tilldelar den värdet (0, 0, 0) till en början. Nu vill vi slumpa fiendes position med utgångspunkt från
        //spelarens position. Det vill säga är spelarens position (4, 12, 0) så kommer vi att utgå från position 4 i X-led
        //och position 12 i Y-led. Vi gör detta genom att skapa två till lokala variabler.

        float posX = player.transform.position.x + Random.Range(0, 10); //Tar vi exemplet ovan så kommer posX få ett värde
        //mellan 4 och 14.

        float posY = player.transform.position.y + Random.Range(0, 10); //Vi gör samma i Y-led. 

        //Nu kan vi bygga vår spawnPosition-variabel.
        spawnPosition = new Vector2(posX, posY);

        //Härnäst ska vi nu skapa vår loop för att spawna våra fiender. Detta kan antingen vara en while-loop eller en 
        //for-loop. 

        //for-loop
        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            //Vad spawnar vi: fienden
            //Vart spawnar vi den: i positionen i vår spawnPosition-variabel.
            //Vilket håll ska objektet vara roterat: det struntar vi i (Quaternion.identity).
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            //Sedan vill vi att datorn ska vänta innan den spawnar nästa.
            yield return new WaitForSeconds(timeBetweenSpawns);
        }

        //ELLER

        //while-loop
        while (spawnedEnemies < numberOfEnemiesToSpawn)
        {
            //NOTERA att vi har ett error i koden! Vi har inte deklarerat "spawnedEnemies" någonstans. Detta skulle kunna
            //vara en lokal variabel, eller så kan det vara en variable vi deklarar högst upp i programmet. Det skulle också
            //kunna vara en lista som lagrar spelobjekt. Då skulle vi i så fall behöva skriva "spawnedEnmies.count".

            //Annars är koden likadan som i vår for-loop.
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }

        //Däremot så kan ovanför kod inte bara kopieras. Såsom koden fungerar just nu, oavsett vilken metod av loop du använder,
        //så kommer koden att spawna alla fiender på samma plats. Du kör koden för att slumpa positionen INNAN du kör igång
        //din loop. Slumpningen måste också ske varje gång du loopar, helst innan objektet spawnas. 

        //Frågan är också om du vill att programmet ska loopas för evigt eller om du vill kalla på koden och att den då spawnar
        //så många fiender som du bestämt.  
    }
    #endregion

    //DEL 3: Kalla på vår kod
    #region
    //Nu ska vi kalla på vår IEnumerator. Är det en evighetsloop så kan vi lägga den i start. När den börjar så kommer den fortsätta
    //för evigt. Vill vi att den ska aktiveras beroende på andra villkor, som t.ex. vart man befinner sig i världen, så kan det vara
    //bättre att istället göra en funktion som aktiverar IEnumeratorn.

    //Vi börjar enkelt med Unitys Start-funktion.
    private void Start()
    {
        StartCoroutine(SpawnManager());
    }

    //... och nu gör vi vår egna metod. 

    public void StartSpawnManager()
    {
        StartCoroutine(SpawnManager());
    }


    #endregion
}