using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. 
//Luego indicar cuánto dinero sobra o falta.


public class Ejercicio_2 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    // Start is called before the first frame update
    void Start()
    {
        if (producto1 + producto2 + producto3 > monto)
        {
            Debug.Log("El precio de los 3 productos supera el monto que tienes. Faltan " + ((producto1 + producto2 + producto3) - monto));
        }
        else
        {
            Debug.Log("El precio de los 3 productos alcanza con el monto que tienes. Sobran " + (monto - (producto1 + producto2 + producto3)));
        }
    }

    
}
