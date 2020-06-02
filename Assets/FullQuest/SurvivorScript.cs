using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorScript : MonoBehaviour
{

    public bool once;
    public bool once2;
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

    public Vector3 next;

    public string nom;
    public string formation;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
