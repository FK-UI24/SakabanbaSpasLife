using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakecontroller : MonoBehaviour
{
    private float speed=10f;
    private float r =10f;
    private float c = 0f;
    private float time = 0f;
    private float h = 0.001f;
    private Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        p = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > h) {
            c += 0.005f;
            time = 0;
            p.x -= 0.01f;
        }
        transform.position=new Vector3(p.x+r*Mathf.Cos(c),p.y + r * Mathf.Sin(c), p.z);
        if (transform.position.x < -56) Destroy(gameObject);
    }
}
