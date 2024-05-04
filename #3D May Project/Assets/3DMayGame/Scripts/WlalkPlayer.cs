using UnityEngine;

namespace DefaultNameSpace
{

    [RequireComponent(typeof(Rigidbody))]
    public class WlalkPlayer : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 80f; // Скорость перемещения персонажа

        private void Update()
        {
            float moveVertical = Input.GetAxis("Horizontal"); // Получаем значение горизонтальной оси (A и D или стрелки влево и вправо)
            float moveHorizontal = -1f; // Устанавливаем значение вертикальной оси на постоянное движение назад

            Vector3 vector31 = new(moveHorizontal, 0f, moveVertical);
            Vector3 vector3 = vector31;
            Vector3 movement = vector3; // Создаем вектор движения на основе полученных значений осей
            Vector3 newPosition = transform.position + moveSpeed * Time.deltaTime * movement; // Вычисляем новую позицию персонажа

            transform.position = newPosition; // Применяем новую позицию к персонажу
        }

        //[SerializeField] private float moveSpeed = 40f; // Скорость перемещения персонажа
        //[SerializeField] private GameObject objectA;
        //[SerializeField] private GameObject objectB;
        //[SerializeField] private GameObject objectC;
        //private void FixedUpdate()
        //{
        //    float moveVertical = Input.GetAxis("Horizontal"); // Устанавливаем значение вертикальной оси на постоянное движение назад
        //    float moveHorizontal = -1; // Получаем значение горизонтальной оси (A и D или стрелки влево и вправо)

        //    Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // Создаем вектор движения на основе полученных значений осей
        //    Vector3 newPosition = transform.position + movement * moveSpeed * Time.deltaTime; // Вычисляем новую позицию персонажа

        //    transform.position = newPosition; // Применяем новую позицию к персонажу
        //}

        //public void OnCollisionEnter(Collision collision)
        //{
        //    objectA = collision.gameObject; // Получаем первый объект столкновения
        //    objectB = collision.gameObject; // Получаем первый объект столкновения
        //    objectC = this.gameObject;
        //    Debug.Log("Столкновение между " + objectA.name + " и " + objectB.name);
        //}

    }
}
