using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerBirdRigidbody;
    [SerializeField] private Transform _playerBirdTransform;
    [SerializeField] private int _jumpHight = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _playerBirdRigidbody.AddForce(transform.up * _jumpHight, ForceMode2D.Impulse);
        }


    }
}
