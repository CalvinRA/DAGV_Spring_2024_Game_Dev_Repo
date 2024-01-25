using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class BegginerTextLabelBehavoir : MonoBehaviour
{
    public Text lable;
    public BegginerFloatData dataObj;

    public void Start()
    {
        lable = GetComponent<Text>();
        UpdateLable();
    }

    public void UpdateLable()
    {
        lable.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
