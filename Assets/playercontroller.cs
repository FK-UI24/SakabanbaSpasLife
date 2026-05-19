using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation=Quaternion.Euler(0,0,0);
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(new Vector3(speed * Time.deltaTime ,0,0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate( new Vector3(0,speed * Time.deltaTime * (-1),0));
        }


    }
}
