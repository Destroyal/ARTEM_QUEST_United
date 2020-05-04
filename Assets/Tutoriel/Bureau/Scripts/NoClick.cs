using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoClick : MonoBehaviour
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

    public void OnClick()
    {
        script.counter = script.counter + 1;
    }
}
