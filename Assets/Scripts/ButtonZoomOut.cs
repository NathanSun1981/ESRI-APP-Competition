using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Esri.HoloLens.APP;

public class ButtonZoomOut : MonoBehaviour {

    // Use this for initialization
    public TerrainMap terrain;
    public void Update()
    {
        if (terrain.MapLevel <= terrain.MinMapLevel)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

    public void OnSelect()
    {
        this.gameObject.SendMessageUpwards("OnClickZoomOut");
    }
}
