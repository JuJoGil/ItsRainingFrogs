using System.Collections;
using System.Collections.Generic;
using System.IO; //Usar StreamWriter y StreamReader
using Newtonsoft.Json.Linq; //Para poder usar Json.net y estructuras de datos
using System.Security.Cryptography; //Libería para encriptación y desencriptación de información
using UnityEditor;
using UnityEngine;

public static class JsonManager {

#if UNITY_EDITOR
    [MenuItem("Tools/JSON/Delete save")]
    public static void DeleteSave() {
        string saveFilePath = Application.persistentDataPath + "/jsonSavegame.sav";
        if (File.Exists(saveFilePath)) {
            File.Delete(saveFilePath);
        }
    }
#endif

    public static void SaveGame(ColorBoton color) {
        //Generamos un jObject para guardar la información serializada más abajo
        JObject jSaveGame = new JObject();

        
        /// Color

        //Generamos un jObject pasandole el color concreto serializado
        JObject serializedPlayer = color.Serialize();
        //En el objecto jSon archivo de guardado, añadimos la información que queremos de los objetos serializados
        jSaveGame.Add(color.name, serializedPlayer);

        //Ruta donde queremos guardar la información
        string saveFilePath = Application.persistentDataPath + "/jsonSavegame.sav";

        //Creamos un array de bytes para guardar el array que nos devuelve el método Encrypt para que pueda ser usado
        byte[] encryptSavegame = Encrypt(jSaveGame.ToString());
        //Escribimos esta información en el archivo de guardado, ya encriptada la información en su ruta 
        File.WriteAllBytes(saveFilePath, encryptSavegame);
        //Muestra la ruta del archivo por consola
        Debug.Log("Saving to: " + saveFilePath);
    }

    public static void LoadGame(ColorBoton color) {
        //Ruta de donde queremos leer la información
        string saveFilePath = Application.persistentDataPath + "/jsonSavegame.sav";
        //Muestra la ruta del archivo por consola
        Debug.Log("Loading from: " + saveFilePath);

        if (File.Exists(saveFilePath)) {
            //Creamos un array con la información encriptada recibida
            byte[] decryptedSavegame = File.ReadAllBytes(saveFilePath);
            //Creamos un array donde guardar la información desencriptada recibida
            string jsonString = Decrypt(decryptedSavegame);

            //Generamos un jObject al que le pasamos la información del jSon
            JObject jSaveGame = JObject.Parse(jsonString);

            /// Color

            //Generamos un string para cargar la información sacada del archivo de guardado para esa instancia
            string playerJsonString = jSaveGame[color.name].ToString();
            //Llamamos al método que deserializa la información obtenida
            color.Deserialize(playerJsonString);
        }
        else {
            Debug.Log("Save file not found in " + saveFilePath);
        }

    }

    /*
     * PARA ENCRIPTAR Y DESENCRIPTAR LA INFORMACIÓN DEL ARCHIVO DE GUARDADO
     */

    //Clave generada para la encriptación en formato bytes, 16 posiciones
    static byte[] _key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

    //Vector de inicialización para la clave
    static byte[] _initializationVector = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

    //Encriptamos los datos del archivo de guardado que le pasaremos en un string
    static byte[] Encrypt(string message) {
        //Usamos esta librería que nos permitirá a través de una referencia crear un encriptador de la información
        AesManaged aes = new AesManaged();
        //Para usar este encriptador le pasamos tanto la clave como el vector de inicialización que hemos creado nosotros arriba
        ICryptoTransform encryptor = aes.CreateEncryptor(_key, _initializationVector);
        //Lugar en memoria donde guardamos la información encriptada
        MemoryStream memoryStream = new MemoryStream();
        //Con esta referencia podremos escribir en el MemoryStream de arriba la información ya encriptada usando el encriptador con sus claves que ya habíamos creado
        CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        //Con el StreamWriter podemos escribir en el archivo la información encriptada, que se habrá guardado en el MemoryStream
        StreamWriter streamWriter = new StreamWriter(cryptoStream);

        //Usando todo lo anterior, guardamos en el archivo de guardado el json que le pasamos por parámetro, haciendo el siguiente proceso: recibimos el string, lo encriptamos, queda guardado en la memoria reservada para la encriptación
        streamWriter.WriteLine(message);

        //Una vez hemos usado estas referencias las cerramos para evitar problemas de guardado o corrupción del archivo o de la propia encriptación
        streamWriter.Close();
        cryptoStream.Close();
        memoryStream.Close();

        //Por último el método devolverá esta información que reside en el hueco de memoria con la información encriptada, convertida esta información en array de bytes
        return memoryStream.ToArray();
    }

    //Generamos un método que nos devuelva la información del archivo de guardado desencriptada
    static string Decrypt(byte[] message) {
        //Usamos esta librería que nos permitirá a través de una referencia crear un desencriptador de la información
        AesManaged aes = new AesManaged();
        //Para usar este desencriptador le pasamos tanto la clave como el vector de inicialización que hemos creado nosotros arriba
        ICryptoTransform decrypter = aes.CreateDecryptor(_key, _initializationVector);
        //Lugar en memoria donde guardamos la información desencriptada
        MemoryStream memoryStream = new MemoryStream(message);
        //Con esta referencia podremos escribir en el MemoryStream de arriba la información ya desencriptada usando el desencriptador con sus claves que ya habíamos creado
        CryptoStream cryptoStream = new CryptoStream(memoryStream, decrypter, CryptoStreamMode.Read);
        //Con el StreamReader podemos leer del archivo la información desencriptada, que se habrá guardado en el MemoryStream
        StreamReader streamReader = new StreamReader(cryptoStream);

        //Usando todo lo anterior, cargamos del archivo de guardado el json que le pasamos por parámetro, haciendo el siguiente proceso: recibimos el string, lo desencriptamos, queda guardado en la memoria reservada para la desencriptación
        string decryptedMessage = streamReader.ReadToEnd();

        //Una vez hemos usado estas referencias las cerramos para evitar problemas de guardado o corrupción del archivo o de la propia encriptación
        streamReader.Close();
        cryptoStream.Close();
        memoryStream.Close();

        //Por último el método devolverá esta información que reside en el hueco de memoria con la información desencriptada, convertida esta en un string
        return decryptedMessage;
    }
}
