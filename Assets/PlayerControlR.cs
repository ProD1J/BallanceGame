using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlR : MonoBehaviour
{
    public GameObject PlayerVector; //����� �������� ������� ��� ��������� ����������� ��������
    public GameObject Player; //������ �����
    public GameObject Terrain; //��������
    public float speed; //�������� �����������

    public static bool _gameover; //������� ���������

    private Rigidbody rbPlayer;
    private Collider colPlayer;
    private Material matPlayer;
    private bool grounded;
    private byte matState = 1;
    void Start()
    {
        matState = 1;
        grounded = true;
        rbPlayer = Player.GetComponent<Rigidbody>();
        colPlayer = Player.GetComponent<Collider>();
        _gameover = false;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "MaterialSwitch" && matState != 0)
        {
            matState = 0;
            rbPlayer.mass = 0.5F;
            Debug.Log("Switch to lighter");
        }
        else if (collider.gameObject.name == "MaterialSwitchHeavier" && matState != 2)
        {
            matState = 2;
            rbPlayer.mass = 1.5F;
            Debug.Log("Switch to heavier");
        }
        else if (collider.gameObject.name == "MaterialSwitchDeafault" && matState != 1)
        {
            rbPlayer.mass = 1;
            matState = 1;
            Debug.Log("Switch to def");
        }
    }
    void Update()
    {
        //������/�����
        if (Player.transform.position.y < 0)
        {
            Debug.Log("Loh");
            _gameover = true;
            Player.transform.position = new Vector3(0, 40, 0);
        }
        else
        {
            _gameover = false;
        }
        //��������� ������ �� �������
        if (Input.GetKey(KeyCode.W) & _gameover == false)
        {
            if (grounded == true)
            {
                rbPlayer.AddForce((PlayerVector.transform.forward + PlayerVector.transform.up) * speed * Time.deltaTime);
            }
            else
            {
                rbPlayer.AddForce(0f, 0f, 0f);
            }
        }
        //�������� ����� �� �������
        if (Input.GetKey(KeyCode.S) & _gameover == false)
        {
            if (grounded == true)
            {
                rbPlayer.AddForce(-PlayerVector.transform.forward * speed * Time.deltaTime);
            }
            else
            {
                rbPlayer.AddForce(0f, 0f, 0f);
            }
        }
        //�������� ������ �� �������
        if (Input.GetKey(KeyCode.D) & _gameover == false)
        {
            if (grounded == true)
            {
                rbPlayer.AddForce(PlayerVector.transform.right * speed * Time.deltaTime);
            }
            else
            {
                rbPlayer.AddForce(0f, 0f, 0f);
            }
        }
        //�������� ����� �� �������
        if (Input.GetKey(KeyCode.A) & _gameover == false)
        {
            if (grounded == true)
            {
                rbPlayer.AddForce(-PlayerVector.transform.right * speed * Time.deltaTime);
            }
            else
            {
                rbPlayer.AddForce(0f, 0f, 0f);
            }
        }
    }
}
