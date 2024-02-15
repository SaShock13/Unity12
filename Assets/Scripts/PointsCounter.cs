using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    public int points;

    private void Awake()
    {
        points = 0;
    }
    public void IncreasePoints()
    {
        points++;
    }
}
