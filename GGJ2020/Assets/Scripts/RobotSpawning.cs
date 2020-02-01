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


    public void Spawner()
    {
        //spawnChecker();
        
        if (currentCouple == 0)
        {
            Instantiate(firstCouple);
            firstCouple.SetActive(true);
        }

        if (currentCouple == 1)
        {
            firstCouple.SetActive(false);
            Instantiate(secondCouple);
            secondCouple.SetActive(true);
        }

        if (currentCouple == 2)
        {
            secondCouple.SetActive(false);
            Instantiate(thirdCouple);
        }

        if (currentCouple >= 3)
        {
            thirdCouple.SetActive(false);
            currentCouple = 0;
        }

        //CompletedSession();
        currentCouple++;
    }
}
