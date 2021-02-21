using UnityEngine;
using System.Collections;

public class pController : MonoBehaviour {
	
	//Inspector Variables
	public float playerSpeed;  // movement speed of player
	private string upKey = "w";
	private string rightKey = "d";
	private string leftKey = "a";
	private string downKey = "s";
    // handles calls to four functions for each of the allowable player movements
    // For now, we only allow movement in the four cardinal directions (NSEW)


	void Update ()
	{
		MoveUp();
		MoveRight();
		MoveLeft();
		MoveDown();
	}
	
	private void MoveUp()
	{
        if (Input.GetKey(upKey))
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
    }

    private void MoveRight()
	{
		if(Input.GetKey(rightKey))
		{
			transform.Translate(playerSpeed * Time.deltaTime,0,0);
		}
    }
	
	private void MoveLeft()
	{
		if(Input.GetKey(leftKey))
		{
			transform.Translate(-playerSpeed * Time.deltaTime,0,0);
		}
    }
	
	private void MoveDown()
	{
		if(Input.GetKey(downKey))
		{
			transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
		}
    }
}
