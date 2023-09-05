using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    [SerializeField]
    private int currentCamIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cameras.Length; i++)
        {   
            // set all cameras except the 0th one to inactive
            cameras[i].gameObject.SetActive(i == currentCamIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Deactivate the current camera
            cameras[currentCamIndex].gameObject.SetActive(false);

            // Increment the camera index to the next camera
            currentCamIndex = (currentCamIndex + 1) % cameras.Length;

            // Activate the new current camera
            cameras[currentCamIndex].gameObject.SetActive(true);
        }
    }
}



   