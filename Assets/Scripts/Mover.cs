using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xIncrement = 0f;
    [SerializeField] float yIncrement = 0f;
    [SerializeField] float zIncrement = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xIncrement, yIncrement, zIncrement);
    }
}
