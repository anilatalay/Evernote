using Evernote.DataAccessLayer.EntityFramework;
using Evernote.Entities;
using Evernote.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evernote.BusinessLayer
{
    public class UserManager
    {
        private Repository<DUser> repo_user = new Repository<DUser>();

        public BusinessLayerResult<DUser> RegisterUser(RegisterViewModel data)
        {
            var user = repo_user.Find(x => x.UserName == data.UserName || x.Email == data.Email);
            BusinessLayerResult<DUser> layerResult = new BusinessLayerResult<DUser>();

            if (user != null)
            {
                if (user.UserName == data.UserName)
                {
                    layerResult.Errors.Add("Kullanıcı Adı Kayıtlı.");
                }

                if (user.Email == data.Email)
                {
                    layerResult.Errors.Add("Eposta Kayıtlı.");
                }
            }
            else
            {
                //int dbResult = repo_user.Insert(new DUser
                //{
                //    UserName = data.UserName,
                //    Email = data.Email,
                //    Password = data.Password
                //});

                //if(dbResult > 0)
                //{
                //    layerResult.Result = repo_user.Find(x => x.Email == data.Email && x.UserName == data.UserName);

                //    // TODO : Aktivasyon Maili Atılacak.
                //}
            }

            return layerResult;
        }
    }
}
