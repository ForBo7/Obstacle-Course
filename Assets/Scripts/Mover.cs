using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float xIncrement;
    float zIncrement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Translate the object.
        xIncrement = Input.GetAxis("Horizontal");
        zIncrement = Input.GetAxis("Vertical");
        transform.Translate(xIncrement, 0f, zIncrement);
    }
}
