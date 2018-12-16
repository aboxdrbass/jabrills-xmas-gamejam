using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Food : MonoBehaviour
{

    //specify the type of food
    public string type;

    //the nutritious value
    public float nutritiousValue;

    //specify the Player object
    GameObject player;

    //the distance between the player and the food
    float dist;

    //an event for when a player eats food
    public event Action PlayerAteFood;

    // Start is called before the first frame update
    void Start()
    {

        //gets and assign the player object to the variable Player
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {

        //checks the distance between the player and the food and assign them to the variable dist
        dist = Vector3.Distance(player.transform.position, transform.position);

        //logs the player distance
        Debug.Log("player distance is " + dist);


        //if the type of food is a vegetable
        if(type == "Vegetable")
        {

            //then assign it's nutritious value to 5
            nutritiousValue = 5;

        }// if it's meat
        else if (type =="Meat")
        {

            //then assign it's nutritious value to 10
            nutritiousValue = 10;

        }

    }


    //triggers when the mouse is over the food
    public void OnMouseOver()
    {

        //logs when the mouse is over the food
        Debug.Log("the mouse is over a " + type);

        //if the player is near and clicks the right moust button
        if(dist <= 2.2f && Input.GetMouseButtonDown(1))
        {

            //activates the player ate food function and sends the nutritiouse value of the object to the Survival script
            player.SendMessage("PlayerAteFood", nutritiousValue);

            //destroys the object
            Destroy(gameObject);

        }
    }

}
