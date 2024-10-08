using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class FollowThePath : MonoBehaviour {


    [SerializeField]
    private RectTransform[] waypoints;
    private int currentWaypointIndex = 0;
    public void Move(int diceSide)
    {
             
        if (currentWaypointIndex + (diceSide ) < waypoints.Length)
        {
            //if (currentWaypointIndex == 0)
            //{
            //    currentWaypointIndex += diceSide - 1;
            //}


            currentWaypointIndex += diceSide;
            
            gameObject.GetComponent<RectTransform>().anchoredPosition = waypoints[currentWaypointIndex].anchoredPosition;
            
                
        }   
        else
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = waypoints[waypoints.Length - 1].anchoredPosition;
        }
        
    }  
}



//public void MoverPeca(int dado)
//{
//    // Verificar se a peça não ultrapassou o final do tabuleiro
//    if (currentWaypointIndex + dado < waypoints.Length)
//    {
//        // Atualizar o índice para o próximo waypoint
//        currentWaypointIndex += dado;

//        // Mover a peça para o próximo waypoint
//        gameObject.GetComponent<RectTransform>().anchoredPosition = waypoints[currentWaypointIndex].anchoredPosition;
//    }
//    else
//    {
//        // Se o valor do dado ultrapassar o número de waypoints, a peça permanece na última casa
//        gameObject.GetComponent<RectTransform>().anchoredPosition = waypoints[waypoints.Length - 1].anchoredPosition;
//    }
//}
