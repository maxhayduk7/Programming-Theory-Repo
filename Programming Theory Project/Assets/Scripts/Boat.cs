using UnityEngine;

public class Boat : Vehicle
{
    public Boat(Rigidbody playerRb) : base(playerRb)
    {
    }

    public override void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {
        PlayerRb.AddRelativeForce(speed * verticalInput * Vector3.forward);

        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
