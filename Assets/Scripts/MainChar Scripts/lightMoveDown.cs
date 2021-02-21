using UnityEngine;
using System.Collections;

public class lightMoveDown : MonoBehaviour
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
        if (Input.GetKey(KeyCode.S))
        {
            lumos.enabled = true;
            key = KeyCode.S;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            lumos.enabled = false;
            key = KeyCode.None;
        }

        if (key == KeyCode.S)
            lumos.enabled = true;
    }
}
