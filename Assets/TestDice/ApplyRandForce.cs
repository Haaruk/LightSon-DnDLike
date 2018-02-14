using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyRandForce : MonoBehaviour {

    public string buttonName = "Fire1";
    public float forceAmount = 10.0f;
    public float torqueAmount = 10.0f;
    public ForceMode forceMode;
    
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown(buttonName))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Random.onUnitSphere*forceAmount,forceMode); 
            rb.AddTorque(Random.onUnitSphere * torqueAmount, forceMode);
        }
	}
}
