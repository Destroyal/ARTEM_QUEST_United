using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
	public GUISkin skin;
	private bool showmsg = true;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=0.0f;
    }

    void OnGUI ()
    {	
    	if(showmsg)
    	{
    		GUI.skin = skin;
 	   		GUI.Button(new Rect(Screen.width/2-70,Screen.height/2-15,140,30), "Cliquer pour jouer");
    		if(Input.anyKeyDown)
    		{
    			Time.timeScale = 1.0f;
    			showmsg = false;
    		}
    	}
    }
}
