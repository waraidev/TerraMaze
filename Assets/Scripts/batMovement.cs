using UnityEngine;
using System.Collections;

public class batMovement : MonoBehaviour
{
    Animator anim;
    public float batSpeed = 1f;
    public float distance = 1f;
    protected Vector3 velocity;
    Vector3 ogPosition;
    public Transform trans;
    bool isGoingDown = false;
    public float distFromStart;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        ogPosition = gameObject.transform.position;
        trans = GetComponent<Transform>();
        velocity = new Vector3(0, batSpeed, 0);
        trans.Translate(0, velocity.y * Time.deltaTime, 0);
	}

    // Update is called once per frame
    void Update()
    {
        //Use this for animations
        if (isGoingDown)
        {
            anim.SetBool("moveUp", false);
            anim.SetBool("moveDown", true);
        }
            
        if (!isGoingDown)
        {
            anim.SetBool("moveDown", false);
            anim.SetBool("moveUp", true);
        }
    }

    void FixedUpdate ()
    {
        //Use this for physical movements
        distFromStart = transform.position.y - ogPosition.y;

        if (isGoingDown)
        {
            if (distFromStart < -distance)
                SwitchDirection();

            trans.Translate(0, -velocity.y * Time.deltaTime, 0);
        }
        else
        {
            if (distFromStart > distance)
                SwitchDirection();

            trans.Translate(0, velocity.y * Time.deltaTime, 0);
        }
    }

    void SwitchDirection()
    {
        isGoingDown = !isGoingDown;
    }
}
