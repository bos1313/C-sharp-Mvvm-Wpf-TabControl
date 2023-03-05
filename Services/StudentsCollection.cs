using CommunityToolkit.Mvvm.ComponentModel;
using Npgsql;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using TabStudents.Model;

namespace TabControl.Services
{
    [ObservableObject]
    public partial class StudentsCollection
    {
        public ObservableCollection<Students> People { get; set; }

        private ObservableCollection<Students> _people = new ObservableCollection<Students>();

        public ObservableCollection<Students> GetItems()
        {
            return _people;
        }

        public StudentsCollection()
        {
            CreateCollection();
        }
        private void CreateCollection()
        {
            var people = new ObservableCollection<Students>();
         
            try
            {
                CRUD.con.Open();

                CRUD.adp = new NpgsqlDataAdapter("SELECT CONCAT(firstname, ' ', lastname) AS full_name, " +
                    "id, firstname, lastname,TO_CHAR(dob,'dd.MM.yyyy.') dob FROM students ORDER BY firstname ", CRUD.con);

               
                DataTable dt = new DataTable();
                CRUD.adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    people.Add(new Students()
                    {
                        Id = (int)row["id"],
                        FullName = (string)row["full_name"],
                        FirstName = (string)row["firstname"],
                        LastName = (string)row["lastname"],
                        Dob = (string)row["dob"]
                    });
                }
                People = people;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CRUD.con.Close();
               
            }


        }
    }
}
