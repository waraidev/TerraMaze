using UnityEngine;
using System.Collections;

public class lightMoveUp : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            lumos.enabled = true;
            key = KeyCode.W;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            lumos.enabled = false;
            key = KeyCode.None;
        }

        if (key == KeyCode.W)
            lumos.enabled = true;
    }
}
