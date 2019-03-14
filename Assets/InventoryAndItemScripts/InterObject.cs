using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterObject : MonoBehaviour
{
    public bool inventory; //if true can be stored in inventory
    public bool farmable; //if true is farmable
    public bool talks; // if true the object can talk to the player
    public bool bin;
    public Inventory inv =null;
    public DigitalClock dc = null;
    public GameManager gm = null;
    public GameObject UI;
    public string message;
    public void DoInter()
    {
        //Make item disappear
        if (inventory)
        {
            gameObject.SetActive(false);
        }
        else if (farmable)
        {

        }
        else if (dc && gm)
        {
            dc.restart();
            gm.UpdateTime();
        }
        else if(bin)
        {
            UI.SetActive(true);
        }
    }

    public void Talk()
    {
        Debug.Log(message);
    }

    public void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            if(UI.activeSelf)
            {
                UI.SetActive(false);
            }
        }
    }

}
