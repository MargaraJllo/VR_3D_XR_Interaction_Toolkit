using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject Door;
    public GameObject Door2;

    Animator DoorAnimator;
    Animator DoorAnimator2;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnimator = Door.GetComponent<Animator>();
        DoorAnimator2 = Door2.GetComponent<Animator>();
    }

    public void DoorOpenClose(string condicion)
    {
        if(condicion == "abrir")
        {
            DoorAnimator.SetBool("Open", true);
            DoorAnimator.SetBool("Close", false);
            DoorAnimator2.SetBool("Open", true);
            DoorAnimator2.SetBool("Close", false);
        } else if(condicion == "cerrar")
        {
            DoorAnimator.SetBool("Open", false);
            DoorAnimator.SetBool("Close", true);
            DoorAnimator2.SetBool("Open", false);
            DoorAnimator2.SetBool("Close", true);
        }
    }

  



    // Update is called once per frame
    void Update()
    {
        
    }
}
