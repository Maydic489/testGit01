using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TappingScript : MonoBehaviour
{
    public Material redMat;
    public Material bluMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                var ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hitInfo;
                if(Physics.Raycast(ray, out hitInfo))
                {
                    var rig = hitInfo.collider.GetComponent<Rigidbody>();
                    if (rig != null)
                    {
                        if (rig.gameObject.GetComponent<MeshRenderer>().material.name != "RedMat (Instance)")
                        {
                            rig.gameObject.GetComponent<MeshRenderer>().material = redMat;
                        }
                        else
                        {
                            rig.gameObject.GetComponent<MeshRenderer>().material = bluMat;
                        }
                    }
                }
            }
        }
    }
}
