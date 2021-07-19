using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    /// <summary>
    /// Spins an object continuously by the desired amount.
    /// </summary>
    ///

    [SerializeField] float xRotation;
    [SerializeField] float yRotation;
    [SerializeField] float zRotation;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(
                xRotation * Time.deltaTime,
                yRotation * Time.deltaTime,
                zRotation * Time.deltaTime
            );
    }
}
