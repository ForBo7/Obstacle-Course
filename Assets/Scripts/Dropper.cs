using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    /// <summary>
    /// A class that drops obstacles after a specified time.
    /// </summary>

    [SerializeField] float timeToWait;

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        InitializeComponents();
    }

    // Update is called once per frame
    void Update()
    {
        FallObject();
    }

    private void InitializeComponents()
    {
        /// Get the required components and disable to required properties.
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    private void FallObject()
    {
        /// Cause the object to fall after a specified time has lapsed.
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }

}
