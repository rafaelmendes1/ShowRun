using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class interacao : MonoBehaviour
{
    public UnityEvent inter;
    public esc es;

    private void OnMouseDown()
    {
        if(trav == true) 
        {
            inter.Invoke();
           
        }
       
    }

    bool trav;
    bool pause;


    public void Update()
    {

        if (es.pausa == 1)
        {
            pause = true;
        }
        else
        {
            pause = false;
        }

        if (pause == true)
        {
            trav = false;
        }
        else
        {
            trav = true;
        }
    }
}
