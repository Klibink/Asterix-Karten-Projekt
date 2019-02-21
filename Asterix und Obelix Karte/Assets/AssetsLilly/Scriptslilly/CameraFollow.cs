using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform Playerpos;
    private Vector3 CameraOffset;

    [Range(0.01f,1.0f)] //Rangebutton
    public float SmoothFactor = 0.5f;

    // Use this for initialization
    void Start(){
        CameraOffset = transform.position - Playerpos.position; // Um Distanz zwischen Kamera und Player beizubehalten
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
    void LateUpdate() { 
    
        Vector3 newCamPos = Playerpos.position + CameraOffset;
        transform.position = Vector3.Slerp(transform.position, newCamPos, SmoothFactor);

    }
}
