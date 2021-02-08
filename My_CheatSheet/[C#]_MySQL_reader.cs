using MySql.Data.MySqlClient;

public List<UserPrivileges> LoadUsersRoles(string sql)
        {
            List<UserPrivileges> allPrivileges = new List<UserPrivileges>();

            using (var conn = new MySqlConnection(LoadConnectionString()))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        UserPrivileges userPrivileges = new UserPrivileges();
                        //user.user_id = (int)rdr[0];
                        //user.login = rdr[1].ToString();
                        //user.role = rdr[2].ToString();

                        allPrivileges.Add(userPrivileges);
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
            }

            return null;
        }