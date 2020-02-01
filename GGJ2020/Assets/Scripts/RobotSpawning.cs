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

    // Start is called before the first frame update
    void Start()
    {
        bool sessionStarted = false;
        bool couple1Finished = false;
        bool couple2Finished = false;
        bool couple3Finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        spawnChecker();

    }

    void spawnChecker()
    {
        if (sessionStarted == false)
        {
            //Run the "if x has gone"
            if (couple1Finished == false)
            {
                sessionStarted = true;
                Instantiate(firstCouple);
            }

            if (couple1Finished == true && couple2Finished == false)
            {
                sessionStarted = true;
                Instantiate(secondCouple);
            }

            if (couple2Finished == true)
            {
                sessionStarted = true;
                Instantiate(thirdCouple);
            }
        }
    }

    void CompletedSession()
    {
        
    }

    public void ButtonTesting()
    {

    }
}
