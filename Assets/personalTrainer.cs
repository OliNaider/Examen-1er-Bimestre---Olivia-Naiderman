using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personalTrainer : MonoBehaviour
{
    public string tipoEntrenamiento;
    public int cantHoras;

    int precioPorHora;
    int precioSinDescuento;
    int precioConDescuento;
    int descuento;

    // Start is called before the first frame update
    void Start()
    {
        
        if (cantHoras < 1 || cantHoras > 6)
        {
            Debug.Log("Error. Horas no validas");
            return;
        }

        if (tipoEntrenamiento == "cardio")
        {
            precioPorHora = 1000;
        }
        else if (tipoEntrenamiento == "fuerza")
        {
            precioPorHora = 1500;
        }
        else if (tipoEntrenamiento == "recreativo")
        {
            precioPorHora = 2500;
        } else
        {
            Debug.Log("Valor invalido");
            return;
        }

        precioSinDescuento = cantHoras * precioPorHora;

        if (cantHoras == 6)
        {
            descuento = (precioSinDescuento / 100) * 10;
            precioConDescuento = precioSinDescuento - descuento;
        }

        Debug.Log("Ha elegido el tipo de entrenamiento: " + tipoEntrenamiento + " con " + cantHoras + " horas reservadas ");
        Debug.Log("Precio sin descuento: " + precioSinDescuento + " y precio con descuento: " + precioConDescuento);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}