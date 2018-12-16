using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survival : MonoBehaviour
{

    //Max health and hunger
    public int maxHealth, MaxHunger;

    //Min health and hunger
    public int minHealth, minHunger;

    //actual Health and Hunger
    public float health, hunger;

    //digestion speed
    public float digestionSpeed;

    //starving speed
    public float starvingSpeed;


    // Start is called before the first frame update
    void Start()
    {

        //assign the maxHealth value to the health
        health = maxHealth;

        //assign the maxHunger value to the hunger
        hunger = MaxHunger;

    }

    //when a player eats food
    public void PlayerAteFood(float nutritiousValue)
    {
        //then get the nutritious value of that food 
        hunger += nutritiousValue;

    }

    // Update is called once per frame
    void Update()
    {

        //assign the straving speed/s to starving variable
        float starving = starvingSpeed * Time.deltaTime;

        //assign the digestion speed/s to the digestion variable 
        float digestion = digestionSpeed * Time.deltaTime;

        //reduce the amount of hunger by the amount of digestion per second 
        hunger -= digestion;

        //if hunger amount exceeds the maximum amount of hunger
        if (hunger >= MaxHunger)
        {

            //then assign the hunger value to the maximum amount of hunger
            hunger = MaxHunger;

        }

        //if hunger amount go below the minimum amount of hunger
        if (hunger <= 0)
        {

            //then assign the hunger value to the minimum amount of hunger
            hunger = minHunger;

            //reduce the amount of health by the amount of starving per second 
            health -= starving;

        }

        //if health amount go below the minimum amount of health
        if (health <= 0)
        {

            //then assign the health value to the minimum amount of health
            health = minHealth;

            //destory the player object
            Destroy(gameObject);
        }
    }


}
