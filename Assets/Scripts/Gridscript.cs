using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridscript : MonoBehaviour {

    /* Plan : Display a grid on the TableMat the size of the mat
     *        return the closest Snaping point
     *        return if item fits on mat
     */

    private float xScale;
    private float zScale;
    private GameObject[] grid;

    void Awake() {

        //Display a grid on the TableMat the size of the mat
        xScale = transform.lossyScale.x/2;
        zScale = transform.lossyScale.z/2;

        for(float i = -xScale; i <= xScale; i += GameConstants.SIZE) {

            for(float y = 0; y <= 2 * zScale; y += GameConstants.SIZE) {

                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                sphere.transform.position = new Vector3(i, 2.251f, -GameConstants.SIZE + y);
                sphere.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

            }
        }



    }

}

//Grid Version 1 bof results
/*public float size = 0.25f;
    public float maxSizeX;
    public float maxSizeZ;
    public float matLocationX;
    public float matLocationZ;

    void Awake() {
        maxSizeX = transform.localScale.x/2 / size;
        maxSizeZ = transform.localScale.z/2 / size;
        matLocationX = transform.position.x;
        matLocationZ = transform.position.z;
    }
    

    public Vector3 GetNearestPointOnGrid(Vector3 position) {
        position -= transform.position;

        int xCount = Mathf.Clamp(Mathf.RoundToInt(position.x / size),-(int)maxSizeX, (int)maxSizeX);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.Clamp(Mathf.RoundToInt(position.z / size),-(int)maxSizeZ, (int)maxSizeZ);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

        result += transform.position;

        return result;
    }

   private void OnDrawGizmos() {
    
        Gizmos.color = Color.yellow;

        for(float x = -3.25f; x <= 3.25f; x += size) {

            for(float z = -0.25f; z <= 3.25; z += size) {

                var point = GetNearestPointOnGrid(new Vector3(x, transform.position.y, z));

                Gizmos.DrawSphere(point, 0.02f);

            }

        }
    }*/
