using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class esc : MonoBehaviour
{
    public usareinspecionar bl;
    public AudioSource resp;
    public cam nv;
    
    // Start is called before the first frame update
    public GameObject menuu;
    public GameObject inve, painels;
    public bool inv;
    public bool isPause;
    public int pausa;
    public bool inspec;
    public videop vid;


    void Start()
    {
        menuu.SetActive(false);
        inve.SetActive(false);
        resp.Play();
        inspec = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            isPause = !isPause;

            if (isPause)
            {
                bl.menuu = false;
                pause();
             Cursor.lockState = CursorLockMode.None;
             
            }
            else
            {
                vid.sound.Play();
                vid.videope.Play();
                bl.menuu = false;
                resume();      
                Cursor.lockState = CursorLockMode.Locked;
                
            }
        }
        if (Input.GetKeyDown(KeyCode.Tab) && isPause == false)
        {
            painels.SetActive(false);
            inv = !inv;
            
            nv.trav = true;
            if (isPause == false && inv)
            {
                
                inve.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
               
            }
            else
            {
                
                invent();
            }
       
        }
           
        if (Input.GetMouseButton(1) && inv == true && isPause == false)
        {
           
            inspec = false;
            inve.SetActive(true);
            
        }
        if(inspec == false)
        {
            
            pausa = 0;
        }
        if (inspec == true)
        {
           
             pausa = 1;
        }

    }

    public void invent()
    {
        nv.trav = false;
        
        inv = false;
        inspec = false;
        inve.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        pausa = 0;

    }

   public void pause()
   {
       
        pausa = 1;
        menuu.SetActive(true);
        Time.timeScale = 0;
        nv.trav = false;
        inv = false;
       
        inve.SetActive(false);
        inspec = false;
        resp.Pause();
    }

    public void resume()
    {
        pausa = 0;
        isPause = false;
        menuu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        vid.sound.Play();
        vid.videope.Play();
        resp.Play();

    }
    public void voltarpromenu()
    {
        menuu.SetActive(false);
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        
    }
}
