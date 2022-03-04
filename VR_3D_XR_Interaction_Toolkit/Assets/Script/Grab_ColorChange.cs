using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grab_ColorChange : MonoBehaviour
{

    public Material GreenColor =null;
    public Material PurpleColor = null;
    private MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabInteractable = null;
    // Start is called before the first frame update

    void Awake(){
        gameObject.GetComponent<MeshRenderer>();

    }

    public void SetColor(Material Color)
    {
       // meshRenderer.material = Color;
    }

 
 }
