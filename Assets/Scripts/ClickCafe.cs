﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickCafe : MonoBehaviour
{
    public GameObject cafePanel;
    public Button cafeCloseButton;
    public GameObject clickBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (!EventSystem.current.IsPointerOverGameObject() && hit.transform.gameObject == clickBox)
                {
                    cafePanel.gameObject.SetActive(true);
                    cafeCloseButton.gameObject.SetActive(true);
                }
            }
        }
    }
}
