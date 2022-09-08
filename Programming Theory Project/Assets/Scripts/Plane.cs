using UnityEngine;

public class Plane : Vehicle
{
    public Plane(Rigidbody playerRb) : base(playerRb)
    {
    }

    public override void Move(int speed, float turnSpeed, float verticalInput, float horizontalInput)
    {
        MoveForward(speed);

        Tilt(turnSpeed, verticalInput);
    }

    private void MoveForward(int speed)
    {
        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    private void Tilt(float turnSpeed, float verticalInput)
    {
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, verticalInput * turnSpeed * Time.deltaTime);
    }
}
