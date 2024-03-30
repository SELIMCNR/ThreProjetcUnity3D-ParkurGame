using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public bool dur;
    public GameObject Panel;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            dur= !dur;
           
        }
        if (dur)
        {
            Panel.SetActive(true);
            Time.timeScale = 0;
         
        }
        
        if (!dur)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
         

        }
        
    }

 


}
