using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;

public class GameManager : MonoBehaviour
{

    #region Public Var

    [SerializeField]
    public int array;
    public int startinglevel;

    #endregion

    //ApplicationManager applicationManager;

    #region Private Var

    int selectedType;
    List<ARRaycastHit> arHits = new List<ARRaycastHit>();

    [SerializeField]
    List<PlayingModelsCaptain> alphabets;

    [SerializeField]
    List<PlayingModelsCaptain> numericals;

    //List<Models> models;

    [SerializeField]
    ARRaycastManager raycastManager;

    [SerializeField]
    ARPlaneManager planeManager;

    [SerializeField]
    Camera arCamera;

    [SerializeField]
    List<GameObject> planList = new List<GameObject>();

    [SerializeField]
    PlayingModelsCaptain spawnedBattleField;

    bool spawned;
    private GameObject planeIndicatorInstance;
    private GameObject defaultPlaneIndicator;
    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        //applicationManager = FindAnyObjectByType<ApplicationManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" start gamemanager ");

       
        ApplicationManager.Instance.GameManager = this;

        //if (applicationManager != null)
        //{
        //    selectedType = applicationManager.selectedtype;
        //    if (selectedType == 0)
        //    {

        //        Debug.Log("  selected Type " + selectedType);
        //        startinglevel = PlayerPrefs.GetInt("ALPHABET");
        //    }
        //    else
        //    {
        //        startinglevel = PlayerPrefs.GetInt("NUMERICAL");
        //        Debug.Log("  selected Type " + selectedType);

        //    }

        //    GameDataExecution();
        //}

        //else
        //{
        //    Debug.LogWarning("<color=red>Application Manager is Null</color>");
        //    return;
        //}
       // GameDataExecution();



    }
    bool temp = false;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SpawnBattlefield(Vector3.zero, Quaternion.identity);
        //}

        //Debug.Log(" arcamera " + arCamera.name);
        //Ray rayOrigin = arCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));

        //if (raycastManager == null)
        //{
        //    Debug.LogWarning(" Raycast  null >>>");
        //}

        //if (raycastManager.Raycast(rayOrigin, arHits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        //{

        //    if (spawned || temp)
        //    {
        //        return;
        //    }
        //    Debug.LogWarning("<color=blue> Raycast innnn >>> </color>");
        //    ShowPlaneIndicator(arHits[0].pose.position, arHits[0].pose.rotation);

        //    if (arHits != null)
        //    {
        //        Debug.LogWarning(" ARHIT NOT null >>>");
        //    }
        //    else
        //    {
        //        Debug.LogWarning(" <color=red> ARHIT  null >>> </color>");

        //    }

        //    if (Input.touchCount == 1)
        //    {

        //        Debug.Log("<color=green>  Spawn battle field</color>");
        //        SpawnBattlefield(arHits[0].pose.position, arHits[0].pose.rotation);
        //    }
        //    temp = true;
        //}
        //else
        //{
        //    if (planeIndicatorInstance != null)
        //    {
        //        Destroy(planeManager);

        //    }

        //}


    }

    #endregion

    #region Game Logic Execution

    public void GameDataExecution(Transform spawnPoition)
    {
        Debug.Log("  SpawnBattlefield >>>>>>>>>>>>>>>>>>> ");
        Debug.Log("  SpawnBattlefield Models  >>>>>>>>>>>>>>>>>>> " + alphabets[0].gameObject.name);

        selectedType = 0;

        if (selectedType == 0)
        {
            Debug.Log("Game Execution");
            SpawnBattlefield(spawnPoition, Quaternion.identity,selectedType);
            Debug.Log(" name " + raycastManager.raycastPrefab.gameObject.name);
            //raycastManager.raycastPrefab = models[0].gameObject ;
            //Debug.Log(" name after replacement >>> " + raycastManager.raycastPrefab.gameObject.name);

        }
        else
        {
            

        }

      
    }

    void SpawnBattlefield(Transform vector3, Quaternion rot,int type)
    {

        
        Debug.Log(" <color = pink > models present in touch click >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> </color>");

        //spawnedBattleField = Instantiate(models[type], vector3.position, rot);
        if (spawnedBattleField != null)
        {
            if(selectedType == 0) 
            {
                spawnedBattleField = Instantiate(alphabets[type], vector3.position, rot);
                spawned = true;
                ClearPlane();
                Debug.Log(spawnedBattleField.name);

            }
            else
            {
                spawnedBattleField = Instantiate(numericals[type], vector3.position, rot);
                spawned = true;
                ClearPlane();
                Debug.Log(spawnedBattleField.name);
            }


           

        }
        else
        {
            Debug.Log("   GB NUll ????????>>>");
        }
    }

    private void ClearPlane()
    {
         planeManager.enabled = false;
        //planeManager.

        //for (int i = 1; i <= planList.Count; i++)
        //{
        //    {
        //        Destroy(planList[i].gameObject);
        //    }

        //    planList.Clear();
        //}
    }
    #endregion

    #region AR function


    //private void ShowPlaneIndicator(Vector3 pos, Quaternion rot)
    //{

    //    Debug.Log("Spawn Battle field >>>>>>>>>>>>>>>>>" + pos);
    //    if (planeIndicatorInstance == null)
    //    {
    //        planeIndicatorInstance = Instantiate(defaultPlaneIndicator,
    //            pos, rot);
    //        planList.Add(planeIndicatorInstance);

    //    }
    //    else
    //    {
    //        planeIndicatorInstance.transform.position = pos;
    //    }
    //}
    #endregion

    //public class Models
    //{
    //    public List<PlayingModelsCaptain> modelsType;
    //}
    //public List<First> nestedList = new List<First>();

}
