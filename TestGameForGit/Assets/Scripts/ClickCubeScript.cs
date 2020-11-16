using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCubeScript : MonoBehaviour
{
    public Material redMat;
    public Material bluMat;
    public string matName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        matName = this.gameObject.GetComponent<MeshRenderer>().material.name;
    }

    private void OnMouseDown()
    {
        if(this.gameObject.GetComponent<MeshRenderer>().material.name!= "BlueMat (Instance)")
        {
            this.gameObject.GetComponent<MeshRenderer>().material = bluMat;
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = redMat;
        }
    }
    
}
