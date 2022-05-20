using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usareinspecionar : MonoBehaviour
{

    public GameObject painels;
    public bool menuu;

    void Start()
    {
        menuu = false;
        painels.SetActive(false);
    }

    public void painel()
    {
        painels.SetActive(true);
        menuu = true;
    }
        

   
    public void Update()
    {
        if(painels == true)
        {
            menuu = true;
        }
        else
        {
            menuu = false;
        }

        if (Input.GetMouseButtonDown(1) && menuu == true)
        {
            painels.SetActive(false);
            
            menuu = false;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            painels.SetActive(false);
            menuu = false;
        }
        if(menuu == false)
        {
            painels.SetActive(false);
        }
      
        
    }
}
