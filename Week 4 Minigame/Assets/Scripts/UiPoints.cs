using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _PointsGainedText;
    private int _startPoints;

    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance._birdPlayer._points += PointsGained;
        _startPoints = 0;
        _PointsGainedText.text = _startPoints.ToString();
    }

    public void PointsGained()
    {
        Debug.Log("am in points thing");
        _startPoints += 1;
        _PointsGainedText.text = _startPoints.ToString();
    }
    

    
}
