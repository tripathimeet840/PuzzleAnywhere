using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    public int array;

    ApplicationManager applicationManager;
    public int startingPoint;


    // Start is called before the first frame update
    void Start()
    {
        if (applicationManager != null)
        {
            if(applicationManager.selectedtype == 0)
            {
                startingPoint = PlayerPrefs.GetInt("ALPHABET");
            }
            else
            {
                startingPoint = PlayerPrefs.GetInt("NUMERICAL");

            }
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
