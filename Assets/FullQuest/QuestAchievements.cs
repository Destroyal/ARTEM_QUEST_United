using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestAchievements : MonoBehaviour
{
    //Hints -- Default Value = false
    
    //Prévoir un délai de fermeture
    public bool must_inventory;
    public bool is_inventory;
    public bool has_inventory;

    //Achievement
    public bool carte_etu;
    public bool carte_izly;
    public bool corde;
    public bool tuba;
    public bool jouet;
    public bool code;
    public bool cle;

    private SurvivorScript surv_script;

    //Achievement
    //public float time;

    // Start is called before the first frame update
    void Start()
    {

        surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();

        must_inventory = surv_script.must_inventory;
        is_inventory = surv_script.is_inventory;
        has_inventory = surv_script.has_inventory;

        carte_etu = surv_script.carte_etu;
        carte_izly = surv_script.carte_izly;
        corde = surv_script.corde;
        tuba = surv_script.tuba;
        jouet = surv_script.jouet;
        code = surv_script.code;
        cle = surv_script.cle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
