using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumee : MonoBehaviour
{
    [SerializeField] private AudioMixer meu;

    public void setvolume(float sliderValue)
    {
        meu.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
