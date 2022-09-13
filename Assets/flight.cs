using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour
{
    public float flyspeed = 30;
    public float yawamount = 100;
    private float yaw;
    private float drag = 0.01f;
    private Vector3 intialpostion;

    void start()
    {
        intialpostion = new Vector3(-12, -22, 10);
        transform.position = intialpostion;
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * flyspeed * Time.deltaTime;
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        yaw += horizontalinput*yawamount*Time.deltaTime;
        float pitch = Mathf.Lerp(0, 20, Mathf.Abs(verticalInput)) * Mathf.Sign(verticalInput);
        float  roll = Mathf.Lerp(0, 20, Mathf.Abs(horizontalinput)) * -Mathf.Sign(horizontalinput);

        transform.localRotation = Quaternion.Euler(Vector3.up * yaw + Vector3.right * pitch + Vector3.forward * roll + Vector3.down*drag);

    }
    
}
