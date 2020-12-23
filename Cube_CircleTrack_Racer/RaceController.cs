using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceController : MonoBehaviour
{
    public bool raceStarted;
    public bool isP1Lead;
    public bool isP2Lead;
    public bool isWrongWay;
    public Vector3 startPos; 
    public Vector3 p1Pos;
    public Vector3 p2Pos;
    public Transform startTransform; 
    public Transform p1Transform;
    public Transform p2Transform;
    public int laps;
    [SerializeField] CheckForLapComp[] clp; 

    private void Start()
    {
        laps = 10; 
    }

    private void Update()
    {
        Vector3 toPos = (p2Transform.position - p1Transform.position).normalized;
        if(Vector3.Dot(toPos, transform.forward) > 0)
        {
            isP2Lead = true;
            isP1Lead = false; 
        }
        else
        {
            isP1Lead = true;
            isP2Lead = false; 
        }

        Vector3 forwardDir = (p1Transform.position - p2Transform.position).normalized;
        if(Vector3.Dot(forwardDir, startTransform.transform.forward) < 0)
        {
            isWrongWay = true;
        }
        else
        {
            isWrongWay = false; 
        }

        if(clp[0].completedLap == true && clp[1].completedLap == true && clp[2].completedLap == true &&
            clp[3].completedLap == true && clp[4].completedLap == true && clp[6].completedLap == true)
        {
            laps += 1;
            return; 
        }
    }
}