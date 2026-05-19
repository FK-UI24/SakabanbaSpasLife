using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bbb : MonoBehaviour
{
    public void on()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void off()
    {
        SceneManager.LoadScene("title");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
