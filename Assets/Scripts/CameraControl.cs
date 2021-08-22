using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform bg1;
    public Transform bg2;

  
    public Transform target;
    private float cameraOffsetY = 3;

    private float size;
    private Vector3 cameraTargetPos = new Vector3();
    private Vector3 bg1TargetPos = new Vector3();

    // Start is called before the first frame update
    void Start() 
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 targetPos = SetPos(cameraTargetPos, target.position.x, target.position.y + cameraOffsetY, -1);
        Vector3 targetPos = SetPos(cameraTargetPos, Camera.main.transform.position.x, target.position.y + cameraOffsetY, -1);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

        if (transform.position.y >= bg2.position.y)
        {
            bg1.position = SetPos(bg1TargetPos, bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwitchBg();
        }
    }

    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }

    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }
}
