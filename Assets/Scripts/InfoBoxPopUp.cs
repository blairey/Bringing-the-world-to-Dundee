using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class InfoBoxPopUp : MonoBehaviour
{
    public float gazeTimer = 2f;

    private float timer;

    private bool gazeAtObj;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(gazeAtObj == true)
        {
            timer += Time.deltaTime;
            
            if(timer >-gazeTimer)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }

    }

    public void PointerEnter()
    {
        gazeAtObj = true;
    }
 
    public void PointerExit()
    {
        gazeAtObj = false;
    }

    public void PointerDown()
    {
        Debug.Log(" down ");
    }

}

