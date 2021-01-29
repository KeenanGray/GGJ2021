using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Keenan_XR
{
    public class XR_Movement : MonoBehaviour
    {

        Camera camera;

        [SerializeField]
        [Range(0.0f, 1.0f)]
        float speed = 1;

        // Start is called before the first frame update
        void Start()
        {
            camera = GetComponentInChildren<Camera>();
            XR_Input.leftJoyAxisDelegate += movePlayer;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void movePlayer(Vector2 input)
        {
            print(input.x + ", " + input.y);
            transform.Translate(camera.transform.forward * input.y * speed);
            transform.Translate(camera.transform.right * input.x * speed);
        }
    }
}