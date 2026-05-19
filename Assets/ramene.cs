using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramene : MonoBehaviour
{
    public GameObject oct;
    public GameObject cri;
    public GameObject cricure;
    public GameObject sho;
    public GameObject cake;
    private float otime=0f;
    private float ctime = 0f;
    private float cctime = 0f;
    private float stime = 0f;
    private float ccctime=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       otime += Time.deltaTime;
        if (otime >= 3f)
        {
            otime = 0;
            float n = Random.Range(3, 5);
            for(int i = 0; i < n; i++)
            {
                float x = Random.Range(-28, 28);
                Instantiate(oct, new Vector3(57, x, 0),Quaternion.identity);
            }
        }
        ctime += Time.deltaTime;
        if (ctime >= 2f)
        {
            ctime = 0;
            float n = Random.Range(3, 4);
            for (int i = 0; i < n; i++)
            {
                float x = Random.Range(-28, 28);
                Instantiate(cri, new Vector3(57, x, 0), Quaternion.identity);
            }
        }
        cctime += Time.deltaTime;
        if (cctime >= 10f)
        {
            cctime = 0;
            float n = Random.Range(3, 4);
            for (int i = 0; i < n; i++)
            {
                float x = Random.Range(-50, 50);
                Instantiate(cricure, new Vector3(x, -30, 0), Quaternion.identity);

            }
        }
        stime += Time.deltaTime;
        if (stime >= 15f)
        {
            stime = 0;
            float n = Random.Range(2, 3);
            for (int i = 0; i < n; i++)
            {
                float x = Random.Range(-50, 50);
                Instantiate(sho, new Vector3(x, 30, 0), Quaternion.identity);

            }
        }
        ccctime += Time.deltaTime;
        if (ccctime >= 5f)
        {
            float p = Random.value;
            ccctime = 0;
            if (p <= 0.3)
            {
                float n = Random.Range(2, 3);
                for (int i = 0; i < n; i++)
                {
                    float x = Random.Range(-28, 28);
                    Instantiate(cake, new Vector3(57, x, 0), Quaternion.identity);
                }
            }
        }


    }
}
