using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfesseurARTEM : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CharacterMovement1 script;
    public QuestAchievements scriptA;
    private bool is_OK;
    private bool done;
    private List<string> dialog1;
    private List<string> dialog2;
    private bool dialog;
    public bool do_once;

    public Image img;
    public Text nom;
    public Text corps;
    public Image end;

    public GameObject box;
    public GameObject box2;

    void Start()
    {
        do_once = true;
        dialog1 = new List<string>();
        dialog2 = new List<string>();
        dialog1.Add("Professeur ARTEM : Not completed");
        dialog2.Add("Bonjour. Profitez bien de votre carte d'étudiant ARTEM !");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && is_OK)
        {
            dialog = true;
            //Debug.Log(dialog2[0]);
            done = true;
            scriptA.carte_etu = true;
            box.SetActive(false);
            box2.SetActive(true);

        }

        if (dialog)
        {
            img.enabled = true;
            nom.enabled = true;
            corps.enabled = true;
            end.enabled = true;
            nom.text = "Professeur ARTEM (Dialogue)";
            if (done)
            {
                corps.text = dialog2[0];
                if (do_once)
                {
                    scriptA.must_inventory = true;
                    do_once = false;
                }
            }

        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        is_OK = true;
        box.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        is_OK = false;
        dialog = false;

        img.enabled = false;
        nom.enabled = false;
        corps.enabled = false;
        end.enabled = false;

        box.SetActive(false);
        box2.SetActive(false);
    }
}
