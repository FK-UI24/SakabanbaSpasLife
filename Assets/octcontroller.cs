using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed=10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * (-1)*Time.deltaTime, 0, 0);
        if (transform.position.x < -56) Destroy(gameObject);
    }
}
