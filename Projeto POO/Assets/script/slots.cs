using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class slots : MonoBehaviour
{
    public int numero = 1;
    public UnityEvent inventclick;
    private string userInput = "";
    // Start is called before the first frame update
 


    private void OnMouseDown()
    {

        inventclick.Invoke();
    }
    void Update()
    {
        
    }
}
