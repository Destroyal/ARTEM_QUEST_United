﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacENSAD : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CharacterMovement1 script;
    public QuestAchievements scriptA;
    private bool is_OK;
    private bool done;
    private List<string> dialog1;
    private List<string> dialog2;

    void Start()
    {
        dialog1 = new List<string>();
        dialog2 = new List<string>();
        dialog1.Add("Lac ENSAD : Not completed");
        dialog2.Add("Lac ENSAD : Completed");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && is_OK)
        {
            if (done) { 
                Debug.Log(dialog2[0]);
                scriptA.jouet = true;
            }
            else
            {
                Debug.Log(dialog1[0]);
            }
        }

        if (scriptA.tuba)
        {
            done = true;
        }
        else
        {
            done = false;
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        is_OK = true;
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        is_OK = false;
    }
}
