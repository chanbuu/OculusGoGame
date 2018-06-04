using UnityEngine;
using System.Collections;

public class CustomOVRInput : MonoBehaviour
{
    [SerializeField]
    private GameObject _camera;

	// Update is called once per frame
	void Update()
	{
        Vector2 pt = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if(pt.x < -0.5f && -0.5f < pt.y && pt.y < 0.5f){
            _camera.transform.position += new Vector3(-0.1f * Time.deltaTime, 0, 0);
        }
        if (pt.x > 0.5 && -0.5 < pt.y && pt.y < 0.5)///右側？
        {
            _camera.transform.position += new Vector3(0.1f * Time.deltaTime, 0, 0);

        }
        if (pt.y < -0.5 && -0.5 < pt.x && pt.x < 0.5)///下側？
        {
            _camera.transform.position += new Vector3(0, 0, -0.1f * Time.deltaTime);

        }
        if (pt.y > 0.5 && -0.5 < pt.x && pt.x < 0.5)///上側？
        {
            _camera.transform.position += new Vector3(0, 0, 0.1f * Time.deltaTime);

        }
	}
}
