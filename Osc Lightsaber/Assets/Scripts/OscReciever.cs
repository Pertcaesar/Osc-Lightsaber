
using OSCJack;

public class AccelerometerControl : MonoBehaviour
{
    // Define the IP and Port of your OSC server (Unity)
    public string ipAddress = "192.168.1.99";
    public int port = 7248;

    // The object you want to rotate
    public Transform objectToRotate;

    // OSC message address for accelerometer data
    private string oscAddress = "/accelerometer";

    void Start()                                                            
    {
        // Initialize OSC receiver
        OSCReceiver receiver = OSCReceiver.Create(ipAddress, port);
        receiver.Map(oscAddress, OnAccelerometerDataReceived);
    }

    void OnAccelerometerDataReceived(OSCMessage message)
    {
        // Assuming the accelerometer data is sent as three floats (x, y, z)
        float accelX = message.GetFloat(0);
        float accelY = message.GetFloat(1);
        float accelZ = message.GetFloat(2);

        // Apply accelerometer data to the object’s rotation
        // You might want to adjust the multipliers depending on how sensitive you want the rotation to be
        objectToRotate.rotation = Quaternion.Euler(accelX * 90f, accelY * 90f, accelZ * 90f);
    }
}

