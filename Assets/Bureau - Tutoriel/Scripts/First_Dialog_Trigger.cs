using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class First_Dialog_Trigger : MonoBehaviour
{
    public GoalAchievement goal;
    public CharacterMovement movement;
    public GameObject corps;
    public GameObject nom;
    public GameObject next;
    public GameObject end;
    public Image image;

    private List<string> first_dialog_List;
    private int current_i;
    // Start is called before the first frame update
    void Start()
    {
        current_i = 1;
        first_dialog_List = new List<string>();
        first_dialog_List.Add("Conseiller d'orientation (Dialogue)");
        first_dialog_List.Add("Bonjour et bienvenue dans l'Université de Lorraine. Je suis un conseiller d'orientation stéréoptypiquement déprimé par mon travail, mon nom n'est pas important. Vous ne sortirez pas de mon bureau avant que je fixe votre avenir.");
        first_dialog_List.Add("Pour ne pas perdre plus de temps, veuillez vous asseoir sur la chaise, que nous puissions commencer cette conversation dont les conséquences vous suivront jusqu'à la tombe.");
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.first_dialog)
        {

            if (current_i == 1)
            {
                nom.SetActive(true);
                nom.GetComponent<Text>().text = first_dialog_List[0];

                corps.SetActive(true);
                corps.GetComponent<Text>().text = first_dialog_List[current_i];

                next.SetActive(true);
                image.enabled = true;
            }

            if (Input.GetButtonDown("Pass_Dialog"))
            {
                current_i += 1;
                goal.has_passed_dialog = true;
                if (current_i == first_dialog_List.Count - 1)
                {
                    next.SetActive(false);
                    end.SetActive(true);
                }
                if (current_i < first_dialog_List.Count)
                {
                    corps.GetComponent<Text>().text = first_dialog_List[current_i];
                }
                else
                {
                    nom.SetActive(false);
                    corps.SetActive(false);
                    next.SetActive(false);
                    image.enabled = false;
                    end.SetActive(false);
                    current_i = 1;
                    goal.first_dialog = false;
                    goal.has_finished_dialog = true;
                    movement.is_stunned = false;
                    goal.must_interact = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (goal.must_first_dialog)
        {
            movement.is_stunned = true;
            goal.first_dialog = true;
        }
    }
}
