using UnityEngine;
using System.Collections;

public class lightMoveLeft : MonoBehaviour 
{
	private Light lumos;
	private KeyCode key;

	// Use this for initialization
	void Start () 
	{
		lumos = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		lumos.enabled = false;
		LightChange ();
	}
		
	void LightChange()
	{
        if (Input.GetKey(KeyCode.A))
        {
            lumos.enabled = true;
            key = KeyCode.A;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            lumos.enabled = false;
            key = KeyCode.None;
        }
           
		if (key == KeyCode.A)
			lumos.enabled = true;
	}
}