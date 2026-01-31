using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _fly;
    [SerializeField] private AudioSource _getPoint;
    [SerializeField] private AudioSource _die;

    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance._birdPlayer._flapped += Fly;
        GameController.Instance._birdPlayer._hitPipe += Die;
        GameController.Instance._birdPlayer._points += GetPoints;
    }

    // Update is called once per frame
    private void Fly()
    {
       _fly.Play(); 
    }

    private void GetPoints()
    {
        _getPoint.Play(); 
 
    }

    private void Die()
    {
        _die.Play(); 
  
    }
}
