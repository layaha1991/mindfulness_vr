using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnimationScript : MonoBehaviour
{
    public void checkHeart0Rot()
    {
        flowManager.Instance.isHeart0InEffectDone = true;
    }

    public void checkFirework1Done()
    {
        flowManager.Instance.isfirework1Done = true;
    }
    public void checkFirework2Done()
    {
        flowManager.Instance.isfirework2Done = true;
    }

    public void checkHeart1In()
    {
        flowManager.Instance.isHeart1InEffectDone = true;
    }
    public void checkHeart2In()
    {
        flowManager.Instance.isHeart2InEffectDone = true;
    }

    public void checkHeart12SpawnDone()
    {
        flowManager.Instance.isHeart12DoneSpawn = true;
    }



}
