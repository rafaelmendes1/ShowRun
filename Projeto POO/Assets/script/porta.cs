using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    public keypad clear;
    // Start is called before the first frame update
    void Start()
    {
        clear.zerar = false;
    }

    // Update is called once per frame
    public void clea()
    {
        clear.zerar = true;
        
    }
}
