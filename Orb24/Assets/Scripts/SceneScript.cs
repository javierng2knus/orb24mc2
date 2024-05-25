using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public int switching = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switching == 1) {
            switching = 0;
            SceneManager.LoadScene("SampleScene");
        }
        if (switching == 2) {
            switching = 0;
            SceneManager.LoadScene("Main Menu");
        }

    }

    public void GoToGameScene() {
        SceneManager.LoadScene("SampleScene");
    }
}
