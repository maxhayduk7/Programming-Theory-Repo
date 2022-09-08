using UnityEngine;

public class Car : Vehicle
{
    public Car(Rigidbody playerRb) : base(playerRb)
    {
    }

    public override void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {
        PlayerRb.AddRelativeForce(Vector3.forward * speed * verticalInput);

        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
