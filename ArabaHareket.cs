using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public float aracHizi, donus;
    public WheelCollider ArkaSagCollider, ArkaSolCollider, OnSagCollider, OnSolCollider;
    public Transform OnSagTekerlek, OnSolTekerlek, ArkaSolTekerlek, ArkaSagTekerlek;


    void Update()
    {


        ArkaSagCollider.motorTorque = Input.GetAxis("Vertical") * -1 * aracHizi;
        ArkaSolCollider.motorTorque = Input.GetAxis("Vertical") * -1 * aracHizi;

        OnSagCollider.steerAngle = Input.GetAxis("Horizontal") * donus;
        OnSolCollider.steerAngle = Input.GetAxis("Horizontal") * donus;

        TekerHareket();

    }

    void TekerHareket()
    {

        Vector3 pozisyon;
        Quaternion aci;

        OnSolCollider.GetWorldPose(out pozisyon, out aci);
        OnSolTekerlek.position = pozisyon;
        OnSolTekerlek.rotation = aci;

        OnSagCollider.GetWorldPose(out pozisyon, out aci);
        OnSagTekerlek.position = pozisyon;
        OnSagTekerlek.rotation = aci;

        ArkaSolCollider.GetWorldPose(out pozisyon, out aci);
        ArkaSolTekerlek.position = pozisyon;
        ArkaSolTekerlek.rotation = aci;

        ArkaSagCollider.GetWorldPose(out pozisyon, out aci);
        ArkaSagTekerlek.position = pozisyon;
        ArkaSagTekerlek.rotation = aci;

    }


}

/*
{
   if (Input.GetKey("w"))
   {
       GetComponent<Rigidbody>().AddForce(50000, 0, 0, ForceMode.Force);

   }

   if (Input.GetKey("d"))
   {
       GetComponent<Rigidbody>().AddForce(0, 0, -50000 , ForceMode.Force);

   }

   if (Input.GetKey("a"))
   {
       GetComponent<Rigidbody>().AddForce(0, 0, 50000, ForceMode.Force);

   }

   if (Input.GetKey("s"))
   {
       GetComponent<Rigidbody>().AddForce(-50000, 0, 0, ForceMode.Force);

   }
}

private void OnCollisionEnter(Collision collision)
{
   if (collision.collider.tag == "Engel")
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}

*/

