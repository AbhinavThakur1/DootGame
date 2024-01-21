using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shouldbeconnected : MonoBehaviour
{
    [SerializeField] GameObject cont1;
    [SerializeField] GameObject cont2;

    void Update()
    {
        if(cont1.activeSelf && cont2.activeSelf)
        {

        }
        else if (cont1.activeSelf)
        {
            Invoke("Reseton", 1f);
        }
        else if (cont2.activeSelf)
        {
            Invoke("Reseton", 1f);
        }
    }

    void Reseton()
    {
        Dataclass.start = false;
        foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
        {
            if (i.on)
            {
                foreach (GameObject j in i.images)
                {
                    j.SetActive(false);

                }
                i.images.Clear();
                i.on = false;
                i.connected = false;
            }
        }
    }

}
