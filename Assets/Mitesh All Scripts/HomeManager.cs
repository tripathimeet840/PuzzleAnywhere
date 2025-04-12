using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public GameObject homePanel, numericPanel, alfabeticPanel, settingpanel, Creditpanel;

    public NumericHandler numericprefab;
    public Transform numericHolder;

    public AlfabetHandler alfabetprefab;
    public Transform alfabetHolder;

    public List<AlfabetHandler> alfabetHandlers;    
    public List<char> alfabetlist;

    public List<NumericHandler> numHandlers;

    int m;

    private void Start()
    {
        numbergenerete();
        alfabetgenerete();  
    }

    public void numbergenerete()
    {
        for(int i = 1; i <= 100; i++)
        {
            NumericHandler numClone = Instantiate(numericprefab, numericHolder);
            numClone.Text.text = i.ToString();  
            numHandlers.Add(numClone);
            numClone.NumLockOnOff(true);
            numClone.NumTickOnOff(false);
            numHandlers[0].NumLockOnOff(false);
            numClone.Button.onClick.RemoveAllListeners();
            numClone.Button.onClick.AddListener(() =>
            { 
               SceneManager.LoadScene(2);
            });
        }
    }

    public void alfabetgenerete()
    {
        for(int i = 0;i < alfabetlist.Count; i++)
        {
            AlfabetHandler alfaClone = Instantiate(alfabetprefab, alfabetHolder);
            alfaClone.Text.text = alfabetlist[m].ToString();
            m++;
            alfabetHandlers.Add(alfaClone); 
            alfaClone.AbcLockOnOff(true);
            alfaClone.AbcTickOnOff(false);  
            alfabetHandlers[0].AbcLockOnOff(false);    
            alfaClone.Button.onClick.RemoveAllListeners();
            alfaClone.Button.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(2);
            });
        }

    }
    

     public void AlfabetBtn()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        alfabeticPanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void NumericBtn()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        numericPanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void BackFromAlfabet()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        homePanel.SetActive(true);
        alfabeticPanel.SetActive(false);
    }

    public void BackFromNUmeric()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        homePanel.SetActive(true);
        numericPanel.SetActive(false);
    }

    public void SettingBtn()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        settingpanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void CreditBtn()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        Creditpanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void BackToHome()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
        homePanel.SetActive(true);
        Creditpanel.SetActive(false);
        settingpanel.SetActive(false);

    }

    public void ARSCENE()
    {
        SceneManager.LoadScene(2);
    }



    public void QuitBtn()
    {
        AudioHandler.Instance.audiosource.clip = AudioHandler.Instance.clicksound;
        AudioHandler.Instance.audiosource.Play();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if PLATFORM_ANDROID
        Application.Quit();
#endif
    }
}
