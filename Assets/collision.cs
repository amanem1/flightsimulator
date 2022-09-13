using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float mass;
    public Rigidbody drone;
        
    // Start is called before the first frame update
    void Start()
    {
        drone = GetComponent<Rigidbody>();
        drone.mass = mass;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
            drone.angularDrag = 1F;
        else
            drone.angularDrag = 0;

    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Cube"))
            {
            drone.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionY;
            drone.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionZ;
            drone.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionX;
        }

    }
}
