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
        PrintIntroduction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintIntroduction()
    {
        /* Introduce the player. */
        Debug.Log("Welcome to Obstacle Course!");
        Debug.Log("Avoid obstacles to win the game.");
        Debug.Log("Use WASD or the arrow keys to control Cap Man.");
    }

    void MovePlayer()
    {
        /* Translate the object. */
        xIncrement = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        zIncrement = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(xIncrement, 0f, zIncrement);
    }
}
