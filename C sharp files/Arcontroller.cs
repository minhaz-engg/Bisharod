using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Arcontroller : MonoBehaviour

{
    public GameObject MyObject;
    public ARRaycastManager RayCastManager;





    private void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();



            RayCastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);




            if (touches.Count > 0)
            {

            }

                //GameObject.Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);



        }

    }
}
