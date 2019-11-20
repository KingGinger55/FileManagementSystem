using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// The DatabaseConnection class encompasses all queries that will be made on the database. 
/// </summary>
public class DatabaseConnection
{
    public bool loginSuccess = false;

    // Reference to the local host
    static string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password= ;database=filemanagementdatabase;";
    //Creates a database connection with mysqlconnectionstring
    static MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);


    //Updates to old code
    //=======================================================================================================================================================================================================

    //Update to login, returns user info if login success and an empty arrray list if false
    public static String[] Login(String userName, String password)
    {
        String query;
        

        bool loginSuccess = false;

        query = $"SELECT * FROM useraccount WHERE password = AES_ENCRYPT('{password}', 'encryptKey') AND userName = '{userName}'";
        //SELECT userName FROM useraccount WHERE password = AES_ENCRYPT('yyyyyyyyyyyyy', 'encryptKey')

        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;

        String[] userInfo = new String[9];
        try
        {
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {

                while (myReader.Read())
                {
                    if (myReader.GetString(1) == userName)
                    {
                        MessageBox.Show(myReader.GetString(1) + "'s Account" + " Login Successful!");
                        loginSuccess = true;
                       
                    }
                    else
                    {
                        databaseConnection.Close();
                        loginSuccess = false;

                    }
                    //Console.WriteLine(myReader.GetString(0));
                }

                for (int i = 0; i < 9; i++)
                {
                    userInfo[i] = (Convert.ToString(myReader[i]));
                }

            }
            if (loginSuccess == false)
            {
                databaseConnection.Close();
                return new string[0];
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            MessageBox.Show((String)e.Message);
        }
        databaseConnection.Close();

        return userInfo;
    }




    ///Creates a new user in the database.  Account type defaults to a normal unless specified as admin/superUser in the optional accountType parameter.
    public static void CreateUser(String userName, String email, String fName, String lName, String password, String confirmPassword, String securityQuestion, String securityQuestionAnswer, String accountType = "")
    {

            string createUser;

            int initial = initialSetup();

            //Empty string for the parameter accountType creates a normal user, otherwise they are the specified accountType
            if (initial >= 1)
            {
                createUser = "INSERT INTO `useraccount` (`uID`, `userName`, `email`, `fName`, `lName`, `password`, `accountType`, `securityQuestion`, `securityQuestionAnswer`) " +
               $"VALUES (NULL, '{userName}', '{email}', '{fName}', '{lName}', AES_ENCRYPT('{password}', 'encryptKey'), 'user', '{securityQuestion}', '{securityQuestionAnswer}')";
            }
            else
            {
                createUser = "INSERT INTO `useraccount` (`uID`, `userName`, `email`, `fName`, `lName`, `password`, `accountType`, `securityQuestion`, `securityQuestionAnswer`) " +
               $"VALUES (NULL, '{userName}', '{email}', '{fName}', '{lName}', AES_ENCRYPT('{password}', 'encryptKey'), 'super admin', '{securityQuestion}', '{securityQuestionAnswer}')";
            }

            ExecuteQuery(createUser, "User successfuly created!");


        string createUserFolder = $"INSERT INTO `folder`(folderName, ownerUID) SELECT userName, uID FROM useraccount WHERE userName = '{userName}'";
        ExecuteQuery(createUserFolder);
        System.IO.Directory.CreateDirectory($"C:/DSDB/{userName}");





    }








    ///Returns an integer array with zero in each index of no error is detected.  Returns a 1 in the index if there is an error.
    ///The layout for the fields are as follows [userName, email, fName, lName, password, confirmPassword, securityQuestion, securityQuestionAnswer]  so if there are no errors the array would look like this[0,0,0,0,0,0,0,0].
    ///and if there is an error with the email it will look like this[0,1,0,0,0,0,0,0].  This method will eventually need to be updated with regex.  
    public static int[] AuthenticateRegistrationForm(String userName, String email, String fName, String lName, String password, String confirmPassword, String securityQuestion, String securityQuestionAnswer)
    {

        int[] fieldErrors = { 0, 0, 0, 0, 0, 0, 0, 0};

        String[] authFormErrors = { userName, email, fName, lName, password, confirmPassword, securityQuestion, securityQuestionAnswer };


        for (int i = 0; i < authFormErrors.Length; i++)
        {
            if (authFormErrors[i] == "")
            {
                fieldErrors[i] = 1;
            }
        }

        if (ValidateNewAccount(userName, email) == 1)
        {
            fieldErrors[0] = 1;
            fieldErrors[1] = 1;
        }
        
        if (password == "" || password.Length < 13 || confirmPassword == "" || confirmPassword.Length < 13 || confirmPassword != password)
        {
            fieldErrors[4] = 1;
            fieldErrors[5] = 1;
        }

        return fieldErrors;
    }



    ///Checks the database for a previously existing account.  If the Username/Email already exists, this method will return a 1;
    private static int ValidateNewAccount(String userName, String email)
    {
        //Need to find a way to hide the encryption key for AES_ENCRYPT() mysql function.
        string query1 = $"SELECT `userName` FROM `useraccount` WHERE `userName` = '{userName}'";
        string query2 = $"SELECT `email` FROM `useraccount` WHERE `email` = '{email}'";
        //set to 1 if username is found
        int containsUserName = 0;
        int containsEmail = 0;

        MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        containsUserName = ExecuteQuery(query1);
        containsEmail = ExecuteQuery(query2);


        if (containsUserName == 1 || containsEmail == 1)
        {
            if (containsUserName == 1)
            {
                MessageBox.Show("Username already exists!");
            }

            if (containsEmail == 1)
            {
                MessageBox.Show("Email already exists!");
            }

            commandDatabase.Connection.Close();
            return 1;
        }
        else
        {
            commandDatabase.Connection.Close();
            return 0;
        }
       
    }




    ///Input query as a string, the message is a resulting message box with text. If an empty string is entered no message will show.  
    ///Returns 0 unless the query returns data, then it returns a 1;
    ///This method executes the query, so if you were to drop a table in the query it will.  Security precautions need to be implemented with this method.
    public static int ExecuteQuery(string query, string optionalMessage = "")
    {

        //Creates a database connection with mysqlconnectionstring
        MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);
        int containsData = 0;
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        try
        {
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {
                containsData = 1;

                while (myReader.Read())
                {
                    //Console.WriteLine(myReader.GetString(0));
                    //MessageBox.Show(myReader.GetString(0) + " Login successful!");


                }

            }
            if (optionalMessage != "")
            {
                MessageBox.Show(optionalMessage);
                //closeWindow = 1;
            }


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            MessageBox.Show((String)e.Message);
        }
        databaseConnection.Close();

        return containsData;
    }
    //
    ///This method is always called when a user is created.  It checks the database for user accounts, if there are none then the first user is automatically
    ///the super admin.  This makes a manage user option available in the main menu, so that individual accounts can be deleted from the database.  This will also 
    ///make all files navigible from the main menu, including other users files. Returns the number of users in the DB.
    private static int initialSetup()
    {
        String query = "SELECT COUNT(*) FROM useraccount";
        int userCount = 0;

        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;

        try
        {
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();

            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader.GetString(0));
                    userCount = myReader.GetInt32(0);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            MessageBox.Show((String)e.Message);
        }
        databaseConnection.Close();
        //MessageBox.Show(userCount.ToString());
        return userCount;
    }





}





