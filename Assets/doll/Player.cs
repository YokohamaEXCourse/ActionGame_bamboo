using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private int InputF;
    public TextMeshProUGUI InputFText;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject obj15;
    public int Savepoint;//セーブポイントの変数

    [SerializeField]
    public GameObject Savepoint0;

    [SerializeField]
    public GameObject Savepoint1;

    [SerializeField]
    public GameObject Savepoint2;

    [SerializeField]
    public GameObject Savepoint3;

    [SerializeField]
    public GameObject Savepoint4;

    // private PlayerStatus SP1;

    private Rigidbody rb;
    [SerializeField]
    private float jumpPower = 2000;

    [SerializeField]
    private float moveSpeed = 15;

    private Animator anim;

    private bool grounded=true;

    private bool NPC;

    private bool camera=false;

    private bool camera2=false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward*moveSpeed*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.TransformDirection(Vector3.forward*moveSpeed*Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
         if(camera2==false && camera==false)
         {
            camera2=true;
            camera=true;
         }

         if(camera2==false && camera==true)
         {
            camera2=true;
            camera=false;
         }
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
         camera2=false;
        }

        if(Input.GetKey(KeyCode.S))
        {
             transform.position -= transform.TransformDirection(Vector3.back*moveSpeed*Time.deltaTime);
        

        if(camera==false)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }

        if(camera==true)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        } 
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.TransformDirection(Vector3.back*moveSpeed*Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,-1,0));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0,-2,0));
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,2,0));
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0,2,0));
        }

        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Running",true);
        }

        else
        {
            anim.SetBool("Running",false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(grounded == true)
            {
                rb.AddForce(Vector3.up*jumpPower);
                grounded = false;
            }
        }
        
        void OnTriggerEnter(Collider col)
        {
            if(col.gameObject.tag =="NPC");
        }

        if(Input.GetKey(KeyCode.Alpha1) && Savepoint==1)//セーブ
        {
            this.transform.position=Savepoint0.transform.position;
            grounded = true;
            obj3.SetActive(false);
        }

        if(Input.GetKey(KeyCode.Alpha2)&& Savepoint==2)
        {
            this.transform.position=Savepoint1.transform.position;
            grounded = true;
            obj4.SetActive(false);
        }

        if(Input.GetKey(KeyCode.Alpha3)&& Savepoint==3)
        {
            this.transform.position=Savepoint2.transform.position;
            grounded = true;
            obj5.SetActive(false);
        }

        if(Input.GetKey(KeyCode.Alpha4)&& Savepoint==4)
        {
            this.transform.position=Savepoint3.transform.position;
            grounded = true;
            obj6.SetActive(false);
        }

        if(Input.GetKey(KeyCode.Alpha5)&& Savepoint==5)
        {
            this.transform.position=Savepoint4.transform.position;
            grounded = true;
            obj7.SetActive(false);
        }

        if(Savepoint==1&&this.transform.position.y<15)
        {
            obj3.SetActive(true);
        }

        if(Savepoint==2&&this.transform.position.y<26)
        {
            obj4.SetActive(true);
        }

        if(Savepoint==3&&this.transform.position.y<35)
        {
            obj5.SetActive(true);
        }

        if(Savepoint==4&&this.transform.position.y<45)
        {
            obj6.SetActive(true);
        }

        if(Savepoint==5&&this.transform.position.y<81)
        {
            obj7.SetActive(true);
        }
    }  


      private void OnCollisionEnter(Collision collision)//当たったとき
    {
        if(collision.gameObject.tag == "Ground"||collision.gameObject.tag == "floor")
        {
        grounded = true;
        }

        if(collision.gameObject.tag == "MoveFloor"||collision.gameObject.tag == "floor")
        {
            grounded = true;
            transform.SetParent(collision.transform);
            Debug.Log("MoveFloor");
        }

         if (collision.gameObject.tag == "floor")
        {
            obj.SetActive(true);
             jumpPower = 1200;
        } 

        if(collision.gameObject.tag == "Savepoint")//セーブ
        {
            Savepoint=1;
            grounded = true;
        }

        if(collision.gameObject.tag == "Savepoint1")
        {
            Savepoint=2;
            grounded = true;
        }

        if(collision.gameObject.tag == "Savepoint2")
        {
            Savepoint=3;
            grounded = true;
        }

         if(collision.gameObject.tag == "Savepoint3")
        {
            Savepoint=4;
            grounded = true;
        }

         if(collision.gameObject.tag == "Savepoint4")
        {
            Savepoint=5;
            grounded = true;
            jumpPower = 1200;
            obj8.SetActive(true);
            obj9.SetActive(true);
            obj10.SetActive(true);
            obj11.SetActive(true);
            obj12.SetActive(true);
            obj13.SetActive(true);
            obj14.SetActive(true);
            obj15.SetActive(true);
        }

        if (collision.gameObject.tag == "Highjumpfloor")
        {
            jumpPower = 2000; 
            grounded = true;
        } 

        
    }    


      private void OnCollisionExit(Collision collision)//離れたとき
    {
    if(collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }

    if(collision.gameObject.tag == "MoveFloor")
        {
            grounded = false;
            transform.SetParent(null);
        }

    if (collision.gameObject.tag == "floor")
        {
            obj.SetActive(false);
            obj2.SetActive(false);
        }
    }

    private void OnCollisionStay(Collision collision)//当たり続けているとき
    {
        if(collision.gameObject.tag == "MoveFloor"||collision.gameObject.tag == "floor")
        {
            grounded = true;
        }

        if(collision.gameObject.tag == "Ground"||collision.gameObject.tag == "floor")
        {
            grounded = true;
        }

    }



    }