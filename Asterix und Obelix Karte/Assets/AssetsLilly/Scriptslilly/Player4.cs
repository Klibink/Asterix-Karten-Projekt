﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// Skript handles Player Movement over Unitys NavAgent functions
// onClick on clickable Objects, the Player moves to the Destination of where the Raypoint hit the Clickable Objects
// PlayerAnimations change depeding on State of Player ( standing/moving)
public class Player4 : MonoBehaviour {
    public bool GameModeAsterix;
    public float movespeed;
    private NavMeshAgent navAgent;
    private bool running=false;

    CharacterController controller;
    Animator anim;
    public Inventory inventory;

    //private GameObject Object;

	// Use this for initialization
	void Start () {
        navAgent = GetComponent<NavMeshAgent>();

        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();

	}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();
        if (item != null)
        {
            inventory.AddItem(item);
        }
    }
    // Update is called once per frame
    void Update() {
        if (!GameModeAsterix)
        {

        }
        //transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime); //for KeyboardInput
        else if(GameModeAsterix){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //https://www.youtube.com/watch?v=GANwdCKoimU NavMesh&Anim.!** https://www.youtube.com/watch?v=kQiTRKMrl5s
            RaycastHit RayHit;                                              //https://docs.unity3d.com/Manual/nav-MoveToClickPoint.html 
            if (running)
            {
                anim.SetBool("walk", true);
                //anim.SetInteger("speed", 1);
            }

            if (!running)
            {
                //anim.SetInteger("speed", 0);
                anim.SetBool("walk", false);
            }
            if (Input.GetMouseButtonDown(0)) //0=left;1=right;2=middle
            {
                if (Physics.Raycast(ray, out RayHit, Mathf.Infinity)) //100=max distance of Ray
                {

                    if (RayHit.collider.tag == "Interact")
                    {
                        navAgent.destination = RayHit.point;

                    }
                    //navAgent.destination = RayHit.point;
                }
            }
            if (navAgent.remainingDistance <= navAgent.stoppingDistance)
            {
                running = false;
            }
            else
            {
                running = true;

            }


        }
    }
}
