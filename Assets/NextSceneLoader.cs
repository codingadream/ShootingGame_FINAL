using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("stage1", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
