using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        /// Change the color of the boundary upon collison.
        Debug.Log("A boundary has been hit!");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}
