using System;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private int year;

    public int Year
    {
        get { return year; }
        set 
        {
            if (year < 0)
            {
                throw new ArgumentException("The year can't be less then zero!");
            }

            year = value; 
        }
    }

    public Vehicle(Rigidbody playerRb)
    {
        this.PlayerRb = playerRb;
    }

    public Rigidbody PlayerRb { get; private set; }

    public virtual void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {

    }
}
