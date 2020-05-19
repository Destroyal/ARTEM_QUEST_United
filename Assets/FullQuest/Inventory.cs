using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    private bool A_switch;
    public GameObject inventory;
    public QuestAchievements script;
    private bool do_once;
    private bool do_once2;

    public Image carte_etu;
    public Image corde;
    public Image code;
    public Image tuba;
    public Image carte_izly;
    public Image cle;

    // Start is called before the first frame update
    void Start()
    {
        do_once = true;
        do_once2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            A_switch = !A_switch;
            inventory.SetActive(A_switch);
            if (A_switch && do_once)
            {
                do_once = false;
                script.must_inventory = false;
                script.is_inventory = true;
            }

            if (!A_switch && do_once2)
            {
                do_once2 = false;
                script.has_inventory = true;
                script.is_inventory = false;
            }

            carte_etu.enabled = script.carte_etu;
            corde.enabled = script.corde;
            code.enabled = script.code;
            tuba.enabled = script.tuba;
            carte_izly.enabled = script.carte_izly;
            cle.enabled = script.cle;

        }

    }
}
