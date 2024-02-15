using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPoints : MonoBehaviour
{
    TMP_Text text;
    [SerializeField] PointsCounter pointsCounter;

    private void Awake()
    {
       text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text.text = pointsCounter.points.ToString();
    }
}
