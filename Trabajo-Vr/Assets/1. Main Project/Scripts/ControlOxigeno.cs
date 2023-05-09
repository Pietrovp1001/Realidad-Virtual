using UnityEngine;

public class ControlOxigeno : MonoBehaviour
{
    public void SetOxigenValue(float value) {
        transform.rotation *= Quaternion.Euler(new Vector3(0, 0, value));
    }
}
