using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class videop : MonoBehaviour
{
    public AudioSource sound;
    public VideoPlayer videope;
    public Animator a;
    public GameObject fracaco;
    public AudioSource perdeu, regressiva, setin, cincin, tresin, ummin;
    // Start is called before the first frame update
    void Awake()
    {
        fracaco.SetActive(false);
        sound.Play();
        videope = GetComponent<VideoPlayer>();
        videope.Play();
        a.SetBool("tra", true);
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                                
                if (videope.isPlaying)
                {
                    videope.Pause();
                     sound.Pause();
                }
                else
                {
                    sound.Play();
                    videope.Play();

                }
            }

    }


    public void menuuu()
    {
        videope.Pause();
        sound.Pause();
        fracaco.SetActive(true);

        if(fracaco == true)
        {
            Cursor.lockState = CursorLockMode.None;
            perdeu.Play();
        }

    }
    public void narra��o1()
    {
        setin.Play();
    }
    public void narra��o2()
    {
        cincin.Play();
    }
    public void narra��o3()
    {
        tresin.Play();
    }
    public void narra��o4()
    {
        ummin.Play();
    }
    public void narra��o5()
    {
        regressiva.Play();
    }
    public void narra��o6()
    {

    }
}
