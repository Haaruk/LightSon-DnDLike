using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour {

    //private Gridscript gridscript;
    [SerializeField]private GameObject prefab;

	// Use this for initialization
	//void Awake () {

        //gridscript = FindObjectOfType<Gridscript>();

	//}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0)) {

            RaycastHit hitInfo;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hitInfo)) {

                if(hitInfo.collider.name == "TableMat") {

                    //PlaceItemOnScreen(hitInfo.point);
                    Debug.Log("Would place things here : " + hitInfo.point);
                }
            }

        }

    }

/*    private void PlaceItemOnScreen(Vector3 clickPoint) {
        
        var finalPosition = gridscript.GetNearestPointOnGrid(clickPoint);
        var size = gridscript.size;
        float xAdjust = 0;
        float yAdjust = prefab.transform.localScale.y / 2;
        float zAdjust = 0;

        if(finalPosition.x + (prefab.transform.localScale.x / 2) > gridscript.maxSizeX * size) {
            
            xAdjust = -finalPosition.x - (prefab.transform.localScale.x / 2) + gridscript.maxSizeX * size + gridscript.matLocationX;

        } else {

            if(finalPosition.x - (prefab.transform.localScale.x / 2) < -gridscript.maxSizeX * size) {
                
                xAdjust = -finalPosition.x + (prefab.transform.localScale.x / 2) - gridscript.maxSizeX * size - gridscript.matLocationX;

            }

        }

        if(finalPosition.z + (prefab.transform.localScale.z / 2) > gridscript.maxSizeZ * size + gridscript.matLocationZ) {

            zAdjust = -finalPosition.z - (prefab.transform.localScale.z / 2) + gridscript.maxSizeZ * size + gridscript.matLocationZ;

        } else {

            if(finalPosition.z - (prefab.transform.localScale.z / 2) < -gridscript.maxSizeZ * size + gridscript.matLocationZ) {

                zAdjust = -finalPosition.z + (prefab.transform.localScale.z / 2) - gridscript.maxSizeZ * size + gridscript.matLocationZ;

            }

        }

        finalPosition += new Vector3(xAdjust, yAdjust, zAdjust);
        Instantiate(prefab, finalPosition, Quaternion.identity);

    }*/
}
