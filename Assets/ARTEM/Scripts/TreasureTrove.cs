using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureTrove : MonoBehaviour

{
    public QuestAchievements qa;
    public CharacterMovement1 cm;
    public GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) 
    {
        cm.is_stunned = true;
        qa.has_inventory = false;
        fade.SetActive(true);

    }
}
