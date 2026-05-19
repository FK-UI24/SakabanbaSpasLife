using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttom : MonoBehaviour
{
    public GameObject music;
    private AudioSource a;
    public void onpless() {
        
        a.PlayOneShot(a.clip);

        SceneManager.LoadScene("SampleScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        a= music.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
