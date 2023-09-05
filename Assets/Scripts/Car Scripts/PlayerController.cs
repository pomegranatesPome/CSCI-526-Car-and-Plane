using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float carSpeed = 10;
    public float turnSpeed = 10;

    [SerializeField]
    private float horizontalInput;
    [SerializeField]
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * forwardInput);

        // vehicle translates (slides)
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // vehicle rotates
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
 