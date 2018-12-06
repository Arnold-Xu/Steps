﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShowIntroduction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public string introduction;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("Introduction").GetComponent<Text>().text = introduction;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject.Find("Introduction").GetComponent<Text>().text = "";
    }
}