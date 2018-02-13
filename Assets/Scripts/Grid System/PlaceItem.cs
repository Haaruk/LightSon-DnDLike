using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour {

    Gridscript grid;

    private void Start() {
        grid = gameObject.GetComponent<Gridscript>();
    }

    private void Update() {

        if(Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray, out hitPoint)) {

                Debug.Log(hitPoint.point);

                grid.NodeFromWorldPoint(hitPoint.point).occupied = true;
                

            }


        }
         
    }

}
