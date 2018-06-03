using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomOGManager : MonoBehaviour
{
    [SerializeField]
    private Transform _leftHandAnchor;
    private Transform _rightHandAnchor;
    private Transform _centerEyeAnchor;


    private bool _isControllerConnected = false;
    void Awake(){
        
    }

	// Use this for initialization
	void Start () {
		
	}

    void Update(){
        if(OVRInput.IsControllerConnected(OVRInput.Controller.LTrackedRemote) || OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote)){
            _isControllerConnected = true;
        }else{
            _isControllerConnected = false;
        }

        if(this.isActiveAndEnabled){
            var controller = OVRInput.GetActiveController();
            if(controller == OVRInput.Controller.LTrackedRemote){
                
            }
        }
    }
}
