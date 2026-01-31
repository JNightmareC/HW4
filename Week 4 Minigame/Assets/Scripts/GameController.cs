using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _spawn;
    [SerializeField] private GameObject _pipes;
    private float _timer = 4;
    private float _timeTill;
    public List<GameObject> _pipeClones = new List<GameObject>();
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

    void Start()
    {
        Instance._birdPlayer._hitPipe += DeletePipes;

    }



    public void SpawnPipes()
    {
        var _pipeLocation = new Vector3(_spawn.transform.position.x, Random.Range(-4f, 4f), 0);
        _pipes = Instantiate(_pipes, _pipeLocation, Quaternion.identity);
        _timer = 3;
        _pipeClones.Add(_pipes);

        Destroy(_pipes, 6);
        

    }

    public void DeletePipes()
    {
        foreach (GameObject _pipe in _pipeClones)
        {
            if(_pipes != null)
            {
                Destroy(_pipes);   
            }
            
        }
    }


    void Update()
    {
        _timeTill = Time.deltaTime;
        _timer -= _timeTill;
        if(_timer <= 0 && _birdPlayer._canPlay == true)
        {
            SpawnPipes();
        }
    }
}
