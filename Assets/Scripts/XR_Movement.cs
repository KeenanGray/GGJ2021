using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Keenan_XR
{
    public class XR_Movement : MonoBehaviour
    {

        [SerializeField]
        [Range(0, 10)]
        float speed = 1;

        // Start is called before the first frame update
        void Start()
        {
            XR_Input.leftJoyAxisDelegate += movePlayer;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void movePlayer(Vector2 input)
        {
            print(input.x + ", " + input.y);
            transform.Translate(transform.forward * input.x * speed);
            transform.Translate(-transform.right * input.y * speed);
        }
    }

}