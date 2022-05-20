using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class code : MonoBehaviour
{
    
    public int numero = 1;

    public UnityEvent keypadclicked;
    private void OnMouseDown()
    {
        
        keypadclicked.Invoke();
    }

}
