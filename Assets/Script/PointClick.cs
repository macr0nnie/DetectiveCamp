using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointClick : MonoBehaviour
{

    public Notebook nt; //this is terriable and i am a bad and lazy programmer
    RaycastHit hit;
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    }

    //detect click 
    void Update()
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            if (hit.collider != null)
            {
                Debug.Log("hit something");
                //check what kind of interactable the item was
                //do the logic behind the code
                nt.AddEntry("Received a call from an unknown number.");
                hit.collider.gameObject.SetActive(false);

            }
            //if the right click is pressed down on a object that can be pressable
            // Debug.Log( "Get mouse button down");            
        }
    }
}
