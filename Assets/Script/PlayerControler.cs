using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // deklarasi tingkat sensitivitas mouse
    public float mouseSensitivity = 100f;
    // deklarasi kecepatan player
    public float speed = 12f;
    // deklarasi gravity
    public float gravity = -9.81f;


    // deklarasi GroundCheck Component
    public float groundDistance = 0.4f;
    public Transform groundCheck;
    public LayerMask Envirotment;
    bool isGround;

    // deklarasi ketinggian Loncat
    public float tinggiLoncat = 3f;


    // deklarasi komponen body, agar script dapat mengambil game object player pada unity
    public Transform body;

    // deklarasi xrotation untuk menyimpan nilai saat player ingin melihat ke atas dan kebawah
    float xRotation = 0f;

    // deklarasi komponen chacartercontroler
    public CharacterController player;

    // deklarasi velocity untuk menyimpan nilai ketinggian;
    Vector3 velocity;

    void Start()
    {
        // mengunci posisi kursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, Envirotment);
        if(isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        CameraMovement();
        PlayerMovement();

    }


    void CameraMovement()
    {
        //Mengambil komponen X dan Y axis dari mouse dan Mengkalikan dengan tingkat sensitivitas
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // menyimpan nilai dari mouseY, dan membuat nya tidak kebalik dengan memberi nilai (-)
        xRotation -= mouseY;
        // membatasi pergerakan dari melihat keatas dan kebawah
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        // membuat player berputar pada sumbu X, dengan kecepatan mouseY, agara dapat melihat ke atas dan bawah
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // membuat player berputar pada sumbu Y, dengan kecepatan mouse X, agara dapat melihat ke kiri dan kanan
        body.Rotate(Vector3.up * mouseX);
    }

    void PlayerMovement()
    {

        // mengambil value dari input horizontal dan di simpan pada dirX, vertical di simpan pada dirZ
        float dirX = Input.GetAxis("Horizontal");
        float dirZ = Input.GetAxis("Vertical");

        // membuat kalkulasi untuk bergerak ketika terdapat sebuah input
        Vector3 gerak = transform.right * dirX + transform.forward * dirZ;

        // menggerakan player sesuai dengan input dan kecepatan
        player.Move(gerak*speed*Time.deltaTime);

        // mengecek ketinggian 
        velocity.y += gravity * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);

        // fungsi untuk loncat
        if (Input.GetButtonDown("Jump")&& isGround)
        {
            velocity.y = Mathf.Sqrt(tinggiLoncat * -2f * gravity);
        }
    }
}
