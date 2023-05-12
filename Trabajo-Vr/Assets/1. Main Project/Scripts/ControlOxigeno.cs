using UnityEngine;

public class ControlOxigeno : MonoBehaviour
{
    [SerializeField] private float gasLevel;
    ControlPuertaGases controlPuertaGases;

    void Start() {
        controlPuertaGases = GameObject.FindGameObjectWithTag("Oxigeno").GetComponent<ControlPuertaGases>();
    }

    public void SetOxigenValue(float value) {
        transform.rotation *= Quaternion.Euler(new Vector3(0, 0, value));
        if (gasLevel == value) {
            controlPuertaGases.completedGas++;
            Debug.Log(controlPuertaGases.completedGas);
        }
    }
}
