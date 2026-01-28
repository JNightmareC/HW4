using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _spawn;
    [SerializeField] private GameObject _pipes;
    public static GameController Instance {get; private set;}
    public Bird _birdPlayer {get; private set;}
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        GameObject playerObject = GameObject.FindWithTag("Player");
        _birdPlayer = playerObject.GetComponent<Bird>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
