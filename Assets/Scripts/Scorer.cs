using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    /// <summary>
    /// A class to keep track of the number of collisions.
    /// </summary>

    int numberOfCollisons = 0;
    private void OnCollisionEnter(Collision collision)
    {
        /// Increment the number of collisions and display it.
        ++numberOfCollisons;
        Debug.Log($"You've collided {numberOfCollisons} times!");
    }
}
