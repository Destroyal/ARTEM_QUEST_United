using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    public float espacement;
    public int seuil;
    public int obstaclesDepart;
    public static float vitesse= 8 ;
    public GameObject objObstacle;
    public GameObject objSol;
    public Game manager;

    private List<GameObject> obstacles = new List<GameObject>();
    private List<GameObject> ground = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {


        for (int i = 0; i < obstaclesDepart; i++)
        {
            GameObject tmp = (GameObject)Instantiate(objObstacle, new Vector2((float)i * espacement + 15f, (float)Random.Range(5, 9)), Quaternion.identity);
            tmp.transform.parent = this.transform;
            obstacles.Add(tmp);
        }

        for (int i = 1; i < 15; i++)
        {
            GameObject tmp = (GameObject)Instantiate(objSol, new Vector2((float)i * 27f-40f, -7f), Quaternion.identity);
            tmp.transform.parent = this.transform;
            ground.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-vitesse,0f);

        if (Game.score>=(obstacles.Count-seuil))
        {
            GenererObj();
        }
        if (Game.score >= (ground.Count-10))
        {
            GenererSol();
        }
    }

    void GenererObj()
    {
        GameObject tmp = (GameObject)Instantiate(objObstacle, new Vector2(obstacles[obstacles.Count - 1].transform.position.x + espacement, (float)Random.Range(10, 12)), Quaternion.identity);
        tmp.transform.parent = this.transform;
        obstacles.Add(tmp);
    }

    void GenererSol()
    {
        GameObject tmp = (GameObject)Instantiate(objSol, new Vector2(ground[ground.Count - 1].transform.position.x + 27f, -5f), Quaternion.identity);
        tmp.transform.parent = this.transform;
        ground.Add(tmp);
    }
}
