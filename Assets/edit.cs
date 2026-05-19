using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class edit : MonoBehaviour
{
    private float time = 0f;
    public GameObject sc = null;
    private int HP = 100;
    public GameObject b;
    private Material g;
    private byte Bg=255;
    public GameObject panel;
    private GameObject player;
    private bool tr=false;
    private float stime=0f;
    private float f=15f;
    private float ctime = 0f;
    private bool TR = false;
    public GameObject star;
    private float k=1.5f;
    Text total;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            if (TR == false)
            {
                HP -= 10;
                Bg -= 25;
                g.color = new Color32(Bg, Bg, Bg, 255);
            }
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("cri"))
        {
            if (HP == 100) { }
            else{
                HP += 10;
                Bg += 25;
                g.color = new Color32(Bg, Bg, Bg, 255);
            }
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("sho"))
        {
            stime = 0;
            tr = true;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("cake"))
        {
            ctime = 0;
            TR = true;
            k = transform.localScale.x*1.2f;
            transform.localScale=new Vector3(k,k,0);
            Destroy(collision.gameObject);
        }



    }
    // Start is called before the first frame update
    void Start()
    {
        g = b.GetComponent<Renderer>().material;
        g.color = new Color32(255,255,255,255);
        total = sc.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            total.text = "SCORE     "+(int)(time*100000);
            panel.SetActive(true);
        }
        else
        {
            time = Time.deltaTime;
        }
        if (tr == true)
        {
            stime += Time.deltaTime;
            GetComponent<playercontroller>().speed= f*(-1);
            if (stime >= 5f)
            {
                tr = false;
                GetComponent<playercontroller>().speed = f;
            }
        }
        if (TR == true)
        {
            ctime += Time.deltaTime;
            star.SetActive(true);
            if (ctime >= 5)
            {
                TR = false;
                star.SetActive(false);
            }
        }
    }
}
