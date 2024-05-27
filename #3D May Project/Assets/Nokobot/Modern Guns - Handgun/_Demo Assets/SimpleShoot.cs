using UnityEngine;
using UnityEngine.UI;

public class SimpleShoot : ClosestShoot
{

    [Header("Location Refrences")]
    [SerializeField] private Animator gunAnimator;
    [SerializeField] private GameObject shootCel;

    void Start()
    {
        if (gunAnimator == null)
            gunAnimator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            gunAnimator.SetTrigger("Fire");
        }

        if (Input.GetMouseButtonDown(0))
        {
            shootCel.SetActive(true);
        }
    }
}
