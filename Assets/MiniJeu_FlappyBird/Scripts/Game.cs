using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static int score = 0;
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
        
        if (perdu && score > bestscore)
        {
            bestscore = score;
            PlayerPrefs.SetInt("meilleur score", score);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 100, 15f, 200, 180), score.ToString());
        GUI.skin = skingo;
        

        if (perdu)
        {
            {
                map.vitesse = 0;
                GUI.TextField(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 50, 120, 50), "GAME OVER");


                if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2+50, 100, 30), "Rejouer ?")) // means "si je clique sur le button"
                {
                    map.vitesse = vitessemap;
                    Application.LoadLevel("Game");
                    perdu = false;
                    Game.score = 0;

                }

                if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2+20, 100, 30), "Quitter")) // means "si je clique sur le button"
                {
                    Application.Quit();
                    perdu = false;
                    Game.score = 0;
                }
            }
        }
    }
}
