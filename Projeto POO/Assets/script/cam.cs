using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    
    public float sensib = 100f;
    public Transform player;
    float xrot = 0f;
    public bool trav;
    bool tr;
    bool rr;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
 

    // Update is called once per frame
    void Update()
    {
        if (trav == false)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensib * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensib * Time.deltaTime;


            xrot -= mouseY;
            xrot = Mathf.Clamp(xrot, -60f, 60f);

            transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
            player.Rotate(Vector3.up * mouseX);

            if (trav == true)
            {


                xrot -= mouseY;
                xrot = Mathf.Clamp(xrot, 0, 0f);


            }
        }
        

    }

}
