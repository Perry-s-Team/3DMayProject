using UnityEngine;

namespace DefaultNameSpace {

    public class WlalkPlayer : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 40f; // Скорость перемещения персонажа

        private void Update()
        {
            float moveVertical = Input.GetAxis("Horizontal"); // Получаем значение горизонтальной оси (A и D или стрелки влево и вправо)
            float moveHorizontal = -1f; // Устанавливаем значение вертикальной оси на постоянное движение назад

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); // Создаем вектор движения на основе полученных значений осей
            Vector3 newPosition = transform.position + movement * moveSpeed * Time.deltaTime; // Вычисляем новую позицию персонажа

            transform.position = newPosition; // Применяем новую позицию к персонажу
        }
    }
}
