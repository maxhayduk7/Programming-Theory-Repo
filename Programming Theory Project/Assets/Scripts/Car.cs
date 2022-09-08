using UnityEngine;

public class Car : Vehicle
{
    public Car(Rigidbody playerRb) : base(playerRb)
    {
    }

    public override void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {
        MoveForward(speed, verticalInput);

        Turn(turnSpeed, horizontalInput);
    }

    private void MoveForward(int speed, float verticalInput)
    {
        PlayerRb.AddRelativeForce(speed * verticalInput * Vector3.forward);
    }

    private void Turn(float turnSpeed, float horizontalInput)
    {
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
