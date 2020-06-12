using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnARTEM : MonoBehaviour
{
    // Start is called before the first frame update
    private SurvivorScript surv_script;
    public GameObject Personnage;
    void Start()
    {
        surv_script = GameObject.Find("Survivor").GetComponent<SurvivorScript>();
        Personnage.transform.position = surv_script.next;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
