using UnityEngine;
using System.Collections;

public class lightMoveRight : MonoBehaviour
{
    private Light lumos;
    private KeyCode key;

    // Use this for initialization
    void Start()
    {
        lumos = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        lumos.enabled = false;
        LightChange();
    }

    void LightChange()
    {
        if (Input.GetKey(KeyCode.D))
        {
            lumos.enabled = true;
            key = KeyCode.D;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A))
        {
            lumos.enabled = false;
            key = KeyCode.None;
        }

        if (key == KeyCode.D)
            lumos.enabled = true;
    }
}
