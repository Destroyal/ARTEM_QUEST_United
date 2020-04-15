using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MaxSpeed = 4;
    public float Force = 4;

    public Rigidbody2D mybody;
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mybody = this.gameObject.GetComponent<Rigidbody2D>();
        myAnimator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

    }
    void PlayerMove()
    {
        var x = Input.GetAxis("Horizontal");
        var xforce = 0.0f;

        //Debug.Log(x);
        if (x > 0)
        {
            xforce = Force * x;
            myAnimator.SetBool("walk", true);
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (x < 0)
        {
            xforce = Force * x;
            myAnimator.SetBool("walk", true);
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            xforce = 0;
            myAnimator.SetBool("walk", false);
        }
        var xspeed = mybody.velocity.x;
        if (Mathf.Abs(xspeed) >= MaxSpeed)
        {
            if (xforce * xspeed > 0)
            {
                xforce = 0;
            }
        }
        mybody.AddForce(new Vector2(xforce, 0));
    }
}
