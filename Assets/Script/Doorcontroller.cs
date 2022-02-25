using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontroller : MonoBehaviour
{
    public GameObject Door;

    Animator DoorAnimator;
    // Start is called before the first frame update
    void Start()
    {
        DoorAnimator = Door.GetComponent<Animator>();
    }

    public void DoorOpenClose(string condicion)
    {
        if (condicion == "abrir")
        {
            DoorAnimator.SetBool("Open", true);
            DoorAnimator.SetBool("Close", false);

        }

        else if (condicion == "cerrar")
        

            {
                DoorAnimator.SetBool("Open", false);
                DoorAnimator.SetBool("Close", true);

            }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
