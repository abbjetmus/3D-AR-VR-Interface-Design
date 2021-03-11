using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour
{

    //The box's current health point total
    public int currentHealth = 3;

    public static int LiveEnemies=0;
    public void Start(){
        LiveEnemies+=1;
        Debug.Log(LiveEnemies);
    }


    public void Damage(int damageAmount)
    {
        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero
        if (currentHealth <= 0) 
        {
            //if health has fallen below zero, deactivate it 
            // gameObject.SetActive (false);
            Destroy(gameObject);
            LiveEnemies-=1;
        }
    }
}
