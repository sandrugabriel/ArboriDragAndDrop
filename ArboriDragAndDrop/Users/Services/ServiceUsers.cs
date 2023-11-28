using ArboriDragAndDrop.Users.Models;
using ArboriDragAndDrop.Users.Services.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ArboriDragAndDrop.Users.Services
{
    public class ServiceUsers : IServiceUsers
    {


        List<User> users;

        public ServiceUsers()
        {

            users = new List<User>();

            load();

        }

        public string Path()
        {
            return @"\data\users.txt";
        }

        public void load()
        {

            string path = Application.StartupPath + Path();

            StreamReader streamReader = new StreamReader(path);

            string t = "";

            while ((t = streamReader.ReadLine()) != null)
            {
                users.Add(new User(t));
            }

            streamReader.Close();
        }

        public void saveFisier(string text)
        {
            File.AppendAllText(Application.StartupPath + Path(), text + "\n");
        }

        public User getById(int id)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].Id)
                {
                    return users[i];
                }
            }

            return null;
        }

        public int generareIdUser()
        {

            Random rand = new Random();

            int id = rand.Next(1, 10000);

            while (this.getById(id) != null)
            {
                id = rand.Next(1, 10000);
            }

            return id;
        }

        public List<User> getAllUser()
        {
            return users;
        }

        public User getByEmailPass(string email, string pass)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email == email && users[i].Password == pass) return users[i];
            }

            return null;
        }

        public void save(List<User> users)
        {
            this.users = users;
        }
            
        public bool verificationEmail(string email)
        {

            for(int i=0; i<users.Count; i++)
            {
                if (users[i].Email == email) return false;
            }
            
            return true;
        }

/*
        public string toSaveFisier()
        {
            string t = "";

            for (int i = 0; i < users.Count; i++)
            {
                t += users[i].toSave() + "\n";
            }
            return t;
        }

        public void update()
        {
            string path = Application.StartupPath + Path();
            StreamWriter writer = new StreamWriter(path);
            writer.Write(this.toSaveFisier());
            writer.Close();
        }

        public void setAll(int id, string name, string email, string pass, string address, string phone)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (id == users[i].getId())
                {
                    users[i].setName(name);
                    users[i].setEmail(email);
                    users[i].setAddress(address);
                    users[i].setPhone(phone);
                    users[i].setPassword(email);

                }
            }

        }
*/


    }
}
