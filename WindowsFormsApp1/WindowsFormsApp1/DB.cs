﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("Data Source=APPK-MAIN;Initial Catalog=FahritdinovDb;Integrated Security=True");
    }
}
