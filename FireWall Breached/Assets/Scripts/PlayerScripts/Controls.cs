using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controls : MonoBehaviour
{


    public Camera worldCamera;

    public NavMeshAgent playerAgent;

    public int playerHealth = 100;


    // Start is called before the first frame update
    void Start()
    {

        //gets navmesh agent component
        playerAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //checks if the player press the left mouse button
        if (Input.GetMouseButtonDown(0))
        {

            //gets mouse position
            Ray mousePos = worldCamera.ScreenPointToRay(Input.mousePosition);

            //gets info back from mouse position raycast
            RaycastHit mousePosHit;

            //if raycast hits something
            if(Physics.Raycast(mousePos, out mousePosHit))
            {

                //move the player to the location that got hi
                playerAgent.SetDestination(mousePosHit.point);

            }


            //if health reaches 0
            if(playerHealth == 0)
            {

                //destroy object
                Destroy(gameObject);


            }


        }


    }
}
