using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay = 8.0f;

    // Update is called once per frame
    void Update()
    {
        // Every frame the speed of the dog will slowdown at the speed of -1.
        dogDelay -= 0.1f;
        // On spacebar press
        if (Input.GetKeyDown(KeyCode.Space) && dogDelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Return speed to 20.
            dogDelay = 12.0f;
        }
    }
}

