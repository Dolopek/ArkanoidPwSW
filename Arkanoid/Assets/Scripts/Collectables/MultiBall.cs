using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MultiBall : Collectable
{
    protected override void ApplyEffect()
    {
        foreach (Ball Ball in BallsManager.Instance.Balls.ToList())
        {
            BallsManager.Instance.SpawnBalls(Ball.gameObject.transform.position, 2);
        }
    }
}
