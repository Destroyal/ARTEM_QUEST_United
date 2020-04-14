using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float easySpeed = 1;
    public float MeidumSpeed = 2;
    public float HardSpeed = 3;
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt(GamePreference.Easy) == 1)
        {
            speed = easySpeed;
        }
        if (PlayerPrefs.GetInt(GamePreference.Medium) == 1)
        {
            speed = MeidumSpeed;
        }
        if (PlayerPrefs.GetInt(GamePreference.Hard) == 1)
        {
            speed = HardSpeed;
        }
        Debug.Log("speed:"+speed);
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        var oldY = this.gameObject.transform.localPosition;
        oldY.y = oldY.y - speed * Time.deltaTime;
        this.gameObject.transform.localPosition = oldY;
    }
}
