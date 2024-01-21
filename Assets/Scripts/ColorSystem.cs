using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

public class ColorSystem : MonoBehaviour
{
    [SerializeField] GameObject Image;

    private void Update()
    {
        if (Dataclass.start)
        {
            if (Input.mousePosition.x <= transform.position.x + 50f && Input.mousePosition.x >= transform.position.x - 50f &&
                Input.mousePosition.y <= transform.position.y + 50f && Input.mousePosition.y >= transform.position.y - 50f)
            {
                if (!Image.activeSelf)
                {
                    Image.GetComponent<Image>().color = Dataclass.Clr;
                    Image.SetActive(true);
                    foreach(ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
                    {
                        if (i.on)
                        {
                            i.images.Add(Image);
                        }
                    }
                }else if (Image.GetComponent<Image>().color == Dataclass.Clr)
                {
                    Image.SetActive(true);
                    foreach (ButtonClickHandler i in FindObjectsOfType<ButtonClickHandler>())
                    {
                        if (i.on)
                        {
                            i.images.Add(Image);
                        }
                    }
                }
                else
                {
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
                            Dataclass.start = false;
                        }
                    }
                }
            }
        }
    }
}
