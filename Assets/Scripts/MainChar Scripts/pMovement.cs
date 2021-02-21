using UnityEngine;
using System.Collections;

public class pMovement : MonoBehaviour
{
    public float playerSpeed;
    private Animator anim;
    private Rigidbody2D rigbod;


	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        rigbod = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckDirection();
    }

    void CheckDirection ()
    {
        if (Input.GetKey(KeyCode.A)) //Left
        {
            WalkAnim(-1, 0, true);
        }
        else if (Input.GetKey(KeyCode.D)) //Right
        {
            WalkAnim(1, 0, true);
        }
        else if (Input.GetKey(KeyCode.W)) //Up
        {
            WalkAnim(0, 1, true);
        }
        else if (Input.GetKey(KeyCode.S)) //Down
        {
            WalkAnim(0, -1, true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    void FixedUpdate ()
    {
        Move();
    }

    void Move ()
    {
        float dirX = anim.GetFloat("velX");
        float dirY = anim.GetFloat("velY");
        bool walk = anim.GetBool("isWalking");

        if (walk)
        {
            rigbod.velocity = new Vector2(dirX, dirY) * playerSpeed;
        }
        else
        {
            rigbod.velocity = Vector2.zero;
        }
    }

    void WalkAnim (float x, float y, bool walking)
    {
        anim.SetFloat("velX", x);
        anim.SetFloat("velY", y);
        anim.SetBool("isWalking", walking);
    }
}
