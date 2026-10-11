using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterDataTest : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        SqliteDatabase sqlDB = new SqliteDatabase("config.db");
        string createTableQuery = "CREATE TABLE contacts(contact_id INTEGER PRIMARY KEY,name TEXT NOT NULL)";
        sqlDB.ExecuteNonQuery(createTableQuery);

        string insertQuery = "INSERT INTO contacts (name) VALUES('Bud Powell')";
        sqlDB.ExecuteNonQuery(insertQuery);

        //string query = "INSERT INTO User(UserName) VALUES( ‘Santiago’)";
        //sqlDB.ExecuteNonQuery(query);
        text.text = "Create table contacts and insert a row.";
    }
}
