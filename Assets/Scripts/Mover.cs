using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed;

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
        xIncrement = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        zIncrement = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xIncrement, 0f, zIncrement);
    }
}
