using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekrar : MonoBehaviour
{
   
    public float y�kseklik, zaman, verilenZaman, ziplamaGucu;
    public Transform �lk;
    public Text Timer;
   
    // Start is called before the first frame update
    void Start()
    {
        zaman = verilenZaman;
     
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        Timer.text = zaman.ToString();

        if(transform.position.y <= y�kseklik)
        {
            transform.position = �lk.position;

        }
        if (zaman <= 0)
        {
         
            transform.position = �lk.position;
            zaman = verilenZaman;
           
           
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * ziplamaGucu);
        }

      
    
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision temasEdilen)
    {
        if (temasEdilen.gameObject.tag == "kap�")
        {
            
        
            Application.LoadLevel(1);
        
        }
    }
}
