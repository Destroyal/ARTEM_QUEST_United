using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        bestscore = 20;
    }

    // Update is called once per frame
    void Update()
    {
        score=Perso.score;
        if (score >= 20)
        {
            SceneManager.LoadScene("FullARTEM");
        }
        if (perdu && score > bestscore)
        {
            bestscore = score;
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
                GUI.TextField(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 100, 400, 100), "Votre score : " + score.ToString() +"\n Score à atteindre : " + bestscore.ToString());


                if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2 +20, 140, 50), "Rejouer ?")) // means "si je clique sur le button"
                {
                    map.vitesse = vitessemap;
                    Application.LoadLevel("Game");
                    perdu = false;
                    Game.score = 0;

                }

            }
        }
    }
}
