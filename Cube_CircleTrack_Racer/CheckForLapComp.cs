using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForLapComp : MonoBehaviour
{
    public bool m1, m2, m3, m4, m5, m6; // markers 
    public GameObject p1, p2; // players 
    public Collider startCol;
    public bool completedLap;
    public int markersComplete = 0; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == p1 && m1 != true && gameObject.name == "Marker1")
        {
            m1 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 1;
            }
        }
        if (other.gameObject == p1 && m2 != true && gameObject.name == "Marker2")
        {
            m2 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 2;
            }
        }
        if (other.gameObject == p1 && m3 != true && gameObject.name == "Marker3")
        {
            m3 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 3;
            }
        }
        if (other.gameObject == p1 && m4 != true && gameObject.name == "Marker4")
        {
            m4 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 4;
            }
        }
        if (other.gameObject == p1 && m5 != true && gameObject.name == "Marker5")
        {
            m5 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 5;
            }
        }
        if (other.gameObject == p1 && m6 != true && gameObject.name == "Marker6")
        {
            m6 = true;
            if (m1 == true || m2 == true || m3 == true || m4 == true || m5 == true || m6 == true)
            {
                markersComplete+= 6;
            }
        }
    }

    private void Update()
    {
        if (m1 == true && m2 == true && m3 == true && m4 == true && m5 == true && m6 == true || markersComplete >= 6)
        {
            completedLap = true;
            if(completedLap == true)
            {
                startCol.enabled = true;
            }
        }
        else if (m1 && m2 && m3 && m4 && m5 && m6 || markersComplete < 6)
        {
            completedLap = false;
            if(completedLap)
            {
                startCol.enabled = false;
            }
            return; 
        }
    }
}