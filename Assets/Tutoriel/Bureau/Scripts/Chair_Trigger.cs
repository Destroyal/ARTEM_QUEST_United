using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chair_Trigger : MonoBehaviour
{
    private List<string> list;
    public GoalAchievement goal;
    public CharacterMovement movement;
    public GameObject nom;
    public GameObject corps;
    public Image image;
    private bool is_OK;
    public GameObject Player;
    public GameObject Player_pawn;
    private bool dialoging;
    public GameObject Fade;

    public GameObject oui_bouton;
    public GameObject non_bouton;
    // Start is called before the first frame update
    void Start()
    {
        list = new List<string>();
        string s0 = "Chaise (Description)";
        string s1 = "Une chaise en bois des plus normales. Voulez vous vous asseoir dessus ?";
        list.Add(s0);
        list.Add(s1);
        is_OK = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.is_interacting && is_OK)
        {
            oui_bouton.SetActive(true);
            non_bouton.SetActive(true);

            nom.SetActive(true);
            nom.GetComponent<Text>().text = list[0];

            corps.SetActive(true);
            corps.GetComponent<Text>().text = list[1];

            image.enabled = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (goal.must_interact || goal.has_interacted)
        {
            if (Input.GetButtonDown("Interact")) 
            {
                goal.must_click = true;
                movement.is_stunned = true;
                goal.is_interacting = true;
                goal.has_interacted = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        is_OK = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        is_OK = true;
    }

    public void ClickNo()
    {
        nom.SetActive(false);
        corps.SetActive(false);
        image.enabled = false;
        goal.is_interacting = false;
        goal.has_clicked = true;
        movement.is_stunned = false;

        oui_bouton.SetActive(false);
        non_bouton.SetActive(false);
    }

    public void ClickYes()
    {
        is_OK = false;
        goal.has_clicked = true;
        oui_bouton.SetActive(false);
        non_bouton.SetActive(false);
        Player.GetComponent<SpriteRenderer>().enabled = false;
        Player_pawn.SetActive(true);

        nom.SetActive(false);
        corps.SetActive(false);
        image.enabled = false;

        Fade.SetActive(true);
    }
}
