using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageandColorChange : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Image>().color = Dataclass.Clr;
    }
}
