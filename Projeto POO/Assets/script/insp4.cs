using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class insp4 : MonoBehaviour
{
    public insp2 i;
    public UnityEvent inter;
    public GameObject Target;
    public float horizontalSpeed = 1.5F;
    public float verticalSpeed = 1.5F;

    private void OnMouseDown()
    {
        i.trava = 4;
        inter.Invoke();


    }
    // Update is called once per frame
    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        if (Input.GetMouseButton(0) && i.trava == 4)

        {
            MouseSpin();
        }

        if (Input.GetMouseButtonDown(1))
        {
            
            Cursor.lockState = CursorLockMode.Locked;
           
        }

    }

    void MouseSpin()
    {


        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //v = Mathf.Clamp(v, 1, -1);
        Target.transform.position = transform.position + (new Vector3(horizontalSpeed * h * Time.deltaTime, verticalSpeed * v * Time.deltaTime, 0));
    }
}
