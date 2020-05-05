using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceClass : MonoBehaviour
{
    public Chair_Trigger script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickInge()
    {
        script.counter = script.counter + 1;
        script.classe = "Ingénieur";
    }

    public void ClickMana()
    {
        script.counter = script.counter + 1;
        script.classe = "Manager";
    }

    public void ClickArt()
    {
        script.counter = script.counter + 1;
        script.classe = "Artiste";
    }
}
