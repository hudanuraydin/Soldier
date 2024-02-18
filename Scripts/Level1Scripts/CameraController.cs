using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float hassasiyet = 2.0f; // Fare hassasiyeti
    public float minimumY = -90.0f; // Kameran�n minimum y�n�
    public float maksimumY = 90.0f; // Kameran�n maksimum y�n�

    float rotasyonY = 0.0f; // Y eksenindeki rotasyon miktar�

    void Update()
    {
        float hareketX = Input.GetAxis("Mouse X") * hassasiyet; // X eksenindeki fare hareketi
        float hareketY = Input.GetAxis("Mouse Y") * hassasiyet; // Y eksenindeki fare hareketi

        transform.Rotate(0, hareketX, 0); // Yatay (Y ekseninde) d�n��

        rotasyonY -= hareketY; // Dikey (X ekseninde) d�n��
        rotasyonY = Mathf.Clamp(rotasyonY, minimumY, maksimumY); // D�n�� miktar�n� s�n�rla

        transform.localEulerAngles = new Vector3(rotasyonY, transform.localEulerAngles.y, 0);
    }
}