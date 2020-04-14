using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sp = this.gameObject.GetComponent<SpriteRenderer>();
        float width = sp.bounds.size.x;
        //Debug.Log(width);
        float swidth = Screen.width;
        float sheight = Screen.height;
        //Debug.Log(swidth + ":" + sheight);

        float sz = Camera.main.orthographicSize;
        float sc = sheight / swidth;
       // Debug.Log(sz + ":" + sc);

        float cameraHeight = sz * 2;
        float cameraWidth = cameraHeight / (sc);
        float spriteScale = cameraWidth / width;
        this.transform.localScale = new Vector3(spriteScale, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
