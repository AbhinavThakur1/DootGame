using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangersideoff : MonoBehaviour
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
        if (!topImage.activeSelf && !leftImage.activeSelf && !rightImage.activeSelf && !bottomImage.activeSelf)
        {
            foreach (GameObject i in tobeon)
            {
                i.SetActive(true);
            }
        }
        else if (topImage.activeSelf)
        {
            left.SetActive(false);
            right.SetActive(false);
            bottom.SetActive(false);
        }
        else if (leftImage.activeSelf)
        {
            top.SetActive(false);
            right.SetActive(false);
            bottom.SetActive(false);
        }
        else if (rightImage.activeSelf)
        {
            left.SetActive(false);
            top.SetActive(false);
            bottom.SetActive(false);
        }
        else if (bottomImage.activeSelf)
        {
            left.SetActive(false);
            right.SetActive(false);
            top.SetActive(false);
        }
    }
}
