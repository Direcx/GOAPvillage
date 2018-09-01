using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blopp : MonoBehaviour, IGOAP {

    public Workplace workplace;
    public int test;

	// Use this for initialization
	void Start () {
        test = 0;
	}
	

    public HashSet<KeyValuePair<string, object>> getWorldState()
    {
        HashSet<KeyValuePair<string, object>> worldData = new HashSet<KeyValuePair<string, object>>();
        worldData.Add(new KeyValuePair<string, object>("doWork", false));
        return worldData;
    }

    public HashSet<KeyValuePair<string, object>> createGoalState()
    {
        HashSet<KeyValuePair<string, object>> goal = new HashSet<KeyValuePair<string, object>>();
        goal.Add(new KeyValuePair<string, object>("doWork", true));
        return goal;
    }

    public void planFailed(HashSet<KeyValuePair<string, object>> failedGoal)
    {

    }

    public void planFound(HashSet<KeyValuePair<string, object>> goal, Queue<GOAPAction> action)
    {

    }

    public void actionsFinished()
    {

    }

    public void planAborted(GOAPAction aborter)
    {

    }

    public virtual bool moveAgent(GOAPAction nextAction)
    {
        Vector3 moveDirection = workplace.transform.position - transform.position;

        Vector3 newPosition = moveDirection * Time.deltaTime * 0.3f;

        transform.position += newPosition;
        float dist = Vector3.Distance(transform.position, nextAction.target.transform.position);
        test++;
        /*
		if (dist < aggroDist) {
			//Vector3 moveDirection = player.transform.position - transform.position;

			setSpeed (speed);

			if (initialSpeed < terminalSpeed) {
				initialSpeed += acceleration;
			}

			//Vector3 newPosition = moveDirection * initialSpeed * Time.deltaTime;
			//transform.position += newPosition;
		}*/
		if(dist <= 1.5f) {
			nextAction.setInRange(true);
			return true;
		} else {
			return false;
		}

    }
}
