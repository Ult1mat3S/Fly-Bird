using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenLogic : MonoBehaviour
{
    public GameObject playScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
