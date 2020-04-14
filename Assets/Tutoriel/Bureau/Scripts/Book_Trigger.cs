using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book_Trigger : MonoBehaviour
{
    private List<string> list;
    public GoalAchievement goal;
    public CharacterMovement movement;
    public GameObject nom;
    public GameObject corps;
    public GameObject end;
    public Image image;
    private bool is_OK;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<string>();
        string s0 = "Classeur (Description)";
        string s1 = "Le nombre de documents présents dans ce classeur dépasse l'entendement. C'est bizarre, sur l'ensemble des élèves ayant rencontré ce conseiller, il ne figure que des prénoms de filles. Et leurs adresses ...";
        list.Add(s0);
        list.Add(s1);
        is_OK = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.is_interacting && is_OK)
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
