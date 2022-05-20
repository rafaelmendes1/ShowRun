using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class insp2 : MonoBehaviour
{
   
    public GameObject Target;
    public float horizontalSpeed = 1.5F;
    public float verticalSpeed = 1.5F;
    public UnityEvent inter;
    public float trava;
    private void OnMouseDown()
    {
             trava = 1;
            inter.Invoke();


    }
    // Update is called once per frame
    public void Update()
    {
        if(trava == 1)
        {
            Cursor.lockState = CursorLockMode.None;
            if (Input.GetMouseButton(0))

            {
                MouseSpin();
            }

            if (Input.GetMouseButtonDown(1))

            {
                Cursor.lockState = CursorLockMode.Locked;
                
                
            }
        }
      

    }

    public void MouseSpin()
    {


        float z = horizontalSpeed * Input.GetAxis("Mouse X");
        float x = verticalSpeed * Input.GetAxis("Mouse Y");
        //v = Mathf.Clamp(v, 1, -1);
        gameObject.transform.position = transform.position + (new Vector3(horizontalSpeed * z * Time.deltaTime, verticalSpeed * x * Time.deltaTime, 0));
    }

}
