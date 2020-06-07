using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    public Player script;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (right)
        {
            script.blockright = true;
        }
        else
        {
            script.blockleft = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (right)
        {
            script.blockright = false;
        }
        else
        {
            script.blockleft = false;
        }
    }
}
