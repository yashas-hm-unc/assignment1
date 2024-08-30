using UnityEngine;
using UnityEngine.InputSystem;

public class ShootScript : MonoBehaviour
{
    public DartScript dartScript;
    private DartScript _dart;
    void Update()
    {
        // For desktop ease of access
        // if (Keyboard.current.spaceKey.IsPressed())
        if(Touchscreen.current.press.IsPressed())
        {
            if (_dart == null)
            {
                _dart = Instantiate(dartScript);
                _dart.transform.localPosition = transform.position;
                _dart.transform.Rotate(Vector3.forward * (Time.deltaTime * 20));
                if (Camera.main != null)
                {
                    _dart.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(1200, 2000));
                    _dart.transform.rotation = Quaternion.Euler(Random.Range(-90,90), 0, 0);
                }
                
            }
        }
    }
}