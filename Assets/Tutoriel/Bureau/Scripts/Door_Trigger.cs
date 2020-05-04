using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door_Trigger : MonoBehaviour
{
    private List<string> list;
    public GoalAchievement goal;
    public CharacterMovement movement;
    public GameObject nom;
    public GameObject corps;
    public GameObject end;
    public Image image;
    private bool is_OK;
    public GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<string>();
        is_OK = false;
        string s0 = "Porte du bureau (Description)";
        string s1 = "La porte est fermée !? Je viens pourtant de rentrer... Ce vieillard désabusé m'a donc piégé à l'intérieur ! Il n'y a qu'une solution pour sortir : le confronter.";
        list.Add(s0);
        list.Add(s1);
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.is_interacting && is_OK && !(goal.can_leave || goal.leave))
        {
            nom.SetActive(true);
            nom.GetComponent<Text>().text = list[0];

            corps.SetActive(true);
            corps.GetComponent<Text>().text = list[1];

            end.SetActive(true);
            image.enabled = true;

            if (Input.GetButtonDown("Pass_Dialog"))
            {
                nom.SetActive(false);
                corps.SetActive(false);
                end.SetActive(false);
                image.enabled = false;
                goal.is_interacting = false;
                movement.is_stunned = false;
            }
        }

        if (goal.is_interacting && is_OK && goal.can_leave)
        {
            goal.leave = true;
            fadeOut.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (goal.must_interact || goal.has_interacted)
        {
            if (Input.GetButtonDown("Interact")) 
            { 
                movement.is_stunned = true;
                goal.is_interacting = true;
                goal.has_interacted = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        is_OK = true;
    }


    void OnTriggerExit2D(Collider2D collider)
    {
        is_OK = false;
    }
}
