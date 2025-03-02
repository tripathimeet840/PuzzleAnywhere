using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeManager : MonoBehaviour
{
    public GameObject homePanel, numericPanel, alfabeticPanel, settingpanel, Creditpanel;

    public NumericHandler numericprefab;
    public Transform numericHolder;

    private void Start()
    {
        numbergenerete();
    }

    public void numbergenerete()
    {
        for(int i = 0; i <= 50; i++)
        {
            NumericHandler numClone = Instantiate(numericprefab, numericHolder.transform);
            numClone.Text.text = i.ToString();  
        }
    }
    

     public void AlfabetBtn()
    {
        alfabeticPanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void NumericBtn()
    {
        numericPanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void BackFromAlfabet()
    {
        homePanel.SetActive(true);
        alfabeticPanel.SetActive(false);
    }

    public void BackFromNUmeric()
    {
        homePanel.SetActive(true);
        numericPanel.SetActive(false);
    }

    public void SettingBtn()
    {
        settingpanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void CreditBtn()
    {
        Creditpanel.SetActive(true);
        homePanel.SetActive(false);
    }

    public void BackToHome()
    {
        homePanel.SetActive(true);
        Creditpanel.SetActive(false);
        settingpanel.SetActive(false);

    }


    public void RedirectToGameScene(string scene_name)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(scene_name);
    }

    public void QuitBtn()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if PLATFORM_ANDROID
        Application.Quit();
#endif
    }
}
