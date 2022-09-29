using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject startP1;
    
    void Start()
    {
        
    }

    
    void Update()
    {   
        if(Input.GetMouseButtonDown(0) || (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))){
            Ray ray = new Ray(startP1.transform.position, startP1.transform.forward);
            Debug.Log("°Ý¹ß");
            RaycastHit hitInfo;

            if(Physics.Raycast(ray, out hitInfo)){
                if(hitInfo.transform.gameObject.layer == LayerMask.NameToLayer("Target")){
                    // Target targ = hitInfo.transform.GetComponent<Target>();
                    // targ.HitTarget();
                }
                Debug.Log(hitInfo.transform.name);
            }

        }
        
        
    }
}
