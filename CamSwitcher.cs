using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitcher : MonoBehaviour
{
   public Transform Player;
   public CinemachineVirtualCamera activeCam;

   private void OnTriggerEnter(Collider other)
   {
      if(other.CompareTag("Player"))
      {
        activeCam.Priority = 1;
        Debug.Log("camera 1 active");
      }
   }

   private void OnTriggerExit(Collider other)
   {
      if(other.CompareTag("Player"))
      {
        activeCam.Priority = 0;
        Debug.Log("camera 1 desactived");
      }
   }

}
