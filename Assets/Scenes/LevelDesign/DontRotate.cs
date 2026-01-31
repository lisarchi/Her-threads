using UnityEngine;

public class FollowParentPosition : MonoBehaviour
{
    [SerializeField] private Transform parent; // Ссылка на родителя
    private Vector3 offset; // Смещение относительно родителя

    // Фиксированное вращение, которое будет у объекта
    [SerializeField] private Quaternion fixedRotation;


    void Start()
    {
        if (parent == null)
            parent = transform.parent;

        // Сохраняем начальное смещение
        offset = transform.position - parent.position;
        fixedRotation = transform.rotation;

        // Запоминаем начальное вращение (если нужно сохранить текущее)
        // fixedRotation = transform.rotation;
    }

    void LateUpdate()
    {
        // Обновляем только позицию
        transform.position = parent.position + offset;

        // Принудительно устанавливаем фиксированное вращение
        transform.rotation = fixedRotation;
    }
}