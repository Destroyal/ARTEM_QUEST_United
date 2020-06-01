﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static int score;
    private int bestscore;
    public static bool perdu = false;
    public float vitessemap;
    public GUISkin skingo;


    // Start is called before the first frame update
    void Start()
    {
        bestscore = PlayerPrefs.GetInt("meilleur score");   
    }

    // Update is called once per frame
    void Update()
    {
        score=Perso.score;
        if (perdu && score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt("meilleur score", score);
        }
    }

    void OnGUI()
    {
        GUI.skin = skingo;

        if (perdu == false) {

            GUI.Label(new Rect(Screen.width / 2 - 50, 30, 100, 100), score.ToString());
        }
        
        

        if (perdu)
        {
            {
                map.vitesse = 0;
                GUI.TextField(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 100, 240, 100), "Your score : " + score.ToString() +"\n Best score : " + bestscore.ToString());


                if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2+80, 140, 50), "Rejouer ?")) // means "si je clique sur le button"
                {
                    map.vitesse = vitessemap;
                    Application.LoadLevel("Game");
                    perdu = false;
                    Game.score = 0;

                }

                if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2+20, 140, 50), "Quitter")) // means "si je clique sur le button"
                {
                    Application.Quit();
                    perdu = false;
                    Game.score = 0;
                }
            }
        }
    }
}
