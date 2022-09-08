using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public Vehicle(Rigidbody playerRb)
    {
        this.PlayerRb = playerRb;
    }

    public Rigidbody PlayerRb { get; private set; }

    public virtual void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {

    }
}
