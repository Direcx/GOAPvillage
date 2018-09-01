using UnityEngine;
using System.Collections;

public class DoWork : GOAPAction
{

    private bool didWork = false;

    public DoWork()
    {
        addEffect("doWork", true);
    }

    public override void reset()
    {
        didWork = false;
        target = null;
    }

    public override bool isDone()
    {
        return didWork;
    }

    public override bool requiresInRange()
    {
        return true;
    }

    public override bool checkProceduralPrecondition(GameObject agent)
    {
        target = GameObject.Find("Workplace");
        return target != null;
    }

    public override bool perform(GameObject agent)
    {
        return false;
    }
}