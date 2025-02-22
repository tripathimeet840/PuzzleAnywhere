using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class BoxCreator : MonoBehaviour
{
  //  [SerializeField]
   // ARPlaneManager planeManager;
    [SerializeField]
    GameObject box;
    

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
        Instantiate(box,this.gameObject.transform.position,Quaternion.identity);
    }


}
