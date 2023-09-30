using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Map : MonoBehaviour
{
    //this script is attached to the map UI 
    //it opens the map panel and allows players to move to different areas of the map. 
    //the camera will move to different locations using transform
    //location settings
    public Transform camp; 
    public Transform forest;
    public Transform cafe; 
    public Transform cabin;
    public Transform lake;
    public GameObject MapPanel;

    Transform currentLocation;    
    public GameObject camera; 

    void Start()
    {
        //set the location to the center of the camp; 

    }
    // Update is called once per frame
    void Update()
    {
        if(currentLocation.transform.position != camera.transform.position){
            camera.transform.position = currentLocation.position;
        }     
    }    
    //used to change the location
    void SetLocation( Transform tp){
        currentLocation = tp;
    }

    void EnableMap(){
        if(MapPanel.active==  true){
        MapPanel.SetActive(true);
        }
         else{
             MapPanel.SetActive(false);
         }
    }


}
