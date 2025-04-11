using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    //1. Declaración de variables

    public string codigoGusto;
    public int cantHeladoEnGramos;

    float costoFinalHelado;

    // Start is called before the first frame update
    void Start()
    {

        //2. Validación de los datos
        if (cantHeladoEnGramos < 250 || cantHeladoEnGramos > 3000)
        {
            Debug.Log("Cantidad de helado no válida");
            return;
        }

        if (codigoGusto != "CHO" && codigoGusto != "DDL" && codigoGusto != "FRU")
        {
            Debug.Log("Codigo no válido");
            return;
        }

        //3. Procesamiento de datos

        costoFinalHelado = cantHeladoEnGramos * 1250 / 1000f;

        if(codigoGusto == "FRU")
        {
            costoFinalHelado = costoFinalHelado * 0.9f;
        }
        

        //4. Salida de datos

        Debug.Log("Debe abonar $" + costoFinalHelado);
        

    }

    // Update is called once per frame
    void Update()
    
    {
        
    }
}
