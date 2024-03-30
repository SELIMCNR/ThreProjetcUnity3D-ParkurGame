using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class altın : MonoBehaviour
{

    public float deger;
    public Text Skor;
    public int puan = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Skor.text = deger.ToString("f0");

    }
    private void OnCollisionEnter(Collision altin)
    {
        if(altin.gameObject.tag == "altin")
        {
            deger += 5;
            Destroy(altin.gameObject);

        }
        if(altin.gameObject.tag == "altin")
        {
            puan--;
        }
        if (puan <= 0)
        {
            Application.LoadLevel(0);
        }
    }
}
