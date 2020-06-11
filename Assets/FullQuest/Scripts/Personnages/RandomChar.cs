using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomChar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public QuestAchievements scriptA;
    private bool is_OK;
    private List<string> dialog1;
    private bool dialog;

    public Image img;
    public Text nom;
    public Text corps;
    public Image end;

    public GameObject box;
    public GameObject box2;

    void Start()
    {
        dialog1 = new List<string>();
        dialog1.Add("Je suis inutile. Bonne journée !");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact") && is_OK)
        {
            dialog = true;
            box.SetActive(false);
            box2.SetActive(true);
        }

        if (dialog)
        {
            img.enabled = true;
            nom.enabled = true;
            corps.enabled = true;
            end.enabled = true;
            nom.text = "Random (Dialogue)";
            corps.text = dialog1[0];
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
