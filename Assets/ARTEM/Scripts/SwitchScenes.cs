using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public QuestAchievements quest;
    public Vector3 tf;
    private SurvivorScript surv_script;
    // Start is called before the first frame update
    void Start()
    {
        surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CROUS_To_ARTEM()
    {
        surv_script.must_inventory = quest.must_inventory;
        surv_script.is_inventory = quest.is_inventory;
        surv_script.has_inventory = quest.has_inventory;

        surv_script.carte_etu = quest.carte_etu;
        surv_script.carte_izly = quest.carte_izly;
        surv_script.corde = quest.corde;
        surv_script.tuba = quest.tuba;
        surv_script.jouet = quest.jouet;
        surv_script.code = quest.code;
        surv_script.cle = quest.cle;

        SceneManager.LoadScene("FullARTEM");
    }

    public void ARTEM_To_CROUS()
    {
        surv_script.next = tf;

        surv_script.must_inventory = quest.must_inventory;
        surv_script.is_inventory = quest.is_inventory;
        surv_script.has_inventory = quest.has_inventory;

        surv_script.carte_etu = quest.carte_etu;
        surv_script.carte_izly = quest.carte_izly;
        surv_script.corde = quest.corde;
        surv_script.tuba = quest.tuba;
        surv_script.jouet = quest.jouet;
        surv_script.code = quest.code;
        surv_script.cle = quest.cle;

        SceneManager.LoadScene("Crous");
    }

    public void ending()
    {
        surv_script.must_inventory = quest.must_inventory;
        surv_script.is_inventory = quest.is_inventory;
        surv_script.has_inventory = quest.has_inventory;

        surv_script.carte_etu = quest.carte_etu;
        surv_script.carte_izly = quest.carte_izly;
        surv_script.corde = quest.corde;
        surv_script.tuba = quest.tuba;
        surv_script.jouet = quest.jouet;
        surv_script.code = quest.code;
        surv_script.cle = quest.cle;

        SceneManager.LoadScene("ENSAD");
    }

    public void MiniGame()
    {

        surv_script.next = new Vector3(236.16f, 89.74f, -0.81f);

        surv_script.must_inventory = quest.must_inventory;
        surv_script.is_inventory = quest.is_inventory;
        surv_script.has_inventory = quest.has_inventory;

        surv_script.carte_etu = quest.carte_etu;
        surv_script.carte_izly = quest.carte_izly;
        surv_script.corde = quest.corde;
        surv_script.tuba = quest.tuba;
        surv_script.jouet = quest.jouet;
        surv_script.code = quest.code;
        surv_script.cle = quest.cle;

        SceneManager.LoadScene("Game");
    }

    public void MiniGame2()
    {

        surv_script.next = new Vector3(42.42f, 15.36f, -0.81f);

        surv_script.must_inventory = quest.must_inventory;
        surv_script.is_inventory = quest.is_inventory;
        surv_script.has_inventory = quest.has_inventory;

        surv_script.carte_etu = quest.carte_etu;
        surv_script.carte_izly = quest.carte_izly;
        surv_script.corde = quest.corde;
        surv_script.tuba = quest.tuba;
        surv_script.jouet = quest.jouet;
        surv_script.code = quest.code;
        surv_script.cle = quest.cle;

        SceneManager.LoadScene("GamePlay");
    }

}
