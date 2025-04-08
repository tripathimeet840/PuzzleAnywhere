using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayinModels : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(" collision name >>>>" + this.gameObject.name);


        if (ApplicationManager.Instance.currentAplhabet == this.gameObject.name)
        {
            Debug.Log(" Right >>>>>");

        }
        else
        {
            Debug.Log(" wrong >>>>>");
        }

    }
}
