using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawn : MonoBehaviour
{
    public float lastPosY;
    public float distanceY;//last position of BG
    public List<GameObject> bgs;
    // Start is called before the first frame update
    void Start()
    {
        InitLastPosY();
    }
    void InitLastPosY()
    {
        lastPosY = 0;
        for (var i = 0; i < bgs.Count; i++)
        {
            var b = bgs[i];
            if (b.transform.localPosition.y < lastPosY)
            {
                lastPosY = b.transform.localPosition.y;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (Mathf.Abs(target.transform.localPosition.y - lastPosY) < 0.1f)
        {
            for (var i = 0; i < bgs.Count; i++)
            {
                var b = bgs[i];
                if (b.activeSelf == false)
                {
                    b.transform.localPosition = new Vector3(0, lastPosY - distanceY, 0);
                    b.SetActive(true);
                    lastPosY = lastPosY - distanceY;
                }
            }
        }
        
    }
}
