using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed = 60;
    public GameObject textContainer;
    [SerializeField]
    private float verticalInput;
    [SerializeField]   
    private int collisionCount;
    [SerializeField]  
    private TextMeshProUGUI counterText;
 
    void Start()
    {
        collisionCount = 0;
        counterText = textContainer.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * -verticalInput);

        //update the collision counter on screen
        counterText.text = "Collision Count: " + collisionCount.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle"){
            Debug.Log("Collision Detected.");
            collisionCount += 1;
        }
    }
}
