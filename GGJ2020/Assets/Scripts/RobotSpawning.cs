using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls which robots come in and which ones go out
public class RobotSpawning : MonoBehaviour
{

    [SerializeField] GameObject firstCouple;
    [SerializeField] GameObject secondCouple;
    [SerializeField] GameObject thirdCouple;

    private bool sessionStarted;
    private bool couple1Finished;
    private bool couple2Finished;
    private bool couple3Finished;

    private int currentCouple = 0;

    // Start is called before the first frame update
    void Start()
    {
        sessionStarted = false;
        couple1Finished = false;
        couple2Finished = false;
        couple3Finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        //spawnChecker();
        //CompletedSession();
    }

    void spawnChecker()
    {
        if (sessionStarted == false)
        {
            if (couple1Finished == false)
            {
                Instantiate(firstCouple);
            }

            if (couple1Finished == true && couple2Finished == false)
            {
                Instantiate(secondCouple);
            }

            if (couple2Finished == true)
            {
                Instantiate(thirdCouple);
            }
            //sessionStarted = true;
        }
    }

    void CompletedSession()
    {
        if (couple1Finished == true)
        {
            firstCouple.SetActive(false);
        }

        if (couple2Finished == true)
        {
            secondCouple.SetActive(false);
        }

        if (couple3Finished == true)
        {
            thirdCouple.SetActive(false);
        }
    }

    public void ButtonTesting()
    {
        spawnChecker();
        
        if (currentCouple == 0)
        {
            couple1Finished = true;
        }

        if (currentCouple == 1)
        {
            couple2Finished = true;
        }

        if (currentCouple == 2)
        {
            couple3Finished = true;
        }

        if (currentCouple >= 4)
        {
            currentCouple = 0;
        }

        //CompletedSession();
        currentCouple++;
    }
}
