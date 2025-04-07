using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingModelsCaptain : MonoBehaviour
{

    [SerializeField]
    Transform[] PlayinModels;

    GameManager gameManager;


    [SerializeField]
    PlayinModels[] selectedPrefabs;

    [SerializeField]
    List<string> selectedPrefabsName = new List<string>();

    //Start is called before the first frame update
    void Start()
    {

        ApplicationManager.Instance.GameManager = gameManager;


        //??>>>>>> Demo of prefab loading models from the resources folder or directory
        //Debug.Log(" Playing Models Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+gameManager);
        //GameObject myPrefab = Resources.Load<GameObject>("Apple");
        //GameObject instance = Instantiate(myPrefab,this.transform.position,Quaternion.identity);
        ObjectSelection();


        //Debug.Log(" starty model captain " + this.gameObject.name);
        ////Debug.Log(" starty model captain parentName "+this.gameObject.transform.parent.name);   
        //Debug.Log(" starty model captain local pos" + this.gameObject.transform.localPosition);
        //Debug.Log(" starty model captain POS " + this.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }



    #region Prefabs Set Up

    /// <summary>
    /// This methosd is used to select the models to place in AR section
    /// </summary>
    /// 
    char rc;
    string stringDict;
    void ObjectSelection()
    {

        Debug.Log("  current aplhabet >>>>>>"+ApplicationManager.Instance.currentAplhabet);
        //selectedPrefabsName[0] = "Red";
        //Debug.Log("  current aplhabet >>>>>>" + ApplicationManager.Instance.currentAplhabet);

        selectedPrefabsName.Add(ApplicationManager.Instance.currentAplhabet);


        for (int i = 1; i < 4; i++)
        {

            rc = ((char)('A' + Random.Range(0, 26)));

            //selectedPrefabsName[i] =  ((char)('A' + Random.Range(0, 26))).ToString();

            if (rc.ToString() != ApplicationManager.Instance.currentAplhabet)
            {
                //selectedPrefabsName[i] = rc.ToString();
                stringDict = StringDictionary.charValues[rc];

                selectedPrefabsName.Add(stringDict);

            }

            if (i == 3)
            {
                ObjectSpawn();
            }

        }


    }

    /// <summary>
    /// Used to spawn objects and place it 
    /// </summary>
    /// 
    GameObject temp;
    GameObject preFab;
    void ObjectSpawn()
    {

        Debug.Log(" ObjectSpawn Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>" );
        for (int i = 0; i <= selectedPrefabsName.Count; i++)
        {
            preFab = Resources.Load<GameObject>(selectedPrefabsName[i]); 
            temp = Instantiate(preFab, PlayinModels[i].localPosition,Quaternion.identity);
            selectedPrefabs[i] = temp.GetComponent<PlayinModels>();
        }


        //    Debug.Log(" Playing Models Start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>" + gameManager);
        //    GameObject myPrefab = Resources.Load<GameObject>("Apple");
        //    GameObject instance = Instantiate(myPrefab, this.transform.position, Quaternion.identity);
    }



    #endregion



}
