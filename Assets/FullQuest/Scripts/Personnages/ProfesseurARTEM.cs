using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfesseurARTEM : MonoBehaviour
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
        dialog1.Add("Professeur ARTEM : Not completed");
        dialog2.Add("Professeur ARTEM : Completed");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && is_OK)
        {
            Debug.Log(dialog2[0]);
            done = true;
            scriptA.carte_etu = true;
              
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
