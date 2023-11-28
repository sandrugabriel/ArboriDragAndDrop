using ArboriDragAndDrop.Users.Models;
using System.Collections.Generic;

namespace ArboriDragAndDrop.Users.Services.interfaces
{
    public interface IServiceUsers
    {
        string Path();

        void saveFisier(string text);

        User getById(int id);

        int generareIdUser();

        List<User> getAllUser();

        User getByEmailPass(string email, string pass);

        void save(List<User> users);

        bool verificationEmail(string email);

    }

}
