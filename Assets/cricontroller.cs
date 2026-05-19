using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cricontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10f;
    private float t = 0f;
    private float c = 1.4f;
    private float y = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= c)
        {
            t = 0;
            y *= -1;
        }
        transform.Translate(speed * (-1) * Time.deltaTime,y*Time.deltaTime , 0);
        if (transform.position.x < -56) Destroy(gameObject);

    }
}
