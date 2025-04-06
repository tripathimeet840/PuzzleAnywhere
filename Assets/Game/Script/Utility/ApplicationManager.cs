using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{

    public static ApplicationManager Instance;

    #region Public Var
    public GameManager GameManager;

    public int selectedtype = 0;
    public int lastPlayedObject = 0;

    #endregion

    #region Private Var

    

    #endregion


    #region Unity Callbacks

    private void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this.gameObject);


    }
    // Start is called before the first frame update
    void Start()
    {
        selectedtype = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion




    #region Data Management

    public void ExecuteSpawn(Transform POS)
    {
        Debug.LogWarning("Execute Spawn >>>");


        if (GameManager == null)
        {
            Debug.Log("nullll >>>>>>>>>>>>>>>>>>>>>> GAme Manager");
        }
        else
        {

            Debug.Log("<color=green>NOT NULLLLL >>>>>>>>>>>>>>>>>>>>>> Game Manager</color>");
        }
        GameManager.GameDataExecution(POS);
    }



    #endregion
}
