using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public bool occupied;
    public Vector3 worldPosition;

    public Node(bool _occupied, Vector3 _worldPos) {

        occupied = _occupied;
        worldPosition = _worldPos;
    }

}
