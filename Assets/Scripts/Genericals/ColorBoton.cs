using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBoton : MonoBehaviour
{
    public Color colorear = new Color();
    public Image imagen;
   
    public void ChangeColor()
    {
        colorear = new Color(Random.value, Random.value, Random.value);
        imagen.color = colorear;
    }

    public class ColorData
    {
        //Variables para serializar
        public Color nuevoColor;

        //Constructor de la clase
        public ColorData(Color color)
        {
            //Rellenamos las variables con las que le pasamos por parámetro
            this.nuevoColor = color;
        }
    }

    //Crearemos un objeto serializable capaz de ser guardado
    public JObject Serialize()
    {
        //Instanciamos la clase anidada pasándole por parámetro las variables que queremos guardar
        ColorData data = new ColorData(colorear);

        //Creamos un string que guardará el jSon
        string jsonString = JsonUtility.ToJson(data);
        //Creamos un objeto en el jSon
        JObject retVal = JObject.Parse(jsonString);
        //Al ser un método de tipo, debe devolver este tipo
        return retVal;
    }

    //Tendremos que deserializar la información recibida
    public void Deserialize(string jsonString)
    {
        ColorData data = new ColorData(colorear);
        //La información recibida del archivo de guardado sobreescribirá los campos oportunos del jsonString
        JsonUtility.FromJsonOverwrite(jsonString, data);

        // Actualizamos los datos del enemigo con los datos del archivo de guardado
        this.colorear = data.nuevoColor;
        imagen.color = colorear;
    }
}
