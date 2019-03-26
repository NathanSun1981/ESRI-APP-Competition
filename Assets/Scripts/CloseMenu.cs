using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CloseMenu : MonoBehaviour {


    public void OnSelect()
    { 
       Destroy(transform.parent.gameObject);
    }
        
}
