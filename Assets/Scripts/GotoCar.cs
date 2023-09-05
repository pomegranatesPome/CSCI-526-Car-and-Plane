using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GotoCar : MonoBehaviour
{
    public Button GotoCarButton;
    
    // Start is called before the first frame update
    void Start()
    {   
        GotoCarButton.gameObject.SetActive(true);
        GotoCarButton.onClick.AddListener(LoadCar);
    }
    private void LoadCar()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("CarPrototype", LoadSceneMode.Single);
    }
    
}
