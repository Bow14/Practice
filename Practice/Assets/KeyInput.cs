using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	// now this was a tutorial and i could of done getbutton down but its really the same thing for different control schemes 
	
	// Update is called once per frame
	void Update ()
	{
		bool down = Input.GetKeyDown(KeyCode.Space);
		bool held = Input.GetKey(KeyCode.Space);
		bool up = Input.GetKey(KeyCode.Space);

		if (down)
		{
			Debug.Log("Im Down");
		}
		else if (held)
		{
			Debug.Log("hold it");
		}
		else if (up)
		{
			Debug.Log("im free");
		}
		else
		{
			Debug.Log("Norm");
		}
		
		{
			
		}
	}
}
