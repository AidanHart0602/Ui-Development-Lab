using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _instantiatePoint;
    [SerializeField] private int _rotationLimit = 0;
    public void Shoot() 
    {
        GameObject CannonBall = Instantiate(_bullet, _instantiatePoint.position, _instantiatePoint.rotation);

        CannonBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(-2000, 0, 0));
    }

    public void RotateLeft()
    {
        if(_rotationLimit > -90)
        {
            transform.Rotate(0, -15, 0);
            _rotationLimit -= 15;
        } 
    }

    public void RotateRight()
    {
        if(_rotationLimit < 90)
        {
            transform.Rotate(0, 15, 0);
            _rotationLimit += 15;
        }
    }
}
