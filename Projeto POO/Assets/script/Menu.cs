using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    
    public GameObject menuu;
    public GameObject stts;
    public GameObject ctrls;
    public GameObject conf;
    int resolucaoatual = 0;

    Resolution[] resolutions;
    public Dropdown resodropdown;
    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;

        resodropdown.ClearOptions();
       
        List<string> options = new List<string>();
        for (int i =4; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height )
            {
                resolucaoatual = i;
            }
        }

        resodropdown.AddOptions(options);
        resodropdown.value = resolucaoatual;
        resodropdown.RefreshShownValue();


        stts.SetActive(false);
        menuu.SetActive(true);
    }


    public void play()
    {

        //AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("First Room");
        SceneManager.LoadScene("transicao");
    }
    public void quit()
    {
        Application.Quit();
    }
    public void async()
    {
        SceneManager.LoadScene("transicao");
    }
    public void painels()
    {
        stts.SetActive(true);
        menuu.SetActive(false);
        ctrls.SetActive(false);
        conf.SetActive(false);
    }
    public void painelsd()
    {
        stts.SetActive(false);
        menuu.SetActive(true);
      
    }
    public void controles()
    {
        ctrls.SetActive(true);
        conf.SetActive(false);
    }
    public void credts()
    {
        ctrls.SetActive(false);
        conf.SetActive(false);
    }
    public void confg()
    {
        ctrls.SetActive(false);
        conf.SetActive(true);
    }

    public void qualidadegrafica(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void fullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void volumegeral(float volume)
    {

    }

    public void resolucao(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
