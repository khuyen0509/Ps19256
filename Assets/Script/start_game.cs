using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void batdau1() {
        SceneManager.LoadScene("Man1");
    }

    public void batdau2()
    {
        SceneManager.LoadScene("Man2");
    }
}
