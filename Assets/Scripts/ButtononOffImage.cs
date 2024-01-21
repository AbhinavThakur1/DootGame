using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtononOffImage : MonoBehaviour
{
    [SerializeField] GameObject top;
    [SerializeField] GameObject left;
    [SerializeField] GameObject right;
    [SerializeField] GameObject bottom;
    [SerializeField] GameObject topImage;
    [SerializeField] GameObject leftImage;
    [SerializeField] GameObject rightImage;
    [SerializeField] GameObject bottomImage;
    [SerializeField] GameObject[] tobeon;
    void Update()
    {
        if(!topImage.activeSelf && !leftImage.activeSelf && !rightImage.activeSelf && !bottomImage.activeSelf)
        {
            foreach(GameObject i in tobeon)
            {
                i.SetActive(true);
            }
        }
        else if(topImage.activeSelf && leftImage.activeSelf)
        {
            right.SetActive(false);
            bottom.SetActive(false);
        }
        else if (topImage.activeSelf && rightImage.activeSelf)
        {
            left.SetActive(false);
            bottom.SetActive(false);
        }
        else if (topImage.activeSelf && bottomImage.activeSelf)
        {
            right.SetActive(false);
            left.SetActive(false);
        }
        else if (leftImage.activeSelf && rightImage.activeSelf)
        {
            top.SetActive(false);
            bottom.SetActive(false);
        }
        else if (leftImage.activeSelf && topImage.activeSelf)
        {
            right.SetActive(false);
            bottom.SetActive(false);
        }
        else if (leftImage.activeSelf && bottomImage.activeSelf)
        {
            top.SetActive(false);
            right.SetActive(false);
        }
        else if(rightImage.activeSelf && bottomImage.activeSelf)
        {
            top.SetActive(false);
            left.SetActive(false);
        }
        else if (rightImage.activeSelf && topImage.activeSelf)
        {
            bottom.SetActive(false);
            left.SetActive(false);
        }
        else if (rightImage.activeSelf && leftImage.activeSelf)
        {
            top.SetActive(false);
            bottom.SetActive(false);
        }
        else if (bottomImage.activeSelf && rightImage.activeSelf)
        {
            top.SetActive(false);
            left.SetActive(false);
        }
        else if (bottomImage.activeSelf && topImage.activeSelf)
        {
            right.SetActive(false);
            left.SetActive(false);
        }
        else if (bottomImage.activeSelf && leftImage.activeSelf)
        {
            top.SetActive(false);
            right.SetActive(false);
        }

    }
}
