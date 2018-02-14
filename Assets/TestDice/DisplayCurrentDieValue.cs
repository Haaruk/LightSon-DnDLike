using UnityEngine;
using System.Collections;

public class DisplayCurrentDieValue : MonoBehaviour
{
    public LayerMask dieValueColliderLayer = -1;

    private int currentValue = 1;

    private bool rollComplete = false;

    // Update is called once per frame
    void Update () {

        //ADD DiceMap for vector3 values of all faces (for all dices) in an external file, in XML-like easy access structure
        //ADD Refactor...

        // Update only when dice is stopped
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb.IsSleeping() && !rollComplete)
        {
            rollComplete = true;
            Debug.Log("Dice stopped rolling, result is: " + currentValue.ToString());
        }
        else if(!rb.IsSleeping())
        {
            rollComplete = false;
        }


        // Finding which face is pointing up

        RaycastHit hit;

        if(Physics.Raycast(transform.position,Vector3.up,out hit,Mathf.Infinity,dieValueColliderLayer))
        {
            // Reading the value of the collider on the die top face
            currentValue = hit.collider.GetComponent<DieValue>().value;
        }
    }

    void OnGUI()
        {
            GUILayout.Label(currentValue.ToString());
        }
    
}
