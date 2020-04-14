using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    float minX, maxX;
    // Start is called before the first frame update
    void Start()
    {
        var worldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        var worldSize2 = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        minX = worldSize2.x + 0.5f;
        maxX = worldSize.x - 0.5f;
    }
    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.localPosition.x < minX){
            var oldPos = this.gameObject.transform.localPosition;
            oldPos.x = minX;
            this.gameObject.transform.localPosition =oldPos;
        }else if(this.gameObject.transform.localPosition.x > maxX){
            var oldPos = this.gameObject.transform.localPosition;
            oldPos.x = maxX;
            this.gameObject.transform.localPosition =oldPos;
        }
    }
}
