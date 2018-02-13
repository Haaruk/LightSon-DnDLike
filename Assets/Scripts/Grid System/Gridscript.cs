using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridscript : MonoBehaviour {

    /* Plan : Display a grid on the TableMat the size of the mat
     *        return the closest Snaping point
     *        return if item fits on mat
     */

     //find out if something is on the grid space
     //layerMasks maybe?
     public Vector2 gridWorldSize;
     public float nodeRadius;
     public Node[,] grid;

     float nodeDiameter;
     int gridSizeX, gridSizeY;

     void Start(){
        nodeRadius = 0.1f;
        nodeDiameter = nodeRadius * 2;
        gridWorldSize = new Vector2(transform.lossyScale.x * 10, transform.lossyScale.z * 10);
        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
        
        CreateGrid();

     }

     void CreateGrid(){

        grid = new Node[gridSizeX,gridSizeY];
        Vector3 worldBottomLeft = transform.position - 
                                  Vector3.right * gridWorldSize.x / 2 -
                                  Vector3.forward * gridWorldSize.y / 2;

        for (int x = 0; x < gridSizeX; x++){

            for (int y = 0; y < gridSizeY; y++){

                Vector3 worldPoint = worldBottomLeft + 
                                      Vector3.right * (x * nodeDiameter + nodeRadius) +
                                      Vector3.forward * (y * nodeDiameter + nodeRadius);
                bool occupied = false; //TODO
                grid[x,y] = new Node(occupied,worldPoint);

            }
        }
     }

     public Node NodeFromWorldPoint(Vector3 worldPosition){

        float percentX = (worldPosition.x + gridWorldSize.x / 2) / gridWorldSize.x;
        float percentY = (worldPosition.z + gridWorldSize.y / 2) / gridWorldSize.y;
        percentX = Mathf.Clamp01(percentX);
        percentY = Mathf.Clamp01(percentY);

        int x = Mathf.RoundToInt((gridSizeX-1) * percentX);
        int y = Mathf.RoundToInt((gridSizeY-1) * percentY);

        return grid[x,y];

     }


    void OnDrawGizmos() {
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));


        if(grid != null) {
            foreach(Node n in grid) {
                Gizmos.color = (n.occupied) ? Color.white : Color.red;
                Gizmos.DrawCube(n.worldPosition, Vector3.one * (nodeDiameter - .01f));
            }
        }
    }

}