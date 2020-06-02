using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chair_Trigger : MonoBehaviour
{
    private List<string> list;
    private List<string> list2;

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
    public GameObject inputField;

    public GameObject oui_bouton;
    public GameObject non_bouton;

    public GameObject non1;
    public GameObject non2;

    public GameObject inge;
    public GameObject mana;
    public GameObject arti;

    private bool is_talking;
    public int counter;
    public string classe;

    public InputField inpF;
    public GameObject notice;
    private string nomP;

    public GameObject next;
    public GameObject end;
    public Text text5;

    private bool mlock;
    private bool do_once;

    private SurvivorScript surv_script;
    
    // Start is called before the first frame update
    void Start()
    {
        surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
        is_talking = false;
        list = new List<string>();
        string s0 = "Chaise (Description)";
        string s1 = "Une chaise en bois des plus normales. Voulez vous vous asseoir dessus ?";
        list.Add(s0);
        list.Add(s1);
        is_OK = false;

        list2 = new List<string>();
        string s0_2 = "Conseiller d'orientation (Dialogue)";
        string s1_2 = "Bien, commençons. Qu'est-ce qui vous fait venir dans mon bureau, Monsieur ... Mmmm ... Quel est votre nom déjà ?";
        string s2_2 = "Monsieur X ... Mmmm ...  Intéressant. Vous n'êtes pas le premier X que je vois passer dans ce bureau.";
        string s3_2 = "Un véritable nom de chômeur ... Laissez moi deviner. Aucune perspectives d'avenir ?";
        string s4_2 = "Voilà ce que je vous propose. L'État est en train d'expérimenter un programme spécial, pour les profils irrécupérables comme vous. Un programme qui pourrait, semblerait-il, vous donner une chance.";
        string s5_2 = "L'idée est de vous placer dans une école de Haut Prestige, la crème de la crème française. Ne me demandez pas pourquoi, je ne comprends rien aux manoeuvres politiciennes. Il existe au total 3 écoles susceptibles de vous";
        string s6_2 = "accueillir, toutes placées sur le Ô presitigieux campus ARTEM de Nancy. Au sein de ce campus, chaque école dispense une formation différente. Vous pouvez ainsi devenir Ingénieur, Manager ou bien Artiste.";
        string s7_2 = "Pour laquelle de ces formations avez vous le plus d'appétence, à défaut vous demander un minimum de compétences ..?";
        string s8_2 = "Je peux déjà percevoir la catégorie faits divers dans 5 ans: Monsieur X, Y raté, s'est jeté sur la voie. Voyez vous, on ne perd rien à être réaliste.";
        string s9_2 = "Étant un homme occupé, j'ai d'autres personnes sans avenir à accueillir. Prenez votre papier d'assisté et sortez de mon bureau, maintenant !";
        list2.Add(s0_2);
        list2.Add(s1_2);
        list2.Add(s2_2);
        list2.Add(s3_2);
        list2.Add(s4_2);
        list2.Add(s5_2);
        list2.Add(s6_2);
        list2.Add(s7_2);
        list2.Add(s8_2);
        list2.Add(s9_2);
        list2.Add("");
        counter = 1;
        classe = "Y";
        nomP = "X";
        mlock = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goal.is_interacting && is_OK && !is_talking)
        {
            oui_bouton.SetActive(true);
            non_bouton.SetActive(true);

            nom.SetActive(true);
            nom.GetComponent<Text>().text = list[0];

            corps.SetActive(true);
            corps.GetComponent<Text>().text = list[1];

            image.enabled = true;
        }

        if (is_talking)
        {


            if (counter == 1)
            {
                goal.must_input = true;
                inputField.SetActive(true);
                nomP = inpF.text;
                surv_script.nom = nomP;
                list2[counter+1] = "Monsieur "+nomP+" ... Mmmm ...  Intéressant. Vous n'êtes pas le premier "+nomP+" que je vois passer dans ce bureau.";
                if (Input.GetButtonDown("Submit") && nomP != "")
                {
                    counter += 1;
                }
            }

            else
            {
                goal.has_input = true;
                inputField.SetActive(false);
            }

            if (counter == 3)
            {
                non1.SetActive(true);
                non2.SetActive(true);
                goal.must_useless = true;
            }

            if (counter > 3)
            {
                non1.SetActive(false);
                non2.SetActive(false);
                goal.has_useless = true;
            }

            if (counter == 7)
            {
                goal.must_important = true;
                arti.SetActive(true);
                inge.SetActive(true);
                mana.SetActive(true);

            }

            if (counter > 7)
            {
                arti.SetActive(false);
                inge.SetActive(false);
                mana.SetActive(false);
                goal.has_important = true;
                surv_script.formation = classe;
                list2[8] = "Je peux déjà percevoir la catégorie faits divers dans 5 ans: Monsieur "+nomP+", " + classe + " raté, s'est jeté sur la voie. Voyez vous, on ne perd rien à être réaliste.";
            }

                
            if (counter == 10)
            {
                nom.SetActive(false);
                corps.SetActive(false);
                goal.can_leave = true;
                notice.SetActive(true);
                next.SetActive(false);
                end.SetActive(true);
                if (!mlock) { 
                    text5.text = text5.text + "Formation : " + classe +"\nPropriétaire : " + nomP;
                    mlock = true;
                }
            }

            if (counter < 10)
            {
                nom.SetActive(true);
                corps.SetActive(true);
                image.enabled = true;

                nom.GetComponent<Text>().text = list2[0];
                corps.GetComponent<Text>().text = list2[counter];

                next.SetActive(true);
            }

            if (counter > 10)
            {
                image.enabled = false;
                is_talking = false;
                Player.GetComponent<SpriteRenderer>().enabled = true;
                Player_pawn.SetActive(false);
                movement.is_stunned = false;
                goal.is_interacting = false;
                this.enabled = false;
                notice.SetActive(false);
                end.SetActive(false);
                do_once = true;

            }

            if (Input.GetButtonDown("Pass_Dialog"))
            {
                if (counter != 7 && counter !=3 && counter !=1)
                {
                    counter = counter + 1;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (goal.must_interact || goal.has_interacted)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (!do_once)
                {
                    goal.must_click = true;
                    movement.is_stunned = true;
                    goal.is_interacting = true;
                    goal.has_interacted = true;
                }
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

        is_talking = true;

        //Fade.SetActive(true);
    }
}
