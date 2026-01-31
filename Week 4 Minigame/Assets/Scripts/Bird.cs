using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerBirdRigidbody;
    [SerializeField] private Transform _playerBirdTransform;
    [SerializeField] private int _jumpHight = 10;
    public bool _canPlay;
    
    public delegate void FlapDelegate ();
    public event FlapDelegate _flapped;
    public delegate void Pointdelegate ();

    public event Pointdelegate _points;
    public delegate void HitDelegate ();
    public event HitDelegate _hitPipe;

    // Start is called before the first frame update
    void Start()
    {
        _canPlay = true;
        GetComponent<Bird>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        FlapWings();


    }
    public void FlapWings()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            _playerBirdRigidbody.AddForce(transform.up * _jumpHight, ForceMode2D.Impulse);
            _flapped?.Invoke();
        } 
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            _canPlay = false;
            GetComponent<Bird>().enabled = false;
            _hitPipe?.Invoke();
        }
        if(collision.gameObject.tag == "Point Collider")
        {
            _gotPoint();
            
            
        }
    }


    public void _gotPoint()
    {
       _points?.Invoke(); 
    }
}
