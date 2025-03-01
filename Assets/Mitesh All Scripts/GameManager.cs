using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject homePanel ,numericPanel, alfabeticPanel;

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
