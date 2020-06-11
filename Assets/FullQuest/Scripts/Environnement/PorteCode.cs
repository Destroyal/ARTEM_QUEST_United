using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PorteCode : MonoBehaviour
{
    // Start is called before the first frame update
    
    public CharacterMovement1 script;
    public QuestAchievements scriptA;
    private bool is_OK;
    private bool done;
    private List<string> dialog1;
    private List<string> dialog2;

    private bool dialog;

    public Image img;
    public Text nom;
    public Text corps;
    public Image end;
    public GameObject box;
    public GameObject box2;

    private bool open;

    void Start()
    {
        dialog1 = new List<string>();
        dialog2 = new List<string>();
        dialog1.Add("La porte est fermée avec un digicode.");
        dialog2.Add("Vous avez ouvert la porte grâce au digicode caché dans la peinture.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && is_OK)
        {
            dialog = true;
            box.SetActive(false);
            box2.SetActive(true);
            if (done && !open)
            {
                this.GetComponent<BoxCollider2D>().enabled = false;
                this.GetComponent<SpriteRenderer>().enabled = false;
                open = true;
                //Debug.Log(dialog2[0]);
            }
            else
            {
                //Debug.Log(dialog1[0]);
            }
        }

        if (scriptA.code)
        {
            done = true;
        }
        else
        {
            done = false;
        }

        if (dialog)
        {
            img.enabled = true;
            nom.enabled = true;
            corps.enabled = true;
            end.enabled = true;
            nom.text = "Porte Code (Description)";
            if (done)
            {
                corps.text = dialog2[0];
            }
            else
            {
                corps.text = dialog1[0];
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
