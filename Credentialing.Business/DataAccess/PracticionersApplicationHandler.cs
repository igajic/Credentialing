using Credentialing.Entities.Data;
using Credentialing.Entities.Steps;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Credentialing.Business.DataAccess
{
    public class PracticionersApplicationHandler
    {
        private static PracticionersApplicationHandler _instance;

        public static PracticionersApplicationHandler Instance
        {
            get { return _instance ?? new PracticionersApplicationHandler(); }
        }

        private PracticionersApplicationHandler()
        {
            
        }

        public PracticionerApplication GetPracticionerApplicationByUserId(Guid userId)
        {
            using (var dbContext = new CredentialingContext())
            {
                dbContext.PracticionerApplications.Load();
                var data = dbContext.PracticionerApplications.FirstOrDefault(s => s.UserId.Equals(userId));

                return data;
            }
        }

        public void SaveIdentifyingInformation(IdentifyingInformation info)
        {
            using (var dbContext = new CredentialingContext())
            {
                /*
                if (info.IdentifyingInformationId != 0)
                {
                    dbContext.IndentifyingInformations.Attach(info);
                    dbContext.Entry(info).State = EntityState.Modified;
                }
                else
                {
                    dbContext.IndentifyingInformations.AddOrUpdate(info);
                }*/

                dbContext.IndentifyingInformations.AddOrUpdate(info);

                dbContext.SaveChanges();
            }
        }

        public void SavePracticionerApplication(PracticionerApplication application)
        {
            using (var dbContext = new CredentialingContext())
            {
                if (application.PracticionerApplicationId != 0)
                {
                    var app = dbContext.PracticionerApplications.FirstOrDefault(a => a.UserId.Equals(application.UserId));
                    var id = app.PracticionerApplicationId;
                    //application.IdentifyingInformationId = application.IdentifyingInformation.IdentifyingInformationId;
                    application.PracticionerApplicationId = id;
                    dbContext.PracticionerApplications.AddOrUpdate(application);
                    //dbContext.Entry(application).State = EntityState.Modified;

                    //((IObjectContextAdapter) dbContext).ObjectContext.ObjectStateManager.ChangeRelationshipState(application.IdentifyingInformation, application, s => s.IdentifyingInformationId, EntityState.Added);
                }
                else
                {
                    dbContext.PracticionerApplications.Add(application);
                }

                int state = dbContext.SaveChanges();
            }
        }

        public IdentifyingInformation GetIdentifyingInformation(int p)
        {
            using (var dbContext = new CredentialingContext())
            {
                return dbContext.IndentifyingInformations.FirstOrDefault(s => s.IdentifyingInformationId == p);
            }
        }
    }
}