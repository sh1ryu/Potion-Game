using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float ControlRange = 0.0f;
    private void Update()
    {
        var newX = Mathf.Lerp(-ControlRange, ControlRange, Input.mousePosition.x / Screen.width);
        transform.position = new Vector3(newX, 0, 0);
    }
}

