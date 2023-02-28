using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFile
{
    public partial class Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();


        void LoadListFromFile()
        {
            //load file
            string[] lines = File.ReadAllLines("C:\\Users\\Krostoffer\\source\\repos\\SmallProjects\\TextFile\\Data\\StandardDataSet.csv");

            //parse each line
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');

                //create model from line
                //add model to list

                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = bool.Parse(columns[3]),
                });
            }


        }

    }
}
