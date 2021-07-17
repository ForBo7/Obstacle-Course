using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    /// <summary>
    /// A class to display whether an object has been collided with.
    /// </summary>

    private void OnCollisionEnter(Collision collision)
    {
        /// Change the color of the boundary upon collison.
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}
