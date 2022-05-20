using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class zoom : MonoBehaviour
{
    public vuzualiza viz;
    public bool insp;
    public GameObject itemui;
    public esc ite;
    [SerializeField]
    private CanvasScaler Target;

    [SerializeField]
    private float MinimumScale = 0.5f;

    [SerializeField]
    private float MaximumScale = 4.5f;

    [SerializeField]
    public float scaleFactor;
    
    private float scale = 1.25f;


     public void inspecionar()
    {

        insp = false;
            scale = 1.25f;
            scaleFactor = 1.25f;
            itemui.SetActive(true);


    }

   


    private void Start()
    {
       // insp = false;
        itemui.SetActive(false);
        scale = transform.localScale.x;
    }

    public void Update()
     {

       
        if (Input.GetAxis("Mouse ScrollWheel") != 0 && itemui == true)
       {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Target.scaleFactor += 0.25f;
                if(Target.scaleFactor >= MaximumScale)
                {
                    Target.scaleFactor = MaximumScale;
                }
                
            }

           if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                
                Target.scaleFactor -= 0.25f;
                if (Target.scaleFactor <= MinimumScale)
                {
                    Target.scaleFactor = MinimumScale;
                }
            }
        }
        else
        {
            scaleFactor = scale;
        }
        if(insp == true && itemui == true)
        {
            itemui.SetActive(false);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
 
    }
  
}

