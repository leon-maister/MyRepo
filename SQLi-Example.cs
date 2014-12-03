namespace ns1
{


    class MyClass
    {
    
        void abc(string inp)
        {
		  System.Windows.Forms.TextBox textUserName;
		  SqlConnection conn = new SqlConnection(connectionString);
         
		 String LeonMaister = "hello";
		 
		  SqlCommand command = conn.CreateCommand();
		  command.CommandText = sqlString + "'" + textUserName.Text + "'" + sqlStringAccessCode + "'" + textAccessCode.Text + "'";
		  reader = command.ExecuteReader(); 

		  SqlCommand command2 = conn.CreateCommand();
                  command2.CommandText = mySuperClean(sqlString + "'" + textUserName.Text + "'" + sqlStringAccessCode + "'" + textAccessCode.Text + "'");
		  reader = command2.ExecuteReader(); 		  
		  
                  storemySuperDB(command.CommandText);  
		
        }

    }
}