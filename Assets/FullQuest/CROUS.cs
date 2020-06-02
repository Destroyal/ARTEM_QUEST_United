using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CROUS : MonoBehaviour
{
    public SwitchScenes switchS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        switchS.tf = this.transform.position;
        switchS.ARTEM_To_CROUS();
    }
}
