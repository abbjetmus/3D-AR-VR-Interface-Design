using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public Vector3[] SpawnPos =new Vector3[4];
    public GameObject Enemy;
    public int maxEnemies= 2;
    // Start is called before the first frame update
    void Start()
    {
        // foreach (Vector3 Position in SpawnPos)
        // {
        //       Instantiate(Enemy, Position, Quaternion.identity);
        // }
        for (int i = maxEnemies - 1; i >= 0 ; i--)
        {
            Invoke("spawn", 2*maxEnemies);
        // spawn();
         }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHit.LiveEnemies<maxEnemies)
        {
            spawn();
        }
    }

    void spawn(){
        
        int placeinArray = Random.Range(0,SpawnPos.Length);
        Instantiate(Enemy, SpawnPos[placeinArray], Quaternion.identity);

    }
}
