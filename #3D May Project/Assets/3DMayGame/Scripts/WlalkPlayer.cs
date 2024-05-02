using UnityEngine;

namespace DefaultNameSpace {
    public class WlalkPlayer : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _rb.velocity = moveInput * speed;
        }
    }
}
