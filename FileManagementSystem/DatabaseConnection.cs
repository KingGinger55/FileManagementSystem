using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    //Registration fields for highlighting the registration form in th event that theres improper input. Set to 1 if theres an error.  
    public int userNameError;
    public int fNameError;
    public int lNameError;
    public int emailError;
    public int passwordError;
    public int confirmPasswordError;
    public int securityQuestionError;
    public int securityAnswerError;
    public int validationStatus;
    public int authStatus;
    public int closeWindow = 0;
   


    // Reference to the local host
    static string mySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password= ;database=filemanagementdatabase;";
    //Creates a database connection with mysqlconnectionstring
    static MySqlConnection databaseConnection = new MySqlConnection(mySQLConnectionString);


 



    //Account type defaults to a normal unless specified as admin/superUser in the optional accountType parameter
    public void CreateUser(String userName, String email, String fName, String lName, String password, String confirmPassword, String securityQuestion, String securityQuestionAnswer, String accountType = "")
    {
        this.validationStatus = ValidateNewAccount(userName, email);
        authStatus = AuthenticateRegistrationForm(userName, email, fName, lName, password, confirmPassword, securityQuestion, securityQuestionAnswer);


        if (validationStatus == 0 && authStatus == 0)
        {

            //Need to find a way to hide the encryption key for AES_ENCRYPT() mysql function.
            string query;

            //Empty string for the parameter accountType creates a normal user, otherwise they are the specified accountType
            if (accountType == "")
            {
                query = "INSERT INTO `useraccount` (`uID`, `userName`, `email`, `fName`, `lName`, `password`, `accountType`, `securityQuestion`, `securityQuestionAnswer`) " +
               $"VALUES (NULL, '{userName}', '{email}', '{fName}', '{lName}', AES_ENCRYPT('{password}', 'encryptKey'), 'user', '{securityQuestion}', '{securityQuestionAnswer}')";
            }
            else
            {
                query = "INSERT INTO `useraccount` (`uID`, `userName`, `email`, `fName`, `lName`, `password`, `accountType`, `securityQuestion`, `securityQuestionAnswer`) " +
               $"VALUES (NULL, '{userName}', '{email}', '{fName}', '{lName}', AES_ENCRYPT('{password}', 'encryptKey'), '{accountType}', '{securityQuestion}', '{securityQuestionAnswer}')";
            }

            executeQuery(query, "It Works");
        }
    }





    //Sets public fields so that the form can highlight any inproper inputs  
    private int AuthenticateRegistrationForm(String userName, String email, String fName, String lName, String password, String confirmPassword, String securityQuestion, String securityQuestionAnswer)
    {
        //If this method passes all checks returns 0
        int authState = 0;
        //These if statement highlight the register form text boxes based off of their class variables state. (I know, this method looks sloppy)
       if(userName == "" || email == "" || fName == "" || lName == "" || password == "" || confirmPassword == "" || securityQuestion == "" || securityQuestionAnswer == "")
        {
            authState = 1;
        }
       if(this.validationStatus == 1 || this.validationStatus == 2)
        {
            this.emailError = 1;
            this.userNameError = 1;
            authState = 1;
        }
       if(userName == "")
        {
            this.userNameError = 1;
            authState = 1;
        }
        if (email == "")
        {
            this.emailError = 1;
            authState = 1;
        }
        if (fName == "")
        {
            this.fNameError = 1;
            authState = 1;
        }
        if (lName == "")
        {
            this.lNameError = 1;
            authState = 1;
        }
        if (password == "" || password.Length < 13 || confirmPassword == "" || confirmPassword.Length < 13 || confirmPassword != password)
        {
            this.passwordError = 1;
            this.confirmPasswordError = 1;
            authState = 1;
        }
        if (securityQuestion == "" )
        {
            this.securityQuestionError = 1;
            authState = 1;
        }
        if (securityQuestionAnswer == "")
        {
            this.securityAnswerError = 1;
            authState = 1;
        }

        return authState;
    }





    //Checks the database for a previously existing account.  If the Username/Email already exists, this method will return a 1 and a message box for each field.
    private int ValidateNewAccount(String userName, String email)
    {
        //Need to find a way to hide the encryption key for AES_ENCRYPT() mysql function.
        string query1 = $"SELECT `userName` FROM `useraccount` WHERE `userName` = '{userName}'";
        string query2 = $"SELECT `email` FROM `useraccount` WHERE `email` = '{email}'";
        //set to 1 if username is found
        int containsUserName = 0;
        int containsEmail = 0;

        MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        containsUserName = executeQuery(query1);
        containsEmail = executeQuery(query2);


        int containsStaus = containsEmail + containsUserName;
        return containsStaus;
    }

    /*private int changePassword(String newPassword, String currentPassword, String userName)
    {

        string query1 = $"SELECT `userName` FROM `useraccount` WHERE `userName` = '{userName}'";

        MySqlCommand commandDatabase = new MySqlCommand(query1, databaseConnection);
        commandDatabase.CommandTimeout = 60;


    }*/


    //Input query as a string, the message is a resulting message box with text. If an empty string is entered no message will show.  Returns 0 unless the query returns data, then it returns a 1;
    private int executeQuery(String query, String  optionalMessage = "")
    {
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
                    //Console.WriteLine(myReader.GetString(0) + "-" + myReader.GetString(1) + "-" + myReader.GetString(2) + "-" + myReader.GetString(3));
                    
                }
                
            }
            if(optionalMessage != "")
            {
                MessageBox.Show(optionalMessage);
                closeWindow = 1;
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
}

