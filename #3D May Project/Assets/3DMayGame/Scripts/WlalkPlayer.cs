using UnityEngine;
using UnityEngine.UI;

namespace DefaultNameSpace
{

    [RequireComponent(typeof(Rigidbody))]
    public class WlalkPlayer : MonoBehaviour
    {
        [SerializeField] private float speed = 80f;
        [SerializeField] private int coins;
        [SerializeField] private Text ammoText;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Coin")
            {
                coins += 10;
                ammoText.text = coins.ToString();
                Destroy(other.gameObject);
            }

            
        }

        void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.S))
        {
            verticalInput = 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = 1f;
        }

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement, Space.Self);
    }
    }
}
