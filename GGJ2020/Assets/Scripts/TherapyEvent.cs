using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TherapyEvent : MonoBehaviour
{
    public bool therapyEvent;
    public float therapyTimer;
    //score for the couple
    public int coupleScore;
    //for calculating points seperately to couple score
    public int points;

    //max combination of points is 5
    private int majorPoints = 3;
    private int minorPoints = 2;
    private int noPoints = 0;
    private int timeBracketA = 2;
    private int timeBracketB = 1;
    private int timeBracketC = 0;

    public float timerA;
    public float timerB;
    public float timerC;

    public int majorOrMinor;

    

    //ticks up timer while event is going
    public void Update()
    {
        if(therapyEvent == true)
        {
            therapyTimer += Time.deltaTime;
        }
    }

    //series of functions to be called by fungus to update the solution
    public void Major()
    {
        majorOrMinor = 1;
    }

    public void Minor()
    {
        majorOrMinor = 2;
    }

    public void Fail()
    {
        majorOrMinor = 3;
    }


    //function to be called in fungus while therapy is in session
    public void TherapyStart()
    {
        therapyEvent = true;
    }

    //function to be called in fungus when therapy session is over
    public void TherapyEnd()
    {
        //checks which point brackets the player is in for their session, fungus will update the majororminor to the value it needs to be
        if(therapyTimer <= timerA)
        {
            points += timeBracketA;
        }

        if (therapyTimer <= timerB)
        {
            points += timeBracketB;
        }

        if (therapyTimer <= timerC)
        {
            points += timeBracketC;
        }

        if(majorOrMinor == 1)
        {
            points += majorPoints;
        }

        if(majorOrMinor == 2)
        {
            points += minorPoints;
        }

        if(majorOrMinor == 3)
        {
            points += noPoints;
        }

        //stores the score, resets the points, stops the timer and resets the timer
        coupleScore = points;
        points = 0;
        therapyEvent = false;
        therapyTimer = 0;

    }
}
