using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GotoPlane : MonoBehaviour
{
    public Button GotoPlaneButton;
    
    // Start is called before the first frame update
    void Start()
    {   
        GotoPlaneButton.gameObject.SetActive(true);
        GotoPlaneButton.onClick.AddListener(LoadPlane);
    }
    private void LoadPlane()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("PlanePrototype", LoadSceneMode.Single);
        
    }
    
}
