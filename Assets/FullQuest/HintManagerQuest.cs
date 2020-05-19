using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HintManagerQuest : MonoBehaviour
{

    public Text text;
    public Image hint_img;
    public Image check_img;
    public QuestAchievements script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (script.must_inventory)
        {
            hint_img.enabled = true;
            text.enabled = true;
            text.text = "Appuyez sur I pour activer / désactiver la visualisation de votre inventaire";
        }

        if (script.is_inventory)
        {
            check_img.enabled = true;
        }

        if (script.has_inventory)
        {
            hint_img.enabled = false;
            text.enabled = false;
            check_img.enabled = false;

        }
    }
}
