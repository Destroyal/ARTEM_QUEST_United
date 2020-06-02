using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour
{
    //cloud position
    //player
    //LastPosition of cloud
    public float minX, maxX;
    public float distanceY;//distance between two cloud
    public float lastCloudY;

    public GameObject cloud;//NEW CLOUD
    public GameObject player;

    public List<GameObject> clouds;
    public List<GameObject> collectors;
    public int controlCloud = 0;//put the cloud at right or left
    // Start is called before the first frame update
    void Start()
    {
        Shuffle();
        CreateClouds();
        
        PlayerPosition();

        for (var i = 0; i < collectors.Count; i++)
        {
            collectors[i].SetActive(false);
        }
        
    }
    void Shuffle()
    {
        //Debug.Log(clouds.Count);
        for (var i = 0; i < clouds.Count; i++)
        {
            var target = Random.Range(i, clouds.Count);
            Debug.Log(target);
            var temp = clouds[i];
            clouds[i] = clouds[target];
            clouds[target] = temp;
        }
    }
    void CreateClouds()
    {
        var worldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        var worldSize2 = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        //Debug.Log(worldSize2);
        //Debug.Log(worldSize);
        minX = worldSize2.x + 1f;
        maxX = worldSize.x - 1f;

        lastCloudY = 0;//initial position of cloud
        for (var i = 0; i < clouds.Count; i++)
        {
            var cloud = clouds[i];
            Vector3 pos;
            float x = 0;
            //Debug.Log(controlCloud);
            if (controlCloud == 0)
            {
                x = Random.Range(0, maxX);
                controlCloud = 1;
            }
            else if (controlCloud == 1)
            {
                x = Random.Range(minX, 0);
                controlCloud = 2;
            }
            else if (controlCloud == 2)
            {
                x = Random.Range(1,maxX);
                controlCloud = 3;
            }
            else if (controlCloud == 3)
            {
                x = Random.Range(minX, -1);
                controlCloud = 0;
            }
            pos = new Vector3(x, lastCloudY, 0);
            cloud.transform.localPosition = pos;
            lastCloudY -= distanceY;
        }
    }

    // Update is called once per frame
    void PlayerPosition()
    {
        //the first cloud should not be darkcloud
        if (clouds[0].tag == "DarkCloud")
        {
            var c0 = clouds[0];
            var temp = c0.transform.localPosition;
            GameObject whiteCloud = null;
            int whiteId = 0;
            for(var i = 1; i < clouds.Count; i++){
                if (clouds[i].tag == "Cloud")
                {
                    whiteCloud = clouds[i];
                    whiteId = i;
                    break;
                }   
            }
            c0.transform.localPosition =whiteCloud.transform.localPosition;
            whiteCloud.transform.localPosition = temp;

            clouds[0] = whiteCloud;
            clouds[whiteId] = c0;
        }
        var c = clouds[0].transform.localPosition;
        player.transform.localPosition = c + new Vector3(0, 2, 0);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Cloud" || target.gameObject.tag == "DarkCloud")
        {
            if (Mathf.Abs(target.transform.localPosition.y - (lastCloudY + distanceY)) < 0.1f)
            //if(target.transform.localPosition.y ==(lastCloudY+distanceY))
            {
                Shuffle();
                //lastCloudY = 0;//initial position of cloud
                for (var i = 0; i < clouds.Count; i++)
                {
                    var Cloud = clouds[i];
                    if (Cloud.activeSelf == false)//
                    {
                        Vector3 pos;
                        float x = 0;
                        if (controlCloud == 0)
                        {
                            x = Random.Range(0, maxX);
                            controlCloud = 1;
                        }
                        else if (controlCloud == 1)
                        {
                            x = Random.Range(minX, 0);
                            controlCloud = 2;
                        }
                        else if (controlCloud == 2)
                        {
                            x = Random.Range(1, maxX);
                            controlCloud = 3;
                        }
                        else if (controlCloud == 3)
                        {
                            x = Random.Range(minX, -1);
                            controlCloud = 0;
                        }
                        pos = new Vector3(x, lastCloudY, 0);
                        Cloud.transform.localPosition = pos;
                        Cloud.SetActive(true);
                        //Debug.Log("lastCloudY:" + lastCloudY);
                        lastCloudY =lastCloudY-distanceY;

                        var random = Random.Range(0, collectors.Count);
                        var col = collectors[random];
                        if (col.activeSelf == false)//not used 
                        {
                            if (Cloud.tag == "Cloud")
                            {
                                //Debug.Log(Cloud.tag);
                                var temp = Cloud.transform.localPosition;
                                temp.y += 0.5f;
                                col.transform.localPosition = temp;
                                col.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }
}
