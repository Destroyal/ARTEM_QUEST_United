using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintManager2 : MonoBehaviour
{ 
    public Image image;
    public Text text;
    public GoalAchievement goal;
    public GameObject check;
    private List<string> HintList;
    // Start is called before the first frame update
    void Start()
    {
        HintList = new List <string>();
        string h1 = "Utilisez les touches Z,Q,S,D pour vous déplacer.";
        string h2 = "Appuyez sur Espace pour faire avancer un dialogue.";
        string h3 = "Appuyez sur E pour intéragir avec votre environnement.";
        string h4 = "Cliquez sur l'une des options pour faire un choix.";
        string h5 = "Appuyez sur Entrée pour valider votre nom.";
        string h6 = "Certains choix réalisés n'ont pas d'impact sur l'histoire.";
        string h7 = "D'autres choix ont cependant une importance capitale.";
        string h8 = "Quittez le bureau pour commencer le jeu.";
        HintList.Add(h1);
        HintList.Add(h2);
        HintList.Add(h3);
        HintList.Add(h4);
        HintList.Add(h5);
        HintList.Add(h6);
        HintList.Add(h7);
        HintList.Add(h8);
        text.text = (string) HintList[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(goal.must_walk && goal.has_walked)
        {
            check.SetActive(true);
            goal.must_walk = false;
            goal.must_first_dialog = true;
        }
        if (goal.must_first_dialog && goal.first_dialog && !goal.has_passed_dialog)
        {
            text.text = (string) HintList[1];
            check.SetActive(false);
            goal.must_first_dialog = false;       
        }

        if (goal.first_dialog && goal.has_passed_dialog && !goal.has_finished_dialog)
        {
            check.SetActive(true);
        }
        if (goal.must_interact && !goal.has_interacted)
        {
            text.text = (string)HintList[2];
            check.SetActive(false);
        }
        if( goal.must_interact && goal.has_interacted)
        {
            check.SetActive(true);
            goal.must_interact = false;
        }
        if(goal.must_click && !goal.has_clicked)
        {
            check.SetActive(false);
            text.text = (string)HintList[3];
        }
        if(goal.must_click && goal.has_clicked)
        {
            goal.must_click = false;
            check.SetActive(true);
        }
        if (goal.must_input && !goal.has_input)
        {
            text.text = (string)HintList[4];
            check.SetActive(false);
        }
        if (goal.must_input && goal.has_input)
        {
            goal.must_input = false;
            check.SetActive(true);
        }
        if (goal.must_useless && !goal.has_useless)
        {
            text.text = (string)HintList[5];
            check.SetActive(false);
        }
        if (goal.must_useless && goal.has_useless)
        {
            goal.must_useless = false;
            check.SetActive(true);
        }
        if (goal.must_important && !goal.has_important)
        {
            text.text = (string)HintList[6];
            check.SetActive(false);
        }
        if (goal.must_important && goal.has_important)
        {
            goal.must_important = false;
            check.SetActive(true);
        }
        if (goal.can_leave && !goal.leave)
        {
            text.text = (string)HintList[7];
            check.SetActive(false);

        }
        if (goal.can_leave && goal.leave)
        {
            goal.can_leave = false;
            check.SetActive(true);
        }

    }
}
